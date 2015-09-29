using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThemeTool;

namespace TestThemeWriter
{
  /// <summary>Description of MainForm.</summary>
  public partial class MainForm : Form
  {
    const string filen = "../../../AnotherThemeTool/artifacts/MsDev2013Theme.yaml";
    readonly string filed = System.IO.File.ReadAllText(filen);
    
    void GetThemeString(object sender, EventArgs args)
    {
      textBox2.Text = ThemeGen.Execute(ExecuteMode.ThemeToString, filed);
    }
    void GetThemeData(object sender, EventArgs args)
    {
      textBox2.Text = ThemeGen.Execute(ExecuteMode.StringToTheme, filed);
    }
    void GetThemeClassData(object sender, EventArgs args)
    {
      textBox2.Text = ThemeGen.Execute(ExecuteMode.ClassData, filed);
    }
    void GetThemeClassString(object sender, EventArgs args)
    {
      textBox2.Text = ThemeGen.Execute(ExecuteMode.ClassString, filed);
    }
    
    void GetDemoFile(object o, EventArgs e)
    {
      //      var ok=SFD.ShowDialog()==DialogResult.OK;
      //      if (!ok) return;
      var ts = new ThemeSetting();
      ts.ThemeName = "acceptable-setting-types";
      ts.ResourceName = "actualThemeID";
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
