using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TkbThucHanhCNTT.Models.Enums
{
    public static class EnumUltils
    {
        public static List<EnumInfo> GetDescriptions<T>()
        {
            var type = typeof (T);
            var descs = new List<EnumInfo>();
            var names = Enum.GetNames(type);

            for (var i = 0; i < names.Length; i++)
            {
                var name = names[i];
                var field = type.GetField(name);
                var fds = field.GetCustomAttributes(typeof (DescriptionAttribute), true);
                descs.Add(new EnumInfo(fds.Cast<DescriptionAttribute>().Select(fd => fd.Description).First(),
                    (int) Enum.Parse(type, name), name));
            }
            return descs;
        }

        public static string GetDescriptionAttribute(this Enum enu)
        {
            var type = enu.GetType();
            var field = type.GetField(enu.ToString());
            var fds = field.GetCustomAttributes(typeof (DescriptionAttribute), true);
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