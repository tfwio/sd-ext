// Generated from: "$(projectdir)../artifacts/msdev2013theme.yaml"
using System;
using System.ComponentModel;
using System.Globalization;
using System.Security.Permissions;
using System.Windows.Media;
namespace ThemeTool
{
  public class GradientStopExpandableConverter : ExpandableObjectConverter
  {
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      if (destinationType == typeof(GradientStop)) return true;
      if (destinationType == typeof(GradientStopCollection)) return true;
      if (destinationType == typeof(string)) return true;
      return base.CanConvertTo(context, destinationType);
    }
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      if (destinationType == typeof(GradientStopCollection) && value is string)
        return string.Format("{0}",(value as GradientStopCollection).ToGradientStopString());
      
      if (destinationType == typeof(string) && value is GradientStop)
        return string.Format(
          "{0}:{1}",
          (value as GradientStop).Color.ToHexString(true),
          (value as GradientStop).Offset
         );
      
      if (destinationType == typeof(GradientStop) && value is string)
        return (value as string).ToGradientStop();
      
      if (destinationType == typeof(string) && value is GradientStopCollection)
        return (value as GradientStopCollection).ToGradientStopString();
      
      return base.ConvertTo(context, culture, value, destinationType);
    }
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      if (sourceType == typeof(string)) return true;
      return base.CanConvertFrom(context, sourceType);
    }
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
      if (value is string)
      {
//        System.Windows.Forms.MessageBox.Show(string.Format("{0}\n{1}",value,context));
        return (value as string).ToStops();
      }
      
      return base.ConvertFrom(context, culture, value);
    }
    public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
    {
      return null;
      return base.GetProperties(context, value, attributes);
    }
  }
  [HostProtection(SecurityAction.LinkDemand, SharedState = true)]
  public class GradientStopCollectionConverter : TypeConverter
  {
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      return sourceType == typeof(string) || sourceType==typeof(GradientStopCollection) || base.CanConvertFrom(context, sourceType);
    }

    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
      if (value is string) {
        return (value as string).ToStops();
      }
      if (value is GradientStopCollection) {
        return (value as GradientStopCollection).ToGradientStopString();
      }
      if (value == null) {
        return "";
      }
      return base.ConvertFrom(context, culture, value);
    }
  }
}

