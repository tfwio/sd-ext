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
    void button1_Click(object sender, EventArgs e)
    {
      ThemeTool.poop.Poop();
    }
    readonly SaveFileDialog SFD = new SaveFileDialog{Filter="YAML File|*.yml"};
    
    Func<ColourSetting,string> NodeToClassSetting  = (node) => string.Format("      public {1,-22} {0,-45} {{ get; set; }}", node.Name, node.TypeName);
    Func<ColourSetting,string> NodeToClassTheme    = (node) => string.Format("      public string {0,-45} {{ get; set; }}", node.Name, node.TypeName);
    Func<ColourSetting,string> NodeToString = (node) =>
    {
      switch (node.TypeName.ToLower()) {
          case "string":     return (string.Format("settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45});", node.Name));
          case "double":     return (string.Format("settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45}).ToString();", node.Name));
          case "fontfamily": return (string.Format("settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45}).ToString();", node.Name));
          case "color":      return (string.Format("settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45}).ToHexString(true);", node.Name));
          case "gradientstopcollection": return (string.Format("settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45}).ToGradientStopString();", node.Name));
          default: return null;
      }
    };
    Func<ColourSetting,string> StringToNode = (node) =>
    {
      switch (node.TypeName.ToLower()) {
          case "string": return (string.Format("settings.{0} = (theme.{0} ?? tefaut.{0});", node.Name));
          case "fontfamily": return (string.Format("settings.{0} = new FontFamily((theme.{0} ?? tefaut.{0}).ToString());", node.Name));
          case "double": return (string.Format("settings.{0} = double.Parse(theme.{0} ?? tefaut.{0});", node.Name));
          case "color": return (string.Format("settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45}).ToColor();", node.Name));
          case "gradientstopcollection": return (string.Format("settings.{0,-45} = (theme.{0,-45} ?? tefaut.{0,-45}).ToStops();", node.Name));
          default: return null;
      }
    };
    
    enum ExecuteMode { ThemeToString, StringToTheme, ClassData, ClassString, }
    void Execute(ExecuteMode mode)
    {
      ThemeSetting setting = ThemeTool.ThemeSetting.Load(StringRes.MsDev2013_Theme);
      using (var strw = new System.IO.StringWriter())
      {
        foreach (var node in setting.Elements)
        {
          string result = null;
          switch (mode) {
              case ExecuteMode.ThemeToString: result = NodeToString(node); break;
              case ExecuteMode.StringToTheme: result = StringToNode(node); break;
              case ExecuteMode.ClassString: result = NodeToClassTheme(node); break;
              case ExecuteMode.ClassData: result = NodeToClassSetting(node); break;
          }
          if (!string.IsNullOrEmpty(result)) strw.WriteLine(result);
        }
        textBox2.Text = strw.ToString();
      }
    }
    
    void GetThemeString(object sender, EventArgs args) { Execute(ExecuteMode.ThemeToString); }
    void GetThemeData(object sender, EventArgs args) { Execute(ExecuteMode.StringToTheme); }
    
    void GetThemeClassData(object sender, EventArgs args) { Execute(ExecuteMode.ClassData); }
    void GetThemeClassString(object sender, EventArgs args) { Execute(ExecuteMode.ClassString); }
    
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
