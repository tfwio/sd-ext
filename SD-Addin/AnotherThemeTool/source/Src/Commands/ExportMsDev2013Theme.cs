/*
 * Created by SharpDevelop.
 * User: oio
 * Date: 11/20/2012
 * Time: 2:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using ICSharpCode.Core;
using ICSharpCode.SharpDevelop.Workbench;
using ThemeTool.View;
namespace ThemeTool.Commands
{
  public class ExportMsDev2013Theme : AbstractMenuCommand
  {
    public override void Run()
    {
      // var deserializer = new Deserializer();
      var serializer = new YamlDotNet.Serialization.Serializer();
      using (var writer = new System.IO.StringWriter()) {
        using (var sfd = new System.Windows.Forms.SaveFileDialog() {
                 Filter = "YAML File|*.yml"
               }) {
          var themeSettings = new MsDev2013SettingsCollection() {
            Theme = new System.Collections.Generic.List<MsDev2013Settings> {
              {
                MsDev2013Settings.FromTheme(MsDev2013_Theme.Instance)
              }
            }
          };
          serializer.Serialize(writer, themeSettings, typeof(MsDev2013SettingsCollection));
          var stringdata = writer.ToString();
          if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            return;
          System.IO.File.WriteAllText(sfd.FileName, stringdata);
        }
      }
      serializer = null;
    }
  }
}


