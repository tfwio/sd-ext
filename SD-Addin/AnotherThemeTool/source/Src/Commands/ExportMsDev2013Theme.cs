using System;
using System.Windows.Forms;
using ICSharpCode.Core;
namespace ThemeTool.Commands
{
  public class ExportMsDev2013Theme : AbstractMenuCommand
  {
    public override void Run()
    {
      var serializer = new YamlDotNet.Serialization.Serializer();
      using (var writer = new System.IO.StringWriter())
      {
        using (var sfd = new System.Windows.Forms.SaveFileDialog() { Filter = "YAML File|*.yml" })
        {
          var themeSettings = new MsDev2013SettingsCollection()
          {
            Theme =new System.Collections.Generic.List<MsDev2013Settings>
            { { MsDev2013_Theme.Instance.ToSetting() } }
          };
          
          serializer.Serialize(writer, themeSettings, typeof(MsDev2013SettingsCollection));
          var stringdata = writer.ToString();
          
          if (sfd.ShowDialog() != DialogResult.OK) return;
          
          System.IO.File.WriteAllText(sfd.FileName, stringdata);
        }
      }
      serializer = null;
    }
  }
}


