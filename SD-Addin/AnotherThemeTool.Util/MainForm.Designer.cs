/*
 * Created by SharpDevelop.
 * User: tfwxo
 * Date: 9/26/2015
 * Time: 12:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Xml;
namespace TestThemeWriter
{
  partial class MainForm
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button btnGetThemeSetting;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RichTextBox textBox2;
    private System.Windows.Forms.Button btnGetThemeData;
    private System.Windows.Forms.Button btnClassData;
    private System.Windows.Forms.Button btnClassString;
    private System.Windows.Forms.Button btnGetDemoSetting;
    
    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    
    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnGetThemeSetting = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBox2 = new System.Windows.Forms.RichTextBox();
      this.btnGetThemeData = new System.Windows.Forms.Button();
      this.btnClassData = new System.Windows.Forms.Button();
      this.btnClassString = new System.Windows.Forms.Button();
      this.btnGetDemoSetting = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnGetThemeSetting
      // 
      this.btnGetThemeSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGetThemeSetting.Location = new System.Drawing.Point(673, 58);
      this.btnGetThemeSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnGetThemeSetting.Name = "btnGetThemeSetting";
      this.btnGetThemeSetting.Size = new System.Drawing.Size(108, 37);
      this.btnGetThemeSetting.TabIndex = 1;
      this.btnGetThemeSetting.Text = "ToString";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
      | System.Windows.Forms.AnchorStyles.Left) 
      | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Location = new System.Drawing.Point(12, 102);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(769, 489);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "groupBox1";
      // 
      // textBox2
      // 
      this.textBox2.AcceptsTab = true;
      this.textBox2.AutoWordSelection = true;
      this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox2.Font = new System.Drawing.Font("FreeMono", 12F);
      this.textBox2.Location = new System.Drawing.Point(3, 22);
      this.textBox2.Name = "textBox2";
      this.textBox2.ShowSelectionMargin = true;
      this.textBox2.Size = new System.Drawing.Size(763, 464);
      this.textBox2.TabIndex = 1;
      this.textBox2.Text = "";
      this.textBox2.WordWrap = false;
      // 
      // btnGetThemeData
      // 
      this.btnGetThemeData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGetThemeData.Location = new System.Drawing.Point(673, 13);
      this.btnGetThemeData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnGetThemeData.Name = "btnGetThemeData";
      this.btnGetThemeData.Size = new System.Drawing.Size(108, 37);
      this.btnGetThemeData.TabIndex = 1;
      this.btnGetThemeData.Text = "ToData";
      // 
      // btnClassData
      // 
      this.btnClassData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClassData.Location = new System.Drawing.Point(559, 13);
      this.btnClassData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnClassData.Name = "btnClassData";
      this.btnClassData.Size = new System.Drawing.Size(108, 37);
      this.btnClassData.TabIndex = 1;
      this.btnClassData.Text = "ClassData";
      // 
      // btnClassString
      // 
      this.btnClassString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClassString.Location = new System.Drawing.Point(559, 58);
      this.btnClassString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnClassString.Name = "btnClassString";
      this.btnClassString.Size = new System.Drawing.Size(108, 37);
      this.btnClassString.TabIndex = 1;
      this.btnClassString.Text = "ClassString";
      // 
      // btnGetDemoSetting
      // 
      this.btnGetDemoSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGetDemoSetting.Location = new System.Drawing.Point(445, 13);
      this.btnGetDemoSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnGetDemoSetting.Name = "btnGetDemoSetting";
      this.btnGetDemoSetting.Size = new System.Drawing.Size(108, 37);
      this.btnGetDemoSetting.TabIndex = 1;
      this.btnGetDemoSetting.Text = "Syntax";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(793, 603);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnGetThemeData);
      this.Controls.Add(this.btnClassString);
      this.Controls.Add(this.btnGetDemoSetting);
      this.Controls.Add(this.btnClassData);
      this.Controls.Add(this.btnGetThemeSetting);
      this.Font = new System.Drawing.Font("Open Sans", 10F);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "MainForm";
      this.Text = "TestThemeWriter";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);

    }
  }
}
