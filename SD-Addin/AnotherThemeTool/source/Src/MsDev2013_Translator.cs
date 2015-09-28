/* oio * 4/5/2014 * Time: 5:46 AM */
using System;
namespace ThemeTool
{
  static class MsDev2013_Translator
  {
    /// <summary>
    /// Gets a string version of our colour setting.
    /// Either we're returning a logical Color or GradientStep.
    /// </summary>
    static public string GetColour(MsDev2013_T colorID, MsDev2013_Theme themeRef)
    {
      switch (colorID)
      {
//          case MsDev2013_T.DefaultFontFamily                          : return themeRef.DefaultFontFamily.ToString();
//          case MsDev2013_T.DefaultFontSize                            : return themeRef.DefaultFontSize.ToString();
          case MsDev2013_T.GeomBrush0                                   : return themeRef.GeomBrush0.ToHexString();
          case MsDev2013_T.GeomBrush1                                   : return themeRef.GeomBrush1.ToHexString();
          case MsDev2013_T.GeomBrush2                                   : return themeRef.GeomBrush2.ToHexString();
          case MsDev2013_T.DefaultBackgroundBrush                       : return themeRef.DefaultBackgroundBrush.ToHexString();
          case MsDev2013_T.LightForegroundBrush                         : return themeRef.LightForegroundBrush.ToHexString();
          case MsDev2013_T.DarkForegroundBrush                          : return themeRef.DarkForegroundBrush.ToHexString();
          case MsDev2013_T.ManagedContentTabControlNormalBorderBrush    : return themeRef.ManagedContentTabControlNormalBorderBrush.ToHexString();
          case MsDev2013_T.ManagedContentTabItemNormalBackground        : return themeRef.ManagedContentTabItemNormalBackground.ToHexString();
          case MsDev2013_T.ManagedContentTabItemInvNormalBackground     : return themeRef.ManagedContentTabItemInvNormalBackground.ToGradientStopString();
          case MsDev2013_T.ManagedContentTabItemHotBackground           : return themeRef.ManagedContentTabItemHotBackground.ToGradientStopString();
          case MsDev2013_T.ManagedContentTabItemSelectedBackground      : return themeRef.ManagedContentTabItemSelectedBackground.ToHexString();
          case MsDev2013_T.ManagedContentTabItemDisabledBackground      : return themeRef.ManagedContentTabItemDisabledBackground.ToHexString();
          case MsDev2013_T.ManagedContentTabItemSelectedBorderBackround : return themeRef.ManagedContentTabItemSelectedBorderBackround.ToHexString();
          case MsDev2013_T.ManagedContentTabItemNormalBorderBrush       : return themeRef.ManagedContentTabItemNormalBorderBrush.ToHexString();
          case MsDev2013_T.ManagedContentTabItemSelectedBorderBrush     : return themeRef.ManagedContentTabItemSelectedBorderBrush.ToHexString();
          case MsDev2013_T.ManagedContentTabItemHotBorderBrush          : return themeRef.ManagedContentTabItemHotBorderBrush.ToHexString();
          case MsDev2013_T.ManagedContentTabItemDisabledBorderBrush     : return themeRef.ManagedContentTabItemDisabledBorderBrush.ToHexString();
          case MsDev2013_T.DockablePaneTitleBackgroundSelected          : return themeRef.DockablePaneTitleBackgroundSelected.ToGradientStopString();
          case MsDev2013_T.DockablePaneTitleBackground                  : return themeRef.DockablePaneTitleBackground.ToGradientStopString();
          case MsDev2013_T.DockablePaneTitleForeground                  : return themeRef.DockablePaneTitleForeground.ToHexString();
          case MsDev2013_T.DockablePaneTitleForegroundSelected          : return themeRef.DockablePaneTitleForegroundSelected.ToHexString();
          case MsDev2013_T.DocumentHeaderBackground                     : return themeRef.DocumentHeaderBackground.ToGradientStopString();
          case MsDev2013_T.DocumentHeaderBorderBrushMouseOver           : return themeRef.DocumentHeaderBorderBrushMouseOver.ToHexString();
          case MsDev2013_T.DocumentHeaderForeground                     : return themeRef.DocumentHeaderForeground.ToHexString();
          case MsDev2013_T.DocumentHeaderForegroundSelected             : return themeRef.DocumentHeaderForegroundSelected.ToHexString();
          case MsDev2013_T.DocumentHeaderForegroundSelectedActivated    : return themeRef.DocumentHeaderForegroundSelectedActivated.ToHexString();
          case MsDev2013_T.DocumentHeaderBackgroundSelected             : return themeRef.DocumentHeaderBackgroundSelected.ToGradientStopString();
          case MsDev2013_T.DocumentHeaderBackgroundSelectedActivated    : return themeRef.DocumentHeaderBackgroundSelectedActivated.ToGradientStopString();
          case MsDev2013_T.DocumentHeaderBackgroundMouseOver            : return themeRef.DocumentHeaderBackgroundMouseOver.ToGradientStopString();
          case MsDev2013_T.PaneHeaderCommandBorderBrush                 : return themeRef.PaneHeaderCommandBorderBrush.ToGradientStopString();
          case MsDev2013_T.PaneHeaderCommandBackground                  : return themeRef.PaneHeaderCommandBackground.ToHexString();
          case MsDev2013_T.DocumentHeaderBorder                         : return themeRef.DocumentHeaderBorder.ToHexString();
          case MsDev2013_T.DocumentHeaderBorderSelected                 : return themeRef.DocumentHeaderBorderSelected.ToHexString();
          case MsDev2013_T.DocumentHeaderBorderSelectedActivated        : return themeRef.DocumentHeaderBorderSelectedActivated.ToHexString();
          case MsDev2013_T.OverlayWindowMainBorderBrush                 : return themeRef.OverlayWindowMainBorderBrush.ToHexString();
          case MsDev2013_T.OverlayWindowIntBorderBackground             : return themeRef.OverlayWindowIntBorderBackground.ToGradientStopString();
          case MsDev2013_T.OverlayWindowIntBorderBrush                  : return themeRef.OverlayWindowIntBorderBrush.ToHexString();
          case MsDev2013_T.OverlayWindowIntBorderBrush2                 : return themeRef.OverlayWindowIntBorderBrush2.ToHexString();
          case MsDev2013_T.OverlayWindowIntBorderBackground2            : return themeRef.OverlayWindowIntBorderBackground2.ToGradientStopString();
          default: return null;
      }
    }
  }
}







