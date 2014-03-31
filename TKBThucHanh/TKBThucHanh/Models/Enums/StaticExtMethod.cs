using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;

namespace TKBThucHanh.Models.Enums
{
    public static class StaticExtMethod
    {
        public static string GetLocalizedName(this Enum @enum)
        {
            if (@enum == null)
                return null;
            string description = @enum.ToString();
            FieldInfo fieldInfo = @enum.GetType().GetField(description);
            var attributes =
                (DisplayAttribute[])fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false);
            if (attributes.Any())
            {
                description = attributes[0].GetDescription();
            }
            return description;
        }
    }
}