namespace System
{
  using System.Windows.Media;
  static public class ThemeEx
  {
    
    const System.Globalization.NumberStyles nflag = System.Globalization.NumberStyles.HexNumber;
    
    static public System.Windows.Media.FontFamily ToFont(this string input)
    {
      return new System.Windows.Media.FontFamily(input);
    }
    
    #region ColorToHexString
    
    #region private
    
    /// <summary>
    /// I'm assuming ColorConverter parses your typical WPF Color value definition
    /// which includes the hash "#FF000000"={Color: A=255, R=0, G=0, B=0}.
    /// </summary>
    /// <remarks>
    /// This is merely here to point out ColorConverter.ConvertFromString method.
    /// </remarks>
    /// <seealso cref="System.Windows.Media.ColorConverter.ConvertFromString(string)"/>
    static int ToColorInt(this string color, bool ignoreAlphaChannel)
    {
      var value = color.Clean();
      bool hasAlpha = (value.Length==8);
      
      var c = (Color)ColorConverter.ConvertFromString(color);
      return !ignoreAlphaChannel||hasAlpha ?
        (c.A << 24) + (c.R << 16) + (c.G << 8) + c.B:
        (c.R << 16) + (c.G << 8) + c.B;
    }
    
    /// <summary>
    /// For RGBA in hex
    /// </summary>
    /// <param name="c"></param>
    /// <param name="useHash"></param>
    /// <returns></returns>
    static string ToHex8String(this Color c, bool useHash)
    {
      return string.Format(useHash ? "#{0:X8}" : "{0:X8}", (c.A << 24) + (c.R << 16) + (c.G << 8) + c.B);
    }
    
    /// <summary>
    /// Here, the alpha value is ignored.
    /// </summary>
    /// <param name="c"></param>
    /// <param name="useHash"></param>
    /// <returns></returns>
    static string ToHex6String(this Color c, bool useHash)
    {
      return string.Format(useHash ? "#{0:X6}" : "{0:X6}", (c.R << 16) + (c.G << 8) + c.B);
    }
    #endregion
    
    static public string ToHexString(this Color? cn, bool useHash=false)
    {
      var c = cn.HasValue ? cn.Value : Colors.Black;
      return (c.A==255) ? c.ToHex6String(useHash): c.ToHex8String(useHash);
    }
    static public string ToHexString(this Color c, bool useHash=false)
    {
      return (c.A==255) ? c.ToHex6String(useHash): c.ToHex8String(useHash);
    }
    
    #endregion
    
    #region private
    /// <summary>
    /// If the string is null, we pass an empty string
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    static string Clean(this string input)
    {
      return input
        .Replace("#",string.Empty)
        .Replace("\t",string.Empty)
        .Replace("\r",string.Empty)
        .Replace("\n",string.Empty)
        .Replace(" ",string.Empty);
    }
    /// <summary>
    /// Input string must be in the format "#007FFF:0.5".
    /// Hex strings can be either 6 or eight X-chars long and may or not
    /// start with "0x" and "#".
    /// </summary>
    static GradientStop ToGradientStop(this string input)
    {
      var data = input.Clean();
      if (!data.Contains(":")) return new GradientStop(data.ToColor(),0);
      var ray = data.Split(':');
      
      var offset = Double.NaN;
      var result = new GradientStop{
        Color=ray[0].ToColor(),
        Offset = double.TryParse(ray[1], out offset) ? offset : 0
      };
      
      ray = null;
      data = null;
      return result;
    }
    
    #endregion
    
    static public string ToGradientStopString(this GradientStopCollection input)
    {
      if (input.Count==0) return "#000000:0";
      var airy = new string[input.Count];
      for (int i=0; i < input.Count; i++)
      {
        var itemresult = input[i].Offset.Equals(0.0F) ?
          string.Format("#{0}", input[i].Color.ToHexString()) :
          string.Format("#{0}:{1}", input[i].Color.ToHexString(), input[i].Offset);
        airy[i] = itemresult;
      }
      var result = string.Join(",",airy);
      airy = null;
      return result;
    }
    
    static public GradientStopCollection ToStops(this string input)
    {
      var dataList = (input ?? "000000").Split(',');
      var result = new GradientStopCollection();
      
      foreach (var item in dataList)
        result.Add(item.ToGradientStop());
      
      return result;
    }
    
    /// <summary>
    /// String must be 6 or 8 characters.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>our color result.</returns>
    static public Color ToColor(this string input)
    {
      var strNum = input ?? "000000";
      strNum = strNum.Clean();
      
      bool is6 = strNum.Length == 6, is8 = strNum.Length == 8;
      int offset = 0;
      
      if (!(is6 || is8)) throw new ArgumentException(string.Format("Unexpected\n  length {0},\n  input-length: {1},\n  input: {2}",strNum.Length,input.Length,input));
      
      var result = new Color();
      var data = string.Empty;
      
      if (is8)
      {
        result.A = Byte.Parse(strNum.Substring(offset, 2), nflag);
        offset = 2;
      }
      else result.A = 255;
      
      result.R = Byte.Parse(strNum.Substring(offset+0, 2), nflag);
      result.G = Byte.Parse(strNum.Substring(offset+2, 2), nflag);
      result.B = Byte.Parse(strNum.Substring(offset+4, 2), nflag);
      
      return result;
    }
  }
}

