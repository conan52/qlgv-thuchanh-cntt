using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace TkbThucHanhCNTT.Models.Enums
{
    public static class EnumUltils
    {
        public static List<EnumInfo> GetDescriptions<T>()
        {
            Type type = typeof (T);
            var descs = new List<EnumInfo>();
            string[] names = Enum.GetNames(type);

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                FieldInfo field = type.GetField(name);
                object[] fds = field.GetCustomAttributes(typeof (DescriptionAttribute), true);
                descs.Add(new EnumInfo(fds.Cast<DescriptionAttribute>().Select(fd => fd.Description).First(),
                    (int) Enum.Parse(type, name), name));
            }
            return descs;
        }

        public static string GetDescriptionAttribute(this Enum enu)
        {
            Type type = enu.GetType();
            FieldInfo field = type.GetField(enu.ToString());
            object[] fds = field.GetCustomAttributes(typeof (DescriptionAttribute), true);
            return fds.Cast<DescriptionAttribute>().Select(fd => fd.Description).First();
        }

        public static List<EnumInfo> GetDescriptions_ChuyenNganh()
        {
            return GetDescriptions<ChuyenNganh>();
        }

        public static List<EnumInfo> GetDescriptions_TrinhDo()
        {
            return GetDescriptions<TrinhDo>();
        }

        public static List<EnumInfo> GetDescriptions_QuyenHan()
        {
            return GetDescriptions<QuyenHan>();
        }
    }

    public class EnumInfo
    {
        public EnumInfo(string description, int value, string name)
        {
            Description = description;
            Value = value;
            Name = name;
        }

        public string Description { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
    }
}