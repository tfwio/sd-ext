# PRETHROW: Another ThemeTool

targets SharpDevelop 5.x (AvalonDock-1.3)

This addin is an elaboration built upon [AlienJust/ThemeTool](https://github.com/AlienJust/ThemeTool) for SharpDevelop 4x and 5x.
Is kind of a shot in the dark, made partly out of curiosity as to what kinds of challenges I might find in attempt (even if slightly,) to modernize the UI a bit.

While there are screen-shots, there currently isn't an implementation which saves your setting for load-time after closing down SD and relaunching.

![](https://raw.githubusercontent.com/tfwio/sd-ext/274c52d36886b529eb79ff80658b98935439f990/SD-Addin/AnotherThemeTool/artifacts/screen-light.jpg)

## Featured

- Same old ThemeTool
- Load XAML themes (not including the following noted 'dynamic theme').
- Import/Export color settings for the modified 'dynamic' theme.
- Imported settings can be modified in SD's property-grid
- The dev2010 theme was modified slightly
    - Inspired by Dev2013 theme for AvalonDock-3.0.
    - Color settings are now 'dynamic', which allows you to customize.
    - tiled-graphics ([stolen from here](https://github.com/4ux-nbIx/AvalonDock.Themes.VS2013/blob/21723c3a22941d883a88afaee1581eea5c836f33/Xceed.Wpf.AvalonDock.Themes.VS2013/Theme.xaml#L485 'github.com/4ux-nbIx/AvalonDock.Themes.VS2013')) and thrown it into dockable title-bars.

## How to customize the theme

- Export a theme file from the Tools-Menu `Tools/'Import/Export Theme'/Export 2013 Theme`, or download one of the setting-files linked to somewhere in this readme...
- Edit the theme.
- Import the theme back into SD through the same menu (as 'export').
- Open the file in a text editor
    - Incidentally, when you load the file in SharpDevelop's text-editor, it ignores changes for some reason... So you may as well use another text editor for now...
    - AvalonDock theme in SharpDevelop automatically updates when you save the settings file.

> In the future all of the Color settings will be defined as LinearGradients.  Until then, we have two types of color-definitions.  Colors, and LinearGradientStops.

Its fairly easy to tell the difference between a color setting and a GradientStop.

Just look at the example setting-files for a good example.
*property-grid settings don't apply—just yet*.

See: [/SD-Addin/ThemeTool/artifacts/theme-default.yml](https://github.com/tfwio/sd-ext/blob/master/SD-Addin/ThemeTool/artifacts/theme-default.yml)

**Color Examples in YAML-settings**

```yaml
# ...
  SomeID01: '#000000'
  SomeID02: '#00000000'
  SomeID03: 000000
# ...
```

**Gradient-Stop Examples in YAML-settings**

```yaml
# ...
  # you can just specify a color.
  # Note that this is equivelant to '#000000:0.0'.
  SomeID01: 000000
  # '000000,000000' is pointless; Equivelant the the above.
  SomeID02: '#00000000:0.0,#FFFFFF:1.0'
# ...
```

## Third-Party Sources

Sources are included from the following projects:

- SharpDevelop 5
- SharpDevelop 5/AvalonDock v1.3
- AvalonDock.Themes (v1.3)
- AlienJust/ThemeTool (sdaddin)
    - see-also: https://github.com/AlienJust/ThemeTool/wiki
- YamlDotNet (nuget)
- FirstFloor.ModernUI (nuget)
