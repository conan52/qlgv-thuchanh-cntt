using System;
using System.ComponentModel;
using System.Globalization;

namespace TKBThucHanh.Models.Enums
{
    public class EnumToLocalizedName : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return (sourceType == typeof (Enum));
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return (destinationType == typeof (String));
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (!(value is Enum))
            {
                throw new ArgumentException(@"Can only convert an instance of enum.", "value");
            }
            return ((Enum) value).GetLocalizedName();
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value,
            Type destinationType)
        {
            if (!(destinationType == typeof (String)))
            {
                throw new ArgumentException(@"Can only convert to string.", "destinationType");
            }
            if (!(value is Enum))
            {
                throw new ArgumentException(@"Can only convert an instance of enum.", "value");
            }
            return ((Enum) value).GetLocalizedName();
        }
    }
}