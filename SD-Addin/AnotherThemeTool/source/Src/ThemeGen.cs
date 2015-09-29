using System;
using System.Windows.Forms;
using ThemeTool;
namespace System
{
  public enum ExecuteMode { ThemeToString, StringToTheme, ClassData, ClassString, }
  
  static public partial class ThemeGen
  {
    static public readonly SaveFileDialog SFD = new SaveFileDialog { Filter = "YAML File|*.yml" };

    static public string Execute(ExecuteMode mode, string text=null)
    {
      ThemeSetting setting = ThemeTool.ThemeSetting.Load(text ?? Strings.YamlThemeSchema);
      
      using (var strw = new System.IO.StringWriter())
      {
        foreach (var node in setting.Elements)
        {
          string result = null;
          switch (mode) {
              case ExecuteMode.ThemeToString: result = NodeToString       (node); break;
              case ExecuteMode.StringToTheme: result = StringToNode       (node); break;
              case ExecuteMode.ClassString:   result = NodeToClassTheme   (node); break;
              case ExecuteMode.ClassData:     result = NodeToClassSetting (node); break;
          }
          if (!string.IsNullOrEmpty(result)) strw.WriteLine(result);
        }
        return strw.ToString();
      }
    }
    
    static public Func<ColourSetting, string> NodeToClassSetting = (ColourSetting node) => {
      switch (node.TypeName.ToLower()) {
        case "gradientstopcollection": case "fontfamily": case "string":
          return string.Format("    public {1,-22} {0,-45} {{ get; set; }}", node.Name, node.TypeName, node.Comment,node.DefaultValue);
        case "color": case "double":
          return string.Format("    public {1,-21}? {0,-45} {{ get; set; }}", node.Name, node.TypeName, node.Comment,node.DefaultValue);
        default: return null;
      }
    };

    static public Func<ColourSetting, string> NodeToClassTheme = node => string.Format("    public string {0,-45} {{ get; set; }}", node.Name, node.TypeName);

    static public Func<ColourSetting, string> NodeToString = node =>  {
      switch (node.TypeName.ToLower()) {
        case "string":
          return (string.Format("      settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45});", node.Name));
        case "double":
          return (string.Format("      settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45}).ToString();", node.Name));
        case "fontfamily":
          return (string.Format("      settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45}).ToString();", node.Name));
        case "color":
          return (string.Format("      settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45}).ToHexString(true);", node.Name));
        case "gradientstopcollection":
          return (string.Format("      settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45}).ToGradientStopString();", node.Name));
        default: return null;
      }
    };

    static public Func<ColourSetting, string> StringToNode = node =>  {
      switch (node.TypeName.ToLower()) {
        case "string":
          return (string.Format("      settings.{0} = (theme.{0} ?? tefaut.{0});", node.Name));
        case "fontfamily":
          return (string.Format("      settings.{0} = new FontFamily((theme.{0} ?? tefaut.{0}).ToString());", node.Name));
        case "double":
          return (string.Format("      settings.{0} = double.Parse(theme.{0} ?? tefaut.{0});", node.Name));
        case "color":
          return (string.Format("      settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45}).ToColor();", node.Name));
        case "gradientstopcollection":
          return (string.Format("      settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45}).ToStops();", node.Name));
        default: return null;
      }
    };
  
      #region Load
    static public MsDev2013SettingsCollection LoadSettingsCollection(System.IO.FileInfo Info)
    {
      var data = System.IO.File.ReadAllText(Info.FullName);
      MsDev2013SettingsCollection settings = null;
      using (var reader = new System.IO.StringReader(data))
      {
        var deserializer = new YamlDotNet.Serialization.Deserializer(ignoreUnmatched:false);
        try {
          settings = deserializer.Deserialize<MsDev2013SettingsCollection>(reader);
        } catch (Exception err) {
          System.Windows.MessageBox.Show(
            err.ToString(),
            "Error",
            System.Windows.MessageBoxButton.OK,
            System.Windows.MessageBoxImage.Error);
        }
      }
      return settings;
    }
    /// <summary>
    /// Themes are typically at index 0.
    /// </summary>
    static public MsDev2013_Theme Load2013Theme(System.IO.FileInfo Info, int index)
    {
      var settings = LoadSettingsCollection(Info);
      return MsDev2013Settings.FromTheme(settings.Theme[index]);
    }
    #endregion
    
    
    
    static public MsDev2013SettingsCollection Wrap(params MsDev2013Settings[] input)
    {
      return new MsDev2013SettingsCollection()
      {
        Theme = new System.Collections.Generic.List<MsDev2013Settings>(input)
      };
    }
    
    
    static public void SaveTheme(this MsDev2013_Theme theme)
    {
      using (var sfd = new System.Windows.Forms.SaveFileDialog() { Filter = "YAML File|*.yml" })
      {
        if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
        theme.SaveTheme(sfd.FileName);
      }
    }
    
    static public void SaveTheme(this MsDev2013_Theme theme, string fileName)
    {
      var serializer = new YamlDotNet.Serialization.Serializer();
      
      using (var writer = new System.IO.StringWriter())
      {
        var themeSettings = Wrap(MsDev2013Settings.FromTheme(theme));
        serializer.Serialize(writer, themeSettings, typeof(MsDev2013SettingsCollection));
        var stringdata = writer.ToString();
        System.IO.File.WriteAllText(fileName, stringdata);
      }
      serializer = null;
    }
  
  }
}

