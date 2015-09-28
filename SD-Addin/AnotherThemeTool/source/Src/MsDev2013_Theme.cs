/* oio * 4/5/2014 * Time: 5:46 AM */

using System;
using System.Windows.Media;
namespace ThemeTool
{
  public class MsDev2013_Theme
  {
    static public MsDev2013_Theme Instance = Apply_Blue();
    
    static public MsDev2013_Theme Apply_Blue()
    {
      var theme                                          = new MsDev2013_Theme();
      // Color CommonBlue                                = "4D6082".ToColor();
      // Color DarkBlue                                  = "293955".ToColor();
      // Color CommonActiveTab                           = "4D6082".ToColor();
      // Color CommonActiveTabFocus                      = "FFF29D".ToColor();
      // Color CommonActiveTabHover                      = "5B7199".ToColor();
      // Color CommonActiveTabBorder                     = "8E9BBC".ToColor();
      theme.Name                                         = "blue-default";
      theme.DefaultFontFamily                            = new FontFamily("Open Sans");
      theme.DefaultFontSize                              = 14;
      theme.DotsActive                                   = "00000000".ToColor();
      theme.DotsHover                                    = "00000000".ToColor();
      theme.DotsDefault                                  = "00000000".ToColor();
      theme.GeomBrush0                                   = "2C3D5A".ToColor(); // these three not used
      theme.GeomBrush1                                   = "35496A".ToColor();
      theme.GeomBrush2                                   = "293955".ToColor();
      theme.DefaultBackgroundBrush                       = "293955".ToColor();
      theme.LightForegroundBrush                         = "000000".ToColor();
      theme.DarkForegroundBrush                          = "000000".ToColor();
      theme.ManagedContentTabControlNormalBorderBrush    = "4D6082".ToColor();
      theme.ManagedContentTabItemNormalBackground        = "4D6082".ToColor();
      theme.ManagedContentTabItemNormalForeground        = "4D6082".ToColor();
      theme.ManagedContentTabItemInvNormalBackground     = "4D6082,4D6082:1".ToStops();
      theme.ManagedContentTabItemInvHotBackground        = "4D6082,FF00FF:1".ToStops();
      theme.ManagedContentTabItemHotBackground           = "4D6082,4D6082:1".ToStops();
      theme.ManagedContentTabItemSelectedBackground      = "FFFFFF".ToColor();
      theme.ManagedContentTabItemSelectedForeground      = "000000".ToColor();
      theme.ManagedContentTabItemDisabledBackground      = "4D6082".ToColor();
      theme.ManagedContentTabItemDisabledForeground      = "4D6082".ToColor();
      theme.ManagedContentTabItemSelectedBorderBackround = "FFFFFF".ToColor();
      theme.ManagedContentTabItemNormalBorderBrush       = "4D6082".ToColor();
      theme.ManagedContentTabItemSelectedBorderBrush     = "00000000".ToColor(); // Colors.Transparent;
      theme.ManagedContentTabItemHotBorderBrush          = "FFFFFF".ToColor();
      theme.ManagedContentTabItemDisabledBorderBrush     = "FFFFFF".ToColor();
      theme.DockablePaneTitleBackgroundSelected          = "4D6082,4D6082:1".ToStops();
      theme.DockablePaneTitleBackground                  = "4D6082,4D6082:1".ToStops();
      theme.DockablePaneTitleForeground                  = "FFFFFF".ToColor();
      theme.DockablePaneTitleForegroundSelected          = "000000".ToColor();
      theme.DocumentHeaderBackground                     = "4D6082,4D6082:1".ToStops();
      theme.DocumentHeaderBorderBrushMouseOver           = "00000000".ToColor(); // Colors.Transparent;
      theme.DocumentHeaderForeground                     = "FFFFFF".ToColor();
      theme.DocumentHeaderForegroundSelected             = "FFFFFF".ToColor();
      theme.DocumentHeaderForegroundSelectedActivated    = "000000".ToColor();
      theme.DocumentHeaderBackgroundSelected             = "4D6082,4D6082:1".ToStops();
      theme.DocumentHeaderBackgroundSelectedActivated    = "FFF29D,FFF29D:1".ToStops();
      theme.DocumentHeaderBackgroundMouseOver            = "5B7199,5B7199:1".ToStops();
      theme.PaneHeaderCommandBorderBrush                 = "4D6082,4D6082:1".ToStops();
      theme.PaneHeaderCommandBackground                  = "FFFFFF".ToColor();
      theme.DocumentHeaderBorder                         = "00FF00".ToColor();
      theme.DocumentHeaderBorderSelected                 = "4D6082".ToColor();
      theme.DocumentHeaderBorderSelectedActivated        = "FFF29D".ToColor();
      theme.OverlayWindowMainBorderBrush                 = "4D6082".ToColor();
      theme.OverlayWindowIntBorderBackground             = "4D6082,4D6082:1".ToStops();
      theme.OverlayWindowIntBorderBrush                  = "293955".ToColor();
      theme.OverlayWindowIntBorderBrush2                 = "4D6082".ToColor();
      theme.OverlayWindowIntBorderBackground2            = "4D6082,4D6082:1".ToStops();
      return theme;
    }

    public string Name { get; set; }
    
    public Double? DefaultFontSize { get; set; }
    public FontFamily DefaultFontFamily { get; set; }
    
    public Color? GeomBrush0 { get; set; }
    public Color? GeomBrush1 { get; set; }
    public Color? GeomBrush2 { get; set; }
    
    public Color? DotsDefault { get; set; }
    public Color? DotsActive  { get; set; }
    public Color? DotsHover   { get; set; }
    
    //
    // Managed Content Tab Item
    // ==================================
    public Color? DefaultBackgroundBrush { get; set; }
    public Color? LightForegroundBrush { get; set; }
    public Color? DarkForegroundBrush { get; set; }
    
    public Color? ManagedContentTabControlNormalBorderBrush { get; set; }
    
    //
    // Managed Content Tab Item
    // ==================================
    public Color? ManagedContentTabItemNormalBackground { get; set; }
    public Color? ManagedContentTabItemNormalForeground { get; set; }
    public Color? ManagedContentTabItemNormalBorderBrush { get; set; }
    
    public GradientStopCollection ManagedContentTabItemInvNormalBackground { get; set; }
    public GradientStopCollection ManagedContentTabItemInvHotBackground { get; set; }
    
    public GradientStopCollection ManagedContentTabItemHotBackground { get; set; }
    public Color?                  ManagedContentTabItemHotBorderBrush { get; set; }
    
    public Color? ManagedContentTabItemSelectedBackground { get; set; }
    public Color? ManagedContentTabItemSelectedForeground { get; set; }
    public Color? ManagedContentTabItemSelectedBorderBackround { get; set; }
    public Color? ManagedContentTabItemSelectedBorderBrush { get; set; }
    
    public Color? ManagedContentTabItemDisabledForeground { get; set; }
    public Color? ManagedContentTabItemDisabledBackground { get; set; }
    public Color? ManagedContentTabItemDisabledBorderBrush { get; set; }
    
    //
    // Dockable Pane Title
    // ==================================
    public GradientStopCollection DockablePaneTitleBackgroundSelected { get; set; }
    public GradientStopCollection DockablePaneTitleBackground { get; set; }
    public Color? DockablePaneTitleForeground { get; set; }
    public Color? DockablePaneTitleForegroundSelected { get; set; }
    //
    // Document Header
    // ==================================
    public GradientStopCollection DocumentHeaderBackground { get; set; }
    public GradientStopCollection DocumentHeaderBackgroundSelected { get; set; }
    public GradientStopCollection DocumentHeaderBackgroundSelectedActivated { get; set; }
    public GradientStopCollection DocumentHeaderBackgroundMouseOver { get; set; }
    public Color? DocumentHeaderForeground { get; set; }
    public Color? DocumentHeaderForegroundSelected { get; set; }
    public Color? DocumentHeaderForegroundSelectedActivated { get; set; }
    //
    public Color? DocumentHeaderBorder { get; set; }
    public Color? DocumentHeaderBorderSelected { get; set; }
    public Color? DocumentHeaderBorderSelectedActivated { get; set; }
    public Color? DocumentHeaderBorderBrushMouseOver { get; set; }
    //
    // Pane Header
    // ==================================
    public GradientStopCollection PaneHeaderCommandBorderBrush { get; set; }
    public Color? PaneHeaderCommandBackground { get; set; }
    
    public Color? OverlayWindowMainBorderBrush { get; set; }
    public GradientStopCollection OverlayWindowIntBorderBackground { get; set; }
    public Color? OverlayWindowIntBorderBrush { get; set; }
    public Color? OverlayWindowIntBorderBrush2 { get; set; }
    public GradientStopCollection OverlayWindowIntBorderBackground2 { get; set; }	}
}



