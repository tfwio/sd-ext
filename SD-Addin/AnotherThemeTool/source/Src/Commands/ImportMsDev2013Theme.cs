/*
 * Created by SharpDevelop.
 * User: oio
 * Date: 11/20/2012
 * Time: 2:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Threading;
using ICSharpCode.Core;
namespace ThemeTool.Commands
{
  public class ImportMsDev2013Theme : AbstractMenuCommand
  {
    internal static System.IO.FileSystemWatcher watcher;
    internal static System.Windows.Forms.OpenFileDialog OFD =
      new System.Windows.Forms.OpenFileDialog() { Filter = "YAML File|*.yml" };
    
    internal static System.IO.FileInfo Info { get; set; }
    
    internal void watcher_Changed(object sender, System.IO.FileSystemEventArgs e)
    {
      ICSharpCode.SharpDevelop.SD.Workbench.MainWindow.Dispatcher.Invoke(Load,DispatcherPriority.Normal);
    }
    internal void CheckWatcher()
    {
      if (watcher==null) watcher = new System.IO.FileSystemWatcher();
      watcher.EnableRaisingEvents = false;
      System.Windows.MessageBox.Show(
        string.Format(Info==null?"wtf?":Info.FullName,Info==null ? "wtf":Info.Directory.Name)
       );
      watcher.Path=Info.Directory.FullName;
      watcher.Filter = Info.Name;
      watcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
      watcher.Changed -= watcher_Changed;
      watcher.Changed += watcher_Changed;
      watcher.EnableRaisingEvents = true;
    }
    internal void LoadWithWatcher()
    {
      CheckWatcher();
      Load();
    }
    internal void Load()
    {
      System.Threading.Thread.Sleep(900);
      var data = System.IO.File.ReadAllText(Info.FullName);
      var theme = ThemeGen.Load2013Theme(Info,0);
      MsDev2013_Theme.Instance = theme;
      try {
        AvalonDock.ThemeFactory.ChangeTheme(new Uri("/AnotherThemeTool;component/src/assets/dev2o13_dynamic.xaml",UriKind.RelativeOrAbsolute));
        var settings = new ThemeTool.Logic.ToolSettings();
        settings.SaveSettings(theme);
      } catch (Exception err) {
        System.Windows.MessageBox.Show(
          err.ToString(),
          "Error",
          System.Windows.MessageBoxButton.OK,
          System.Windows.MessageBoxImage.Error);
      }
    }
    
    /// <summary>
    /// Sets our (FileInfo) <see cref="Info">Info</see> property.
    /// </summary>
    // disable once MemberCanBeMadeStatic.Local
    internal bool DoDialog()
    {
      var result= OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK;
      if (result) Info = new System.IO.FileInfo(OFD.FileName);
      return result;
    }
    
    public override void Run()
    {
      if (DoDialog()) LoadWithWatcher();
    }
  }
  public class ReloadLastTheme : ImportMsDev2013Theme
  {
    public override void Run()
    {
      if (!ImportMsDev2013Theme.Info.Exists) {
        if (DoDialog()) Load();
      }
      else { Load(); }
      if (!Info.Exists) System.Windows.MessageBox.Show("nothing");
    }
  }
}


