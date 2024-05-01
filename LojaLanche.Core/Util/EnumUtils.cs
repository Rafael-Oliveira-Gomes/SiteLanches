using System.ComponentModel;
using System.Reflection;

namespace LojaLanche.Core.Util
{
    public static class EnumUtils
    {
        public static string? GetEnumDescription(this Enum value)
        {
            FieldInfo? field = value.GetType().GetField(value.ToString());

            if (field == null) return null;

            DescriptionAttribute? attribute = (DescriptionAttribute?)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
