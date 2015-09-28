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
    readonly public string SettingsFileName = "mu-settings.config";
    
    string AssemblyFolderName { get { return Path.GetDirectoryName(Assembly.GetAssembly(typeof(ToolSettings)).Location); } }
    
    public string LoadSettings()
    {
      string result = string.Empty;
      try
      {
        var settingsFileName= Path.Combine(AssemblyFolderName, SettingsFileName);
        if (File.Exists(settingsFileName))
        {
          using (var sr = new StreamReader(settingsFileName))
            result = sr.ReadLine();
        }
      }
      catch (Exception ex)
      {
        System.Windows.MessageBox.Show("There was some error during loading settings:" + Environment.NewLine + ex, "ThemeTool Error");
      }
      return result;
    }
    public void SaveSettings(string themeName)
    {
      try
      {
        using (var sw = new StreamWriter(Path.Combine(AssemblyFolderName, SettingsFileName)))
          sw.WriteLine(themeName);
      }
      catch (Exception ex)
      {
        System.Windows.MessageBox.Show("There was some error during saving settings:" + Environment.NewLine + ex, "ThemeTool Error");
      }
    }
    readonly List<string> themesClassic = new List<string>{
      "classic","generic","luna.normalcolor","aero.normalcolor"
    };
    readonly Dictionary<string,string> themesDefault = new Dictionary<string,string>(){
      { "dev2010.orig",    "/AnotherThemeTool;component/src/assets/dev2010.xaml" },
      { "dev2010green",    "/AnotherThemeTool;component/src/assets/dev2010green.xaml" },
      { "dev2010red",      "/AnotherThemeTool;component/src/assets/dev2010red.xaml" },
      { "ExpressionDark" , "/AnotherThemeTool;component/src/assets/ExpressionDark.xaml" },
      { "ExpressionLight", "/AnotherThemeTool;component/src/assets/ExpressionLight.xaml" },
    };
    readonly Dictionary<string,string> themesNew = new Dictionary<string,string>(){
//      { "dev2010",   "/AnotherThemeTool;component/src/assets/dev2010_blue.xaml" },
      { "dev2o11",   "/AnotherThemeTool;component/src/assets/dev2o11.xaml" },
      { "dev2o11v2", "/AnotherThemeTool;component/src/assets/dev2o11v2.xaml" },
    };
    public void SetTheme(string themeName)
    {
      try
      {
        if (themesDefault.ContainsKey(themeName))
          ThemeFactory.ChangeTheme(new Uri(themesDefault[themeName], UriKind.RelativeOrAbsolute));
        
        else if (themesNew.ContainsKey(themeName))
          ThemeFactory.ChangeTheme(new Uri(themesNew[themeName], UriKind.RelativeOrAbsolute));
        
        else if (themeName == "dev2010")
        {
          ThemeTool.MsDev2010_Theme.Apply_Blue();
          ThemeFactory.ChangeTheme(new Uri("/AnotherThemeTool;component/src/assets/dev2010_blue.xaml", UriKind.RelativeOrAbsolute));
        }
        else if (themeName == "dev2o13")
        {
          ThemeFactory.ChangeTheme(new Uri("/AnotherThemeTool;component/src/assets/dev2o13.xaml", UriKind.RelativeOrAbsolute));
        }
        else if (themeName == "dev2o13-dyn")
        {
          MsDev2013_Theme.Apply();
          ThemeFactory.ChangeTheme(new Uri("/AnotherThemeTool;component/src/assets/dev2o13_dynamic.xaml", UriKind.RelativeOrAbsolute));
        }
        else if (themesClassic.Contains(themeName))
          ThemeFactory.ChangeTheme(themeName);
        
        else if (themeName.StartsWith("#",StringComparison.InvariantCulture))
          ThemeFactory.ChangeColors(themeName.ToColor());
        
        else if (themeName == "default")
          ThemeFactory.ResetTheme();
      }
      catch (Exception ex)
      {
        System.Windows.MessageBox.Show("There was some error during applying theme:" + Environment.NewLine + ex, "ThemeTool Error");
      }
    }
  }

}
