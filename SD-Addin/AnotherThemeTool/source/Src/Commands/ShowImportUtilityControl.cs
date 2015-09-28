using System;

using ICSharpCode.Core;
using ICSharpCode.SharpDevelop.Workbench;
using ThemeTool.View;

namespace ThemeTool.Commands
{
  public class ShowImportUtilityControl : AbstractMenuCommand
  {
    public override void Run()
    {
      string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetAssembly(typeof(ICSharpCode.SharpDevelop.Gui.AboutSharpDevelopTabPage)).Location);
      string muPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetAssembly(typeof(ShowImportUtilityControl)).Location);
      System.Reflection.Assembly.LoadFrom(System.IO.Path.Combine(path, "ICSharpCode.Core.dll"));
      System.Reflection.Assembly.LoadFrom(System.IO.Path.Combine(path, "ICSharpCode.SharpDevelop.dll"));
      System.Reflection.Assembly.LoadFrom(System.IO.Path.Combine(path, "ICSharpCode.AvalonEdit.dll"));
      System.Reflection.Assembly.LoadFrom(System.IO.Path.Combine(muPath, "FirstFloor.ModernUI.dll"));
      
      foreach (IViewContent view in ICSharpCode.SharpDevelop.SD.Workbench.ViewContentCollection) {
        if (view is EditorControlViewContent) {
          view.WorkbenchWindow.SelectWindow();
          return;
        }
      }
      ICSharpCode.SharpDevelop.SD.Workbench.ShowView(new EditorControlViewContent());
    }
  }
}
