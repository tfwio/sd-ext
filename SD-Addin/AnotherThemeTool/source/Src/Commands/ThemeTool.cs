/* oio * 4/5/2014 * Time: 5:46 AM
 */

/*
 * User: AJ01
 * Date: 24.08.2011
 * Time: 0:39
 */

using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

using ICSharpCode.Core;
using ThemeTool.Logic;

namespace ThemeTool
{
  static class Extra
  {
    static public void Apply(this string themeId)
    {
      var settings = new ThemeTool.Logic.ToolSettings();
      var theme = new MsDev2013_Theme{ ResourceID=themeId };
      settings.SetTheme(theme);
      settings.SaveSettings(theme);
    }
  }
  public class ToolCommandDefault       : AbstractMenuCommand { public override void Run() { "default".Apply(); } }
  public class ToolCommandGeneric       : AbstractMenuCommand { public override void Run() { "generic".Apply(); } }
  public class ToolCommandAutumn        : AbstractMenuCommand { public override void Run() { "#FF800000".Apply(); } }
  public class ToolCommandGrass         : AbstractMenuCommand { public override void Run() { "#FF008000".Apply(); } }
  public class ToolCommandClassic       : AbstractMenuCommand { public override void Run() { "classic".Apply(); } }
  public class ToolCommandAero          : AbstractMenuCommand { public override void Run() { "aero.normalcolor".Apply(); } }
  public class ToolCommandLuna          : AbstractMenuCommand { public override void Run() { "luna.normalcolor".Apply(); } }
  public class ThemeToolCommandDev13    : AbstractMenuCommand { public override void Run() { "dev2o13-blue".Apply(); } }
  public class ThemeToolCommandDev13dyn : AbstractMenuCommand { public override void Run() { "dev2o13-dyn".Apply(); } }
  public class ThemeToolCommandDev11a   : AbstractMenuCommand { public override void Run() { "dev2o11".Apply(); } }
  public class ThemeToolCommandDev11b   : AbstractMenuCommand { public override void Run() { "dev2o11v2".Apply(); } }
  public class ToolCommandDev10         : AbstractMenuCommand { public override void Run() { "dev2010".Apply(); } }
  public class ToolCommandDev10_orig    : AbstractMenuCommand { public override void Run() { "dev2010.orig".Apply(); } }
  public class ToolCommandDev10Green    : AbstractMenuCommand { public override void Run() { "dev2010green".Apply(); } }
  public class ToolCommandDev10Red      : AbstractMenuCommand { public override void Run() { "dev2010red".Apply(); } }
  public class ToolCommandExpressDark   : AbstractMenuCommand { public override void Run() { "ExpressionDark".Apply(); } }
  public class ToolCommandExpressLight  : AbstractMenuCommand { public override void Run() { "ExpressionLight".Apply(); } }
  public class ToolCommandCustom : AbstractMenuCommand
  {
    public override void Run()
    {
      var colorDialog = new ColorDialog();
      var result = colorDialog.ShowDialog();
      if (result == DialogResult.OK)
      {
        var color = colorDialog.Color;
        string clrStr = "#" + color.ToArgb().ToString("X8");
        clrStr.Apply();
      }
    }
  }
  public class ToolCommandStartup : AbstractMenuCommand
  {
    public BackgroundWorker bw;
    public override void Run()
    {
      try
      {
        //string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetAssembly(GetType()).Location);
        //System.Reflection.Assembly.LoadFrom(System.IO.Path.Combine(path, "AvalonDock.Themes.dll"));
        bw = new BackgroundWorker();
        bw.DoWork += delegate
        {
          try
          {
            // TODO: if i replace code below as compiler says (Warning CS0618: 'ICSharpCode.SharpDevelop.Gui.WorkbenchSingleton.MainWindow' is obsolete: 'Use SD.Workbench.MainWindow instead')
            while (ICSharpCode.SharpDevelop.Gui.WorkbenchSingleton.MainWindow == null)
            {
              Thread.Sleep(100);
            }
            ICSharpCode.SharpDevelop.SD.Workbench.MainWindow.Dispatcher.Invoke
              (DispatcherPriority.Normal, new ThreadStart
               (
                 delegate
                 {
                   var settings = new ToolSettings();
                   var m = settings.LoadSettings();
                   if (m==null) return;
                   var t = m.Theme[0];
                   settings.SetTheme(t.ToTheme());
                   
                   
                 }
                )
              );
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString(), "ThemeTool Startup Error");
          }
        };
        bw.RunWorkerAsync();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "ThemeTool Startup Error");
      }
    }
  }
}