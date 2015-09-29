using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using AvalonDock;
using ThemeTool;

namespace ThemeTool.Logic
{
  /// <summary>Description of ToolSettings.</summary>
  public partial class ToolSettings
  {
    #region Name/Resource
    readonly List<string> themesClassic = new List<string>{
      "classic","generic",
      "luna.normalcolor",
      "aero.normalcolor"
    };
    readonly Dictionary<string,string> themesDefault = new Dictionary<string,string>(){
      { "dev2010.orig",    "/AnotherThemeTool;component/src/assets/dev2010.xaml" },
      { "dev2010green",    "/AnotherThemeTool;component/src/assets/dev2010green.xaml" },
      { "dev2010red",      "/AnotherThemeTool;component/src/assets/dev2010red.xaml" },
      { "ExpressionDark" , "/AnotherThemeTool;component/src/assets/ExpressionDark.xaml" },
      { "ExpressionLight", "/AnotherThemeTool;component/src/assets/ExpressionLight.xaml" },
    };
    #endregion
    
    readonly public string SettingsFileName = Path.Combine(AssemblyFolderName,"mu-settings.yaml");
    
    static string AssemblyFolderName { get { return Path.GetDirectoryName(Assembly.GetAssembly(typeof(ToolSettings)).Location); } }
    
    public MsDev2013SettingsCollection LoadSettings()
    {
      string result = string.Empty;
      try
      {
        if (File.Exists(SettingsFileName))
        {
          FileInfo finf = new FileInfo(SettingsFileName);
          return ThemeGen.LoadSettingsCollection(finf);
        }
      }
      catch (Exception ex)
      {
        System.Windows.MessageBox.Show("There was some error during loading settings:" + Environment.NewLine + ex, "ThemeTool Error");
      }
      return null;
    }
    public void SaveSettings(MsDev2013_Theme theme)
    {
      theme.SaveTheme(SettingsFileName);
    }
    public void SaveSettings(string themeName)
    {
      try
      {
        SaveSettings(new MsDev2013_Theme{ResourceID = themeName});
      }
      catch (Exception ex)
      {
        System.Windows.MessageBox.Show("There was some error during saving settings:" + Environment.NewLine + ex, "ThemeTool Error");
      }
    }
    
    public void SetTheme(MsDev2013_Theme themeName)
    {
      try
      {
        if (themesDefault.ContainsKey(themeName.ResourceID))
          ThemeFactory.ChangeTheme(new Uri(themesDefault[themeName.ResourceID], UriKind.RelativeOrAbsolute));
        
        else if (themeName.ResourceID == "dev2010")
        {
          ThemeTool.MsDev2010_Theme.Apply_Blue();
          ThemeFactory.ChangeTheme(new Uri("/AnotherThemeTool;component/src/assets/dev2010_blue.xaml", UriKind.RelativeOrAbsolute));
        }
        else if (themeName.ResourceID == "dev2o13-dyn")
        {
          MsDev2013_Theme.Instance = themeName;
          ThemeFactory.ChangeTheme(new Uri("/AnotherThemeTool;component/src/assets/dev2o13_dynamic.xaml", UriKind.RelativeOrAbsolute));
        }
        else if (themeName.ResourceID == "dev2o13-blue")
        {
          MsDev2013_Theme.Instance = MsDev2013_Theme.Apply();
          ThemeFactory.ChangeTheme(new Uri("/AnotherThemeTool;component/src/assets/dev2o13_dynamic.xaml", UriKind.RelativeOrAbsolute));
        }
        else if (themesClassic.Contains(themeName.ResourceID))
          ThemeFactory.ChangeTheme(themeName.ResourceID);
        
        else if (themeName.ResourceID.StartsWith("#",StringComparison.InvariantCulture))
          ThemeFactory.ChangeColors(themeName.ResourceID.ToColor());
        
        else if (themeName.ResourceID == "default") ThemeFactory.ResetTheme();
      }
      catch (Exception ex)
      {
        System.Windows.MessageBox.Show("There was some error during applying theme:" + Environment.NewLine + ex, "ThemeTool Error");
      }
    }
  }

}
