/* oio * 4/5/2014 * Time: 5:46 AM */
using System;
using System.Windows.Media;
namespace ThemeTool
{
  public class MsDev2010_Theme
  {
    static public MsDev2010_Theme Instance = Apply_Blue();
    static public MsDev2010_Theme Apply_Blue()
    {
      //"3D5277".ToColor
      var theme = new MsDev2010_Theme();
      theme.GeomBrush0                                   = "2C3D5A".ToColor();
      theme.GeomBrush1                                   = "35496A".ToColor();
      theme.GeomBrush2                                   = "293955".ToColor();
      theme.ManagedContentTabControlNormalBorderBrush    = Colors.Transparent;
      theme.DefaultBackgroundBrush                       = Colors.Transparent;
      theme.LightForegroundBrush                         = Colors.White;
      theme.DarkForegroundBrush                          = Colors.Black;
      theme.ManagedContentTabItemNormalBackground        = Colors.Transparent;
      theme.ManagedContentTabItemInvNormalBackground     = "FFFFFF,FFECEBE6:1".ToStops();
      theme.ManagedContentTabItemHotBackground           = "50FFE8A6,50FFE8A6:0.5,50FFEDBA:0.05,50FFFCF2:1".ToStops();//MsDev2010_Blue.Stops_ManagedContentTabItemHotBackground;
      theme.ManagedContentTabItemSelectedBackground      = Colors.White;
      theme.ManagedContentTabItemDisabledBackground      = "FFF5F4EA".ToColor();
      theme.ManagedContentTabItemSelectedBorderBackround = Colors.White;
      theme.ManagedContentTabItemNormalBorderBrush       = Colors.Transparent;
      theme.ManagedContentTabItemSelectedBorderBrush     = Colors.White;
      theme.ManagedContentTabItemHotBorderBrush          = Colors.White;
      theme.ManagedContentTabItemDisabledBorderBrush     = Colors.White;
      theme.DockablePaneTitleBackgroundSelected          = "FFFCF2,FFEDBA:0.5,FFEAA6:0.5,FFEAA6:1".ToStops();
      theme.DockablePaneTitleBackground                  = "4D6082,3D5277:1".ToStops();
      theme.DockablePaneTitleForeground                  = Colors.White;
      theme.DockablePaneTitleForegroundSelected          = Colors.Black;
      theme.DocumentHeaderBackground                     = "4D6082,3D5277:1".ToStops();
      theme.DocumentHeaderBorderBrushMouseOver           = Colors.White;
      theme.DocumentHeaderForeground                     = Colors.White;
      theme.DocumentHeaderForegroundSelected             = Colors.Black;
      theme.DocumentHeaderForegroundSelectedActivated    = Colors.Black;
      theme.DocumentHeaderBackgroundSelected             = "FFFCF2,FFEDBA:0.5,FFE8A6:0.5,FFE8A6:1".ToStops();
      theme.DocumentHeaderBackgroundSelectedActivated    = "FFFCF2,FFEDBA:0.5,FFE8A6:0.5,FFE8A6:1".ToStops();
      theme.DocumentHeaderBackgroundMouseOver            = "50FFE8A6,50FFE8A6:0.5,50FFEDBA:0.5,50FFFCF2:1".ToStops();//MsDev2010_Blue.Stops_DocumentHeaderBackgroundMouseOver;
      theme.PaneHeaderCommandBorderBrush                 = "50FFE8A6,50FFE8A6:0.5,50FFEDBA:0.5,50FFFCF2:1".ToStops(); //MsDev2010_Blue.Stops_PaneHeaderCommandBorderBrush;
      theme.PaneHeaderCommandBackground                  = Colors.White;
      theme.DocumentHeaderBorder                         = "3D5277".ToColor(); //MsDev2010_Blue.DocumentHeaderBorder;
      theme.DocumentHeaderBorderSelected                 = "CED4DF".ToColor(); //MsDev2010_Blue.CommonBorder1;
      theme.DocumentHeaderBorderSelectedActivated        = "FFE8A6".ToColor(); //MsDev2010_Blue.CommonBorder2;
      theme.OverlayWindowMainBorderBrush                 = "636871".ToColor(); // MsDev2010_Blue.OverlayWindowMainBorderBrush;
      theme.OverlayWindowIntBorderBackground             = "F8FAFC,E8EBF0:1".ToStops(); // MsDev2010_Blue.Stops_OverlayWindowIntBorderBackground;
      theme.OverlayWindowIntBorderBrush2                 = "7C8AA1".ToColor(); // MsDev2010_Blue.OverlayWindowIntBorderBrush2;
      theme.OverlayWindowIntBorderBackground2            = "FEEEC0,F9D79C:1".ToStops(); // MsDev2010_Blue.Stops_OverlayWindowIntBorderBackground2;
      return theme;
    }
    // 
    public string                 Name                                          { get; set; }
    public Double                 DefaultFontSize                               { get; set; }
    public FontFamily             DefaultFontFamily                             { get; set; }
    public Color                  DotsDefault                                   { get; set; }
    public Color                  DotsActive                                    { get; set; }
    public Color                  DotsHover                                     { get; set; }
    public Color                  GeomBrush0                                    { get; set; }
    public Color                  GeomBrush1                                    { get; set; }
    public Color                  GeomBrush2                                    { get; set; }
    public Color                  DefaultBackgroundBrush                        { get; set; }
    public Color                  LightForegroundBrush                          { get; set; }
    public Color                  DarkForegroundBrush                           { get; set; }
    public Color                  ManagedContentTabControlNormalBorderBrush     { get; set; }
    public Color                  ManagedContentTabItemNormalBackground         { get; set; }
    public Color                  ManagedContentTabItemNormalForeground         { get; set; }
    public Color                  ManagedContentTabItemNormalBorderBrush        { get; set; }
    public GradientStopCollection ManagedContentTabItemInvNormalBackground      { get; set; }
    public GradientStopCollection ManagedContentTabItemInvHotBackground         { get; set; }
    public GradientStopCollection ManagedContentTabItemHotBackground            { get; set; }
    public Color                  ManagedContentTabItemHotBorderBrush           { get; set; }
    public Color                  ManagedContentTabItemSelectedBackground       { get; set; }
    public Color                  ManagedContentTabItemSelectedForeground       { get; set; }
    public Color                  ManagedContentTabItemSelectedBorderBackround  { get; set; }
    public Color                  ManagedContentTabItemSelectedBorderBrush      { get; set; }
    public Color                  ManagedContentTabItemDisabledForeground       { get; set; }
    public Color                  ManagedContentTabItemDisabledBackground       { get; set; }
    public Color                  ManagedContentTabItemDisabledBorderBrush      { get; set; }
    public GradientStopCollection DockablePaneTitleBackgroundSelected           { get; set; }
    public GradientStopCollection DockablePaneTitleBackground                   { get; set; }
    public Color                  DockablePaneTitleForeground                   { get; set; }
    public Color                  DockablePaneTitleForegroundSelected           { get; set; }
    public GradientStopCollection DocumentHeaderBackground                      { get; set; }
    public GradientStopCollection DocumentHeaderBackgroundSelected              { get; set; }
    public GradientStopCollection DocumentHeaderBackgroundSelectedActivated     { get; set; }
    public GradientStopCollection DocumentHeaderBackgroundMouseOver             { get; set; }
    public Color                  DocumentHeaderForeground                      { get; set; }
    public Color                  DocumentHeaderForegroundSelected              { get; set; }
    public Color                  DocumentHeaderForegroundSelectedActivated     { get; set; }
    public Color                  DocumentHeaderBorder                          { get; set; }
    public Color                  DocumentHeaderBorderSelected                  { get; set; }
    public Color                  DocumentHeaderBorderSelectedActivated         { get; set; }
    public Color                  DocumentHeaderBorderBrushMouseOver            { get; set; }
    public GradientStopCollection PaneHeaderCommandBorderBrush                  { get; set; }
    public Color                  PaneHeaderCommandBackground                   { get; set; }
    public Color                  OverlayWindowMainBorderBrush                  { get; set; }
    public GradientStopCollection OverlayWindowIntBorderBackground              { get; set; }
    public Color                  OverlayWindowIntBorderBrush                   { get; set; }
    public Color                  OverlayWindowIntBorderBrush2                  { get; set; }
    public GradientStopCollection OverlayWindowIntBorderBackground2             { get; set; }



  }
}



