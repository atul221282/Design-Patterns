using System;

namespace DesignPattern.Generic
{
    public static class StringExtensions
    {
        public static TEnum ParseEnum<TEnum>(this string value) where TEnum : struct
        {
            return (TEnum)Enum.Parse(typeof(TEnum), value);
        }
    }
}
