/* oio * 4/5/2014 * Time: 5:46 AM */
using System;
using System.Windows.Media;
namespace ThemeTool
{
  static public class MsDev2013_Blue
  {
    static public Color ColorBlack { get { return Colors.Black; } }
    
    // Color.FromRgb(0x4D, 0x60, 0x82);
    static public Color ColorBlue { get { return "4D6082".ToColor(); } }
    
    // Color.FromRgb(0x29, 0x39, 0x55)
    static public Color ColorWindowBackground { get { return "293955".ToColor(); } }
    
    // Color.FromRgb(0x29, 0x39, 0x55)
    static public Color ColorDefaultBackground { get { return "293955".ToColor(); } }
    
    static public Color ColorBlueSpecial { get { return "4D6082".ToColor(); } }
    static public Color ColorTabActive { get { return "4D6082".ToColor(); } }
    static public Color ColorTabActiveFocus { get { return "FFF29D".ToColor(); } }
    static public Color ColorTabHover { get { return "5B7199".ToColor(); } }
    static public Color ColorTabBorder { get { return "8E9BBC".ToColor(); } }
    
    // ManagedContentTabItemHotBorderBrush
    // ManagedContentTabItemHotBackground
    // ManagedContentTabItemInvHotBackground
    
    // #4d6082 | PinnedTab_DefaultBackground
    // #4b5c74 | PinnedTab_HotBackground
  }
}

