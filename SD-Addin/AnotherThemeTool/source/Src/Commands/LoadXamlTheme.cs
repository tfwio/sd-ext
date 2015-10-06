using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using ICSharpCode.Core;
using ThemeTool;
namespace ThemeTool.Commands
{
  public class LoadXamlTheme : AbstractMenuCommand
  {
    public override void Run()
    {
      String xamlFile = null;
      
      using (var writer = new System.IO.StringWriter()) {
        using (var ofd = new System.Windows.Forms.OpenFileDialog() {
                 Filter = "XAML File|*.xaml"
               }) {
          if (ofd.ShowDialog() != DialogResult.OK)
            return;
          xamlFile = ofd.FileName;
        }
      }
      var xamlStr = System.IO.File.ReadAllText(xamlFile);
      var pc = new ParserContext();
      //
      pc.XamlTypeMapper = new XamlTypeMapper(new string[] {  });
      //
      pc.XamlTypeMapper.AddMappingProcessingInstruction("ad", "AvalonDock", "AvalonDock");
      pc.XamlTypeMapper.AddMappingProcessingInstruction("adRes", "AvalonDock.Properties", "AvalonDock");
      pc.XamlTypeMapper.AddMappingProcessingInstruction("sys", "System", "mscorlib");
      pc.XamlTypeMapper.AddMappingProcessingInstruction("th", "ThemeTool","AnotherThemeTool");
      //
      pc.XmlnsDictionary.Add("ad", "ad");
      pc.XmlnsDictionary.Add("adRes", "adRes");
      pc.XmlnsDictionary.Add("sys", "sys");
      pc.XmlnsDictionary.Add("th", "th");
      Assembly.LoadWithPartialName("AnotherThemeTool");
//      pc.BaseUri = new Uri(@"clr-namespace:AnotherThemeTool",UriKind.RelativeOrAbsolute);
      var rd = (ResourceDictionary)XamlReader.Parse(xamlStr);
      //
      AvalonDock.ThemeFactory.ResetTheme();
//      System.Windows.Application.Current.Resources.MergedDictionaries.Add(
//        new ResourceDictionary{Source=new Uri(@"/AvalonDock;component/themes/generic.xaml",UriKind.RelativeOrAbsolute)}
//       );
      System.Windows.Application.Current.Resources.MergedDictionaries.Add(rd);
    }
  }
}




