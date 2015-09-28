/* oio * 4/5/2014 * Time: 5:46 AM */
using System;
using System.Windows.Media;
namespace ThemeTool
{
  public class MsDev2013SettingsCollection
  {
    [YamlDotNet.Serialization.YamlAliasAttribute("Theme")]
    public System.Collections.Generic.List<MsDev2013Settings> Theme { get; set; }
  }
  public class MsDev2013Settings
  {
    public string Name                                          { get; set; }
    public string DefaultFontSize                               { get; set; }
    public string DefaultFontFamily                             { get; set; }
    public string DotsDefault                                   { get; set; }
    public string DotsActive                                    { get; set; }
    public string DotsHover                                     { get; set; }
    public string GeomBrush0                                    { get; set; }
    public string GeomBrush1                                    { get; set; }
    public string GeomBrush2                                    { get; set; }
    public string DefaultBackgroundBrush                        { get; set; }
    public string LightForegroundBrush                          { get; set; }
    public string DarkForegroundBrush                           { get; set; }
    public string ManagedContentTabControlNormalBorderBrush     { get; set; }
    public string ManagedContentTabItemNormalBackground         { get; set; }
    public string ManagedContentTabItemNormalForeground         { get; set; }
    public string ManagedContentTabItemNormalBorderBrush        { get; set; }
    public string ManagedContentTabItemInvNormalBackground      { get; set; }
    public string ManagedContentTabItemInvHotBackground         { get; set; }
    public string ManagedContentTabItemHotBackground            { get; set; }
    public string ManagedContentTabItemHotBorderBrush           { get; set; }
    public string ManagedContentTabItemSelectedBackground       { get; set; }
    public string ManagedContentTabItemSelectedForeground       { get; set; }
    public string ManagedContentTabItemSelectedBorderBackround  { get; set; }
    public string ManagedContentTabItemSelectedBorderBrush      { get; set; }
    public string ManagedContentTabItemDisabledForeground       { get; set; }
    public string ManagedContentTabItemDisabledBackground       { get; set; }
    public string ManagedContentTabItemDisabledBorderBrush      { get; set; }
    public string DockablePaneTitleBackgroundSelected           { get; set; }
    public string DockablePaneTitleBackground                   { get; set; }
    public string DockablePaneTitleForeground                   { get; set; }
    public string DockablePaneTitleForegroundSelected           { get; set; }
    public string DocumentHeaderBackground                      { get; set; }
    public string DocumentHeaderBackgroundSelected              { get; set; }
    public string DocumentHeaderBackgroundSelectedActivated     { get; set; }
    public string DocumentHeaderBackgroundMouseOver             { get; set; }
    public string DocumentHeaderForeground                      { get; set; }
    public string DocumentHeaderForegroundSelected              { get; set; }
    public string DocumentHeaderForegroundSelectedActivated     { get; set; }
    public string DocumentHeaderBorder                          { get; set; }
    public string DocumentHeaderBorderSelected                  { get; set; }
    public string DocumentHeaderBorderSelectedActivated         { get; set; }
    public string DocumentHeaderBorderBrushMouseOver            { get; set; }
    public string PaneHeaderCommandBorderBrush                  { get; set; }
    public string PaneHeaderCommandBackground                   { get; set; }
    public string OverlayWindowMainBorderBrush                  { get; set; }
    public string OverlayWindowIntBorderBackground              { get; set; }
    public string OverlayWindowIntBorderBrush                   { get; set; }
    public string OverlayWindowIntBorderBrush2                  { get; set; }
    public string OverlayWindowIntBorderBackground2             { get; set; }

    static public MsDev2013Settings FromTheme(MsDev2013_Theme theme)
    {
      var tefaut = MsDev2013_Theme.Apply();
      var settings = new MsDev2013Settings();
      settings.Name                                          = (theme.Name                                          ?? tefaut.Name                                         );
      settings.DefaultFontSize                               = (theme.DefaultFontSize                               ?? tefaut.DefaultFontSize                              ).ToString();
      settings.DefaultFontFamily                             = (theme.DefaultFontFamily                             ?? tefaut.DefaultFontFamily                            ).ToString();
      settings.DotsDefault                                   = (theme.DotsDefault                                   ?? tefaut.DotsDefault                                  ).ToHexString(true);
      settings.DotsActive                                    = (theme.DotsActive                                    ?? tefaut.DotsActive                                   ).ToHexString(true);
      settings.DotsHover                                     = (theme.DotsHover                                     ?? tefaut.DotsHover                                    ).ToHexString(true);
      settings.GeomBrush0                                    = (theme.GeomBrush0                                    ?? tefaut.GeomBrush0                                   ).ToHexString(true);
      settings.GeomBrush1                                    = (theme.GeomBrush1                                    ?? tefaut.GeomBrush1                                   ).ToHexString(true);
      settings.GeomBrush2                                    = (theme.GeomBrush2                                    ?? tefaut.GeomBrush2                                   ).ToHexString(true);
      settings.DefaultBackgroundBrush                        = (theme.DefaultBackgroundBrush                        ?? tefaut.DefaultBackgroundBrush                       ).ToHexString(true);
      settings.LightForegroundBrush                          = (theme.LightForegroundBrush                          ?? tefaut.LightForegroundBrush                         ).ToHexString(true);
      settings.DarkForegroundBrush                           = (theme.DarkForegroundBrush                           ?? tefaut.DarkForegroundBrush                          ).ToHexString(true);
      settings.ManagedContentTabControlNormalBorderBrush     = (theme.ManagedContentTabControlNormalBorderBrush     ?? tefaut.ManagedContentTabControlNormalBorderBrush    ).ToHexString(true);
      settings.ManagedContentTabItemNormalBackground         = (theme.ManagedContentTabItemNormalBackground         ?? tefaut.ManagedContentTabItemNormalBackground        ).ToHexString(true);
      settings.ManagedContentTabItemNormalForeground         = (theme.ManagedContentTabItemNormalForeground         ?? tefaut.ManagedContentTabItemNormalForeground        ).ToHexString(true);
      settings.ManagedContentTabItemNormalBorderBrush        = (theme.ManagedContentTabItemNormalBorderBrush        ?? tefaut.ManagedContentTabItemNormalBorderBrush       ).ToHexString(true);
      settings.ManagedContentTabItemInvNormalBackground      = (theme.ManagedContentTabItemInvNormalBackground      ?? tefaut.ManagedContentTabItemInvNormalBackground     ).ToGradientStopString();
      settings.ManagedContentTabItemInvHotBackground         = (theme.ManagedContentTabItemInvHotBackground         ?? tefaut.ManagedContentTabItemInvHotBackground        ).ToGradientStopString();
      settings.ManagedContentTabItemHotBackground            = (theme.ManagedContentTabItemHotBackground            ?? tefaut.ManagedContentTabItemHotBackground           ).ToGradientStopString();
      settings.ManagedContentTabItemHotBorderBrush           = (theme.ManagedContentTabItemHotBorderBrush           ?? tefaut.ManagedContentTabItemHotBorderBrush          ).ToHexString(true);
      settings.ManagedContentTabItemSelectedBackground       = (theme.ManagedContentTabItemSelectedBackground       ?? tefaut.ManagedContentTabItemSelectedBackground      ).ToHexString(true);
      settings.ManagedContentTabItemSelectedForeground       = (theme.ManagedContentTabItemSelectedForeground       ?? tefaut.ManagedContentTabItemSelectedForeground      ).ToHexString(true);
      settings.ManagedContentTabItemSelectedBorderBackround  = (theme.ManagedContentTabItemSelectedBorderBackround  ?? tefaut.ManagedContentTabItemSelectedBorderBackround ).ToHexString(true);
      settings.ManagedContentTabItemSelectedBorderBrush      = (theme.ManagedContentTabItemSelectedBorderBrush      ?? tefaut.ManagedContentTabItemSelectedBorderBrush     ).ToHexString(true);
      settings.ManagedContentTabItemDisabledForeground       = (theme.ManagedContentTabItemDisabledForeground       ?? tefaut.ManagedContentTabItemDisabledForeground      ).ToHexString(true);
      settings.ManagedContentTabItemDisabledBackground       = (theme.ManagedContentTabItemDisabledBackground       ?? tefaut.ManagedContentTabItemDisabledBackground      ).ToHexString(true);
      settings.ManagedContentTabItemDisabledBorderBrush      = (theme.ManagedContentTabItemDisabledBorderBrush      ?? tefaut.ManagedContentTabItemDisabledBorderBrush     ).ToHexString(true);
      settings.DockablePaneTitleBackgroundSelected           = (theme.DockablePaneTitleBackgroundSelected           ?? tefaut.DockablePaneTitleBackgroundSelected          ).ToGradientStopString();
      settings.DockablePaneTitleBackground                   = (theme.DockablePaneTitleBackground                   ?? tefaut.DockablePaneTitleBackground                  ).ToGradientStopString();
      settings.DockablePaneTitleForeground                   = (theme.DockablePaneTitleForeground                   ?? tefaut.DockablePaneTitleForeground                  ).ToHexString(true);
      settings.DockablePaneTitleForegroundSelected           = (theme.DockablePaneTitleForegroundSelected           ?? tefaut.DockablePaneTitleForegroundSelected          ).ToHexString(true);
      settings.DocumentHeaderBackground                      = (theme.DocumentHeaderBackground                      ?? tefaut.DocumentHeaderBackground                     ).ToGradientStopString();
      settings.DocumentHeaderBackgroundSelected              = (theme.DocumentHeaderBackgroundSelected              ?? tefaut.DocumentHeaderBackgroundSelected             ).ToGradientStopString();
      settings.DocumentHeaderBackgroundSelectedActivated     = (theme.DocumentHeaderBackgroundSelectedActivated     ?? tefaut.DocumentHeaderBackgroundSelectedActivated    ).ToGradientStopString();
      settings.DocumentHeaderBackgroundMouseOver             = (theme.DocumentHeaderBackgroundMouseOver             ?? tefaut.DocumentHeaderBackgroundMouseOver            ).ToGradientStopString();
      settings.DocumentHeaderForeground                      = (theme.DocumentHeaderForeground                      ?? tefaut.DocumentHeaderForeground                     ).ToHexString(true);
      settings.DocumentHeaderForegroundSelected              = (theme.DocumentHeaderForegroundSelected              ?? tefaut.DocumentHeaderForegroundSelected             ).ToHexString(true);
      settings.DocumentHeaderForegroundSelectedActivated     = (theme.DocumentHeaderForegroundSelectedActivated     ?? tefaut.DocumentHeaderForegroundSelectedActivated    ).ToHexString(true);
      settings.DocumentHeaderBorder                          = (theme.DocumentHeaderBorder                          ?? tefaut.DocumentHeaderBorder                         ).ToHexString(true);
      settings.DocumentHeaderBorderSelected                  = (theme.DocumentHeaderBorderSelected                  ?? tefaut.DocumentHeaderBorderSelected                 ).ToHexString(true);
      settings.DocumentHeaderBorderSelectedActivated         = (theme.DocumentHeaderBorderSelectedActivated         ?? tefaut.DocumentHeaderBorderSelectedActivated        ).ToHexString(true);
      settings.DocumentHeaderBorderBrushMouseOver            = (theme.DocumentHeaderBorderBrushMouseOver            ?? tefaut.DocumentHeaderBorderBrushMouseOver           ).ToHexString(true);
      settings.PaneHeaderCommandBorderBrush                  = (theme.PaneHeaderCommandBorderBrush                  ?? tefaut.PaneHeaderCommandBorderBrush                 ).ToGradientStopString();
      settings.PaneHeaderCommandBackground                   = (theme.PaneHeaderCommandBackground                   ?? tefaut.PaneHeaderCommandBackground                  ).ToHexString(true);
      settings.OverlayWindowMainBorderBrush                  = (theme.OverlayWindowMainBorderBrush                  ?? tefaut.OverlayWindowMainBorderBrush                 ).ToHexString(true);
      settings.OverlayWindowIntBorderBackground              = (theme.OverlayWindowIntBorderBackground              ?? tefaut.OverlayWindowIntBorderBackground             ).ToGradientStopString();
      settings.OverlayWindowIntBorderBrush                   = (theme.OverlayWindowIntBorderBrush                   ?? tefaut.OverlayWindowIntBorderBrush                  ).ToHexString(true);
      settings.OverlayWindowIntBorderBrush2                  = (theme.OverlayWindowIntBorderBrush2                  ?? tefaut.OverlayWindowIntBorderBrush2                 ).ToHexString(true);
      settings.OverlayWindowIntBorderBackground2             = (theme.OverlayWindowIntBorderBackground2             ?? tefaut.OverlayWindowIntBorderBackground2            ).ToGradientStopString();

      tefaut = null;
      return settings;
    }
    static public MsDev2013_Theme FromTheme(MsDev2013Settings theme)
    {
      var tefaut = FromTheme(MsDev2013_Theme.Apply());
      var settings = new MsDev2013_Theme();
      settings.Name = (theme.Name ?? tefaut.Name);
      settings.DefaultFontSize = double.Parse(theme.DefaultFontSize ?? tefaut.DefaultFontSize);
      settings.DefaultFontFamily = new FontFamily((theme.DefaultFontFamily ?? tefaut.DefaultFontFamily).ToString());
      settings.DotsDefault                                   = (theme.DotsDefault                                   ?? tefaut.DotsDefault                                  ).ToColor();
      settings.DotsActive                                    = (theme.DotsActive                                    ?? tefaut.DotsActive                                   ).ToColor();
      settings.DotsHover                                     = (theme.DotsHover                                     ?? tefaut.DotsHover                                    ).ToColor();
      settings.GeomBrush0                                    = (theme.GeomBrush0                                    ?? tefaut.GeomBrush0                                   ).ToColor();
      settings.GeomBrush1                                    = (theme.GeomBrush1                                    ?? tefaut.GeomBrush1                                   ).ToColor();
      settings.GeomBrush2                                    = (theme.GeomBrush2                                    ?? tefaut.GeomBrush2                                   ).ToColor();
      settings.DefaultBackgroundBrush                        = (theme.DefaultBackgroundBrush                        ?? tefaut.DefaultBackgroundBrush                       ).ToColor();
      settings.LightForegroundBrush                          = (theme.LightForegroundBrush                          ?? tefaut.LightForegroundBrush                         ).ToColor();
      settings.DarkForegroundBrush                           = (theme.DarkForegroundBrush                           ?? tefaut.DarkForegroundBrush                          ).ToColor();
      settings.ManagedContentTabControlNormalBorderBrush     = (theme.ManagedContentTabControlNormalBorderBrush     ?? tefaut.ManagedContentTabControlNormalBorderBrush    ).ToColor();
      settings.ManagedContentTabItemNormalBackground         = (theme.ManagedContentTabItemNormalBackground         ?? tefaut.ManagedContentTabItemNormalBackground        ).ToColor();
      settings.ManagedContentTabItemNormalForeground         = (theme.ManagedContentTabItemNormalForeground         ?? tefaut.ManagedContentTabItemNormalForeground        ).ToColor();
      settings.ManagedContentTabItemNormalBorderBrush        = (theme.ManagedContentTabItemNormalBorderBrush        ?? tefaut.ManagedContentTabItemNormalBorderBrush       ).ToColor();
      settings.ManagedContentTabItemInvNormalBackground      = (theme.ManagedContentTabItemInvNormalBackground      ?? tefaut.ManagedContentTabItemInvNormalBackground     ).ToStops();
      settings.ManagedContentTabItemInvHotBackground         = (theme.ManagedContentTabItemInvHotBackground         ?? tefaut.ManagedContentTabItemInvHotBackground        ).ToStops();
      settings.ManagedContentTabItemHotBackground            = (theme.ManagedContentTabItemHotBackground            ?? tefaut.ManagedContentTabItemHotBackground           ).ToStops();
      settings.ManagedContentTabItemHotBorderBrush           = (theme.ManagedContentTabItemHotBorderBrush           ?? tefaut.ManagedContentTabItemHotBorderBrush          ).ToColor();
      settings.ManagedContentTabItemSelectedBackground       = (theme.ManagedContentTabItemSelectedBackground       ?? tefaut.ManagedContentTabItemSelectedBackground      ).ToColor();
      settings.ManagedContentTabItemSelectedForeground       = (theme.ManagedContentTabItemSelectedForeground       ?? tefaut.ManagedContentTabItemSelectedForeground      ).ToColor();
      settings.ManagedContentTabItemSelectedBorderBackround  = (theme.ManagedContentTabItemSelectedBorderBackround  ?? tefaut.ManagedContentTabItemSelectedBorderBackround ).ToColor();
      settings.ManagedContentTabItemSelectedBorderBrush      = (theme.ManagedContentTabItemSelectedBorderBrush      ?? tefaut.ManagedContentTabItemSelectedBorderBrush     ).ToColor();
      settings.ManagedContentTabItemDisabledForeground       = (theme.ManagedContentTabItemDisabledForeground       ?? tefaut.ManagedContentTabItemDisabledForeground      ).ToColor();
      settings.ManagedContentTabItemDisabledBackground       = (theme.ManagedContentTabItemDisabledBackground       ?? tefaut.ManagedContentTabItemDisabledBackground      ).ToColor();
      settings.ManagedContentTabItemDisabledBorderBrush      = (theme.ManagedContentTabItemDisabledBorderBrush      ?? tefaut.ManagedContentTabItemDisabledBorderBrush     ).ToColor();
      settings.DockablePaneTitleBackgroundSelected           = (theme.DockablePaneTitleBackgroundSelected           ?? tefaut.DockablePaneTitleBackgroundSelected          ).ToStops();
      settings.DockablePaneTitleBackground                   = (theme.DockablePaneTitleBackground                   ?? tefaut.DockablePaneTitleBackground                  ).ToStops();
      settings.DockablePaneTitleForeground                   = (theme.DockablePaneTitleForeground                   ?? tefaut.DockablePaneTitleForeground                  ).ToColor();
      settings.DockablePaneTitleForegroundSelected           = (theme.DockablePaneTitleForegroundSelected           ?? tefaut.DockablePaneTitleForegroundSelected          ).ToColor();
      settings.DocumentHeaderBackground                      = (theme.DocumentHeaderBackground                      ?? tefaut.DocumentHeaderBackground                     ).ToStops();
      settings.DocumentHeaderBackgroundSelected              = (theme.DocumentHeaderBackgroundSelected              ?? tefaut.DocumentHeaderBackgroundSelected             ).ToStops();
      settings.DocumentHeaderBackgroundSelectedActivated     = (theme.DocumentHeaderBackgroundSelectedActivated     ?? tefaut.DocumentHeaderBackgroundSelectedActivated    ).ToStops();
      settings.DocumentHeaderBackgroundMouseOver             = (theme.DocumentHeaderBackgroundMouseOver             ?? tefaut.DocumentHeaderBackgroundMouseOver            ).ToStops();
      settings.DocumentHeaderForeground                      = (theme.DocumentHeaderForeground                      ?? tefaut.DocumentHeaderForeground                     ).ToColor();
      settings.DocumentHeaderForegroundSelected              = (theme.DocumentHeaderForegroundSelected              ?? tefaut.DocumentHeaderForegroundSelected             ).ToColor();
      settings.DocumentHeaderForegroundSelectedActivated     = (theme.DocumentHeaderForegroundSelectedActivated     ?? tefaut.DocumentHeaderForegroundSelectedActivated    ).ToColor();
      settings.DocumentHeaderBorder                          = (theme.DocumentHeaderBorder                          ?? tefaut.DocumentHeaderBorder                         ).ToColor();
      settings.DocumentHeaderBorderSelected                  = (theme.DocumentHeaderBorderSelected                  ?? tefaut.DocumentHeaderBorderSelected                 ).ToColor();
      settings.DocumentHeaderBorderSelectedActivated         = (theme.DocumentHeaderBorderSelectedActivated         ?? tefaut.DocumentHeaderBorderSelectedActivated        ).ToColor();
      settings.DocumentHeaderBorderBrushMouseOver            = (theme.DocumentHeaderBorderBrushMouseOver            ?? tefaut.DocumentHeaderBorderBrushMouseOver           ).ToColor();
      settings.PaneHeaderCommandBorderBrush                  = (theme.PaneHeaderCommandBorderBrush                  ?? tefaut.PaneHeaderCommandBorderBrush                 ).ToStops();
      settings.PaneHeaderCommandBackground                   = (theme.PaneHeaderCommandBackground                   ?? tefaut.PaneHeaderCommandBackground                  ).ToColor();
      settings.OverlayWindowMainBorderBrush                  = (theme.OverlayWindowMainBorderBrush                  ?? tefaut.OverlayWindowMainBorderBrush                 ).ToColor();
      settings.OverlayWindowIntBorderBackground              = (theme.OverlayWindowIntBorderBackground              ?? tefaut.OverlayWindowIntBorderBackground             ).ToStops();
      settings.OverlayWindowIntBorderBrush                   = (theme.OverlayWindowIntBorderBrush                   ?? tefaut.OverlayWindowIntBorderBrush                  ).ToColor();
      settings.OverlayWindowIntBorderBrush2                  = (theme.OverlayWindowIntBorderBrush2                  ?? tefaut.OverlayWindowIntBorderBrush2                 ).ToColor();
      settings.OverlayWindowIntBorderBackground2             = (theme.OverlayWindowIntBorderBackground2             ?? tefaut.OverlayWindowIntBorderBackground2            ).ToStops();

      tefaut = null;
      return settings;
    }
  }
}







