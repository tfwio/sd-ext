using System;
using System.Windows.Media;
using ThemeTool;
namespace System
{
  static public partial class ThemeGen
  {
    static public MsDev2013Settings ToSetting(this MsDev2013_Theme theme)
    {
      var tefaut = MsDev2013_Theme.Apply();
      var settings = new MsDev2013Settings();
      settings.ResourceID                                    = (theme.ResourceID                                    ?? tefaut.ResourceID                                   );
      settings.Name                                          = (theme.Name                                          ?? tefaut.Name                                         );
      settings.DefaultFontSize                               = (theme.DefaultFontSize                               ?? tefaut.DefaultFontSize                              ).ToString();
      settings.DefaultFontFamily                             = (theme.DefaultFontFamily                             ?? tefaut.DefaultFontFamily                            ).ToString();
      settings.DotsDefault                                   = (theme.DotsDefault                                   ?? tefaut.DotsDefault                                  ).ToHexString(true);
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
    static public MsDev2013_Theme ToTheme(this MsDev2013Settings theme)
    {
      var tefaut = MsDev2013_Theme.Apply().ToSetting();
      var settings = new MsDev2013_Theme();
      settings.ResourceID = (theme.ResourceID ?? tefaut.ResourceID);
      settings.Name = (theme.Name ?? tefaut.Name);
      settings.DefaultFontSize = double.Parse(theme.DefaultFontSize ?? tefaut.DefaultFontSize);
      settings.DefaultFontFamily = new FontFamily((theme.DefaultFontFamily ?? tefaut.DefaultFontFamily).ToString());
      settings.DotsDefault                                   = (theme.DotsDefault                                   ?? tefaut.DotsDefault                                  ).ToColor();
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

