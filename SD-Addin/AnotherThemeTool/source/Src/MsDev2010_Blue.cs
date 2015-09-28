/* oio * 4/5/2014 * Time: 5:46 AM */
using System;
using System.Windows.Media;
namespace ThemeTool
{
  /// <summary>
  /// This is the first implementation of colours for the 2013-blue theme.
  /// It is specifically here as reference.
  /// </summary>
  static public class MsDev2010_Blue
  {
    readonly static Color common0 = "3D5277".ToColor();
    readonly static Color CommonWhite = Colors.White;
    readonly static Color CommonBlack = Colors.Black;
    
    static public Color FloatingWindowBorder { get { return "35496A".ToColor(); } }
    static public Color GeomBrush0 { get { return "2C3D5A".ToColor(); } }
    static public Color GeomBrush1 { get { return FloatingWindowBorder; } }
    static public Color GeomBrush2 { get { return "293955".ToColor(); } }
    
    static public GradientStopCollection Stops_ManagedContentTabItemInvNormalBackground = new GradientStopCollection() {
      new GradientStop(Colors.White, 0),
      new GradientStop("FFECEBE6".ToColor(), 1)
    };
    // 
    // ManagedContentTabItem
    // =====================
    // 
    // ManagedContentTabItem (Hot) Gradient
    // ------------------------------------
    static readonly Color _gradStop0 = "50FFE8A6".ToColor(); 
    static readonly Color _gradStop1 = "50FFEDBA".ToColor();
    static readonly Color _gradStop2 = "50FFFCF2".ToColor();
    
    readonly static public GradientStopCollection Stops_ManagedContentTabItemHotBackground = new GradientStopCollection() {
      new GradientStop(_gradStop0, 0),
      new GradientStop(_gradStop0, 0.5),
      new GradientStop(_gradStop1, 0.5),
      new GradientStop(_gradStop2, 1)
    };
    readonly static public GradientStopCollection Stops_ManagedContentTabItemInvHotBackground = new GradientStopCollection() {
      new GradientStop(_gradStop2, 0),
      new GradientStop(_gradStop1, 0.5),
      new GradientStop(_gradStop0, 0.5),
      new GradientStop(_gradStop0, 1)
    };
    // 
    // ManagedContentTabItem (Hot) Gradient
    // ------------------------------------
    static public Color ManagedContentTabItemSelectedBackground { get { return Colors.White; } }
    static public Color ManagedContentTabItemDisabledBackground { get { return "FFF5F4EA".ToColor(); } }
    static public Color ManagedContentTabItemSelectedBorderBackround { get { return Colors.White; } }

    static readonly Color _gsDocH0 = "FFFCF2".ToColor(); // FFFCF2,FFEDBA,FFE8A6,FFE8A6
    static readonly Color _gsDocH1 = "FFEDBA".ToColor();
    static readonly Color _gsDocH2 = "FFE8A6".ToColor();
    /// <summary>FFE8A6</summary>
    static public Color CommonBorder1 { get { return _gsDocHa2; } }
    
    static readonly Color _gsDocHa0 = "FBFCFC".ToColor();
    static readonly Color _gsDocHa1 = "D7DCE4".ToColor();
    static readonly Color _gsDocHa2 = "CED4DF".ToColor();
    /// <summary>CED4DF</summary>
    static public Color CommonBorder2 { get { return _gsDocH2; } }
    
    readonly static public GradientStopCollection Stops_DocumentHeaderBackgroundSelected = new GradientStopCollection() {
      new GradientStop("FFFCF2".ToColor(), 0),
      new GradientStop("FFEDBA".ToColor(), 0.5),
      new GradientStop("FFE8A6".ToColor(), 0.5),
      new GradientStop("FFE8A6".ToColor(), 1)
    };
    readonly static public GradientStopCollection Stops_DocumentHeaderBackgroundSelectedActivated = new GradientStopCollection() {
      new GradientStop(_gsDocH0, 0),
      new GradientStop(_gsDocH1, 0.5),
      new GradientStop(_gsDocH2, 0.5),
      new GradientStop(_gsDocH2, 1)
    };
    static public GradientStopCollection Stops_DocumentHeaderBackgroundMouseOver = new GradientStopCollection() {
      new GradientStop("50FFE8A6".ToColor(), 0), // "50FFE8A6,50FFE8A6:0.5,50FFEDBA:0.5,50FFFCF2:1"
      new GradientStop("50FFE8A6".ToColor(), 0.5),
      new GradientStop("50FFEDBA".ToColor(), 0.5),
      new GradientStop("50FFFCF2".ToColor(), 1)
    };
    //, 0x
    static public GradientStopCollection Stops_OverlayWindowIntBorderBackground = new GradientStopCollection() {
      new GradientStop("F8FAFC".ToColor(), 0), // "F8FAFC,E8EBF0:1"
      new GradientStop("E8EBF0".ToColor(), 1)
    };
    static public Color OverlayWindowMainBorderBrush { get { return "636871".ToColor(); } }
    //7C8AA1
    // OverlayWindowIntBorderBrush2
    static public Color OverlayWindowIntBorderBrush2 { get { return "7C8AA1".ToColor(); } }
    //, 0x
    static public GradientStopCollection Stops_OverlayWindowIntBorderBackground2 = new GradientStopCollection() {
      new GradientStop("FEEEC0".ToColor(), 0), // "FEEEC0,F9D79C:1"
      new GradientStop("F9D79C".ToColor(), 1)
    };

    static public GradientStopCollection Stops_PaneHeaderCommandBorderBrush { get { return Stops_DocumentHeaderBackgroundMouseOver; } }
    // 0x3D5277
    static public Color DocumentHeaderBorder { get { return common0; } }
    //
    static public Color ColorBlack { get { return Colors.Black; } }
    static public Color ColorBlue { get { return Color.FromRgb(0x4D, 0x60, 0x82); } }
    static public Color ColorWindowBackground { get { return Color.FromRgb(0x29, 0x39, 0x55); } }
    static public Color ColorDefaultBackground { get { return Color.FromRgb(0x29, 0x39, 0x55); } }
    static public Color ColorBlueSpecial { get { return Color.FromRgb(0x4D, 0x60, 0x82); } }
    static public Color ColorTabActive { get { return Color.FromRgb(0x4d, 0x60, 0x82); } }
    static public Color ColorTabActiveFocus { get { return Color.FromRgb(0xff, 0xf2, 0x9d); } }
    static public Color ColorTabHover { get { return Color.FromRgb(0x5b, 0x71, 0x99); } }
    static public Color ColorTabBorder { get { return Color.FromRgb(0x8e, 0x9b, 0xbc); } }
  }
}



