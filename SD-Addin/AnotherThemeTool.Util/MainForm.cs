/*
 * Created by SharpDevelop.
 * User: tfwxo
 * Date: 9/26/2015
 * Time: 12:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThemeTool;

namespace TestThemeWriter
{
  /// <summary>
  /// Description of MainForm.
  /// </summary>
  public partial class MainForm : Form
  {
    //void button1_Click(object sender, EventArgs e)
    //{
    //  // var deserializer = new Deserializer();
    //  var serializer = new YamlDotNet.Serialization.Serializer();
    //  using (var writer = new System.IO.StringWriter())
    //  {
    //    using (var sfd=new System.Windows.Forms.SaveFileDialog(){Filter="YAML File|*.yml"})
    //    {
    //      var themeSettings = new MsDev2013SettingsCollection(){
    //        Theme=new System.Collections.Generic.List<MsDev2013Settings>{
    //          {MsDev2013Settings.FromTheme(MsDev2013_Theme.Apply_Blue())}
    //        }
    //      };
    //      serializer.Serialize(writer,themeSettings,typeof(MsDev2013SettingsCollection));
    //      var stringdata = writer.ToString();
    //      if (sfd.ShowDialog()!=System.Windows.Forms.DialogResult.OK) return;
    //      System.IO.File.WriteAllText(sfd.FileName,stringdata);
    //    }
    //  }
    //  //namingConvention: new CamelCaseNamingConvention()
    //  //      var nodes = new List<FaNode>();
    //  //      IconSection precept = deserializer.Deserialize<IconSection>(Document);
    //}
    
    
    void GetThemeString(object sender, EventArgs args) { textBox2.Text = ThemeGen.Execute(ExecuteMode.ThemeToString); }
    void GetThemeData(object sender, EventArgs args) { textBox2.Text = ThemeGen.Execute(ExecuteMode.StringToTheme); }
    
    void GetThemeClassData(object sender, EventArgs args) { textBox2.Text = ThemeGen.Execute(ExecuteMode.ClassData); }
    void GetThemeClassString(object sender, EventArgs args) { textBox2.Text = ThemeGen.Execute(ExecuteMode.ClassString); }
    
    void GetDemoFile(object o, EventArgs e)
    {
      //      var ok=SFD.ShowDialog()==DialogResult.OK;
      //      if (!ok) return;
      var ts = new ThemeSetting();
      ts.ThemeName = "acceptable-setting-types";
      ts.Elements = new List<ColourSetting>{
        new ColourSetting{ Name="SampleString",TypeName="String", DefaultValue="I'm a sample string" },
        new ColourSetting{ Name="SampleDouble",TypeName="Double", DefaultValue="0.00000" },
        new ColourSetting{ Name="SampleGradientStop",TypeName="LinearGradientStop", DefaultValue="#000000:0,#FFFFFF:1" },
        new ColourSetting{ Name="SampleColor",TypeName="Color", DefaultValue="#000000" },
        new ColourSetting{ Name="SampleFontFamily",TypeName="FontFamily", DefaultValue="Open Sans" },
      };
      //      var fi=new System.IO.FileInfo(SFD.FileName);
      textBox2.Text = ThemeSetting.Save(ts);

    }
    public MainForm()
    {
      InitializeComponent();
      
      btnGetThemeSetting.Click += GetThemeString;
      btnGetThemeData.Click    += GetThemeData;
      
      btnClassData.Click       += GetThemeClassData;
      btnClassString.Click     += GetThemeClassString;
      
      btnGetDemoSetting.Click  += GetDemoFile;
      
      
      
      this.Invalidate();
      //this.textBox1.ApplyDragDropMethod(
      //  (sender,e)=>{
      //    if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
      //  },
      //  (sender,e)=>{
      //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
      //    {
      //      var strFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
      //      var file = new FileInfo(strFiles[0]);
      //      strFiles = null;
      //      Gogo(file);
      //    }
      //  });
    }
  }
}
