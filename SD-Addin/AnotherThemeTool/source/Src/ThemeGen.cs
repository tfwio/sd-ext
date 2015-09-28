using System;
using System.Windows.Forms;
using ThemeTool;
namespace System
{
  public enum ExecuteMode { ThemeToString, StringToTheme, ClassData, ClassString, }
  
  static public class ThemeGen
  {
    static public readonly SaveFileDialog SFD = new SaveFileDialog {
      Filter = "YAML File|*.yml"
    };

    static public string Execute(ExecuteMode mode, string text=null)
    {
      ThemeSetting setting = ThemeTool.ThemeSetting.Load(text ?? Strings.YamlThemeSchema);
      using (var strw = new System.IO.StringWriter())
      {
        foreach (var node in setting.Elements)
        {
          string result = null;
          switch (mode) {
              case ExecuteMode.ThemeToString: result = NodeToString(node); break;
              case ExecuteMode.StringToTheme: result = StringToNode(node); break;
              case ExecuteMode.ClassString: result = NodeToClassTheme(node); break;
              case ExecuteMode.ClassData: result = NodeToClassSetting(node); break;
          }
          if (!string.IsNullOrEmpty(result)) strw.WriteLine(result);
        }
        return strw.ToString();
      }
    }
    
    static public Func<ColourSetting, string> NodeToClassSetting = node => {
//      string.Format("      public {1,-22} {0,-45} {{ get; set; }}", node.Name, node.TypeName);
      switch (node.TypeName.ToLower()) {
        case "gradientstopcollection":
        case "fontfamily":
        case "string":
          return string.Format("    public {1,-22} {0,-45} {{ get; set; }}", node.Name, node.TypeName);
        case "color":
        case "double":
          return string.Format("    public {1,-21}? {0,-45} {{ get; set; }}", node.Name, node.TypeName);
        default:
          return null;
      }
    };

    static public Func<ColourSetting, string> NodeToClassTheme = node => string.Format("      public string {0,-45} {{ get; set; }}", node.Name, node.TypeName);

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
        default:
          return null;
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
        default:
          return null;
      }
    };
  }
}

