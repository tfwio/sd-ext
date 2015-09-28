# PRETHROW: Another ThemeTool

This addin is an elaboration built upon [AlienJust/ThemeTool](https://github.com/AlienJust/ThemeTool) for SharpDevelop 4x and 5x.

![](https://raw.githubusercontent.com/tfwio/sd-ext/0c9d644e1975e4bdc1ecdbdb031c3df0852beed4/SD-Addin/AnotherThemeTool/artifacts/screen-blue.png)


![](https://raw.githubusercontent.com/tfwio/sd-ext/0c9d644e1975e4bdc1ecdbdb031c3df0852beed4/SD-Addin/AnotherThemeTool/artifacts/screen-light.png)

![](https://raw.githubusercontent.com/tfwio/sd-ext/0c9d644e1975e4bdc1ecdbdb031c3df0852beed4/SD-Addin/AnotherThemeTool/artifacts/screen-dark.png)

- This project targets SharpDevelop 5.x

## Features In Progress

- The dev2010 theme was modified slightly
    - Inspired by Dev2013 theme for AvalonDock-3.0
    - Color settings are now 'dynamic', which allows you to customize.
    - Theme settings are stored in YAML setting files.

## How to customize the theme

- Export a theme file from the Tools-Menu.
- Import the theme back into SD through the same menu.
- Open the file in a text editor
    - Incidentally, when you load the file in SharpDevelop's text-editor, it ignores changes for some reason... So you may as well use another text editor for now...
    - AvalonDock theme in SharpDevelop automatically updates when you save the settings file.

> In the future all of the Color settings will be defined as LinearGradients.  Until then, we have two types of color-definitions.  Colors, and LinearGradientStops.

Its fairly easy to tell the difference between a color setting and a GradientStop.

Just look at the example setting-files for a good example.
*property-grid settings don't apply—just yet*.

See: [/SD-Addin/AnotherThemeTool/artifacts/theme-default.yml](https://github.com/tfwio/sd-ext/blob/master/SD-Addin/AnotherThemeTool/artifacts/theme-default.yml)

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
