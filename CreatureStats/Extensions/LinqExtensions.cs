using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace CreatureStats.Extensions
{
    public static class LinqExtensions
    {
        public static bool CreateFilter<T>(this T entry, object field, object val)
        {
            var basicValue = GetValue(entry, (MemberInfo)field);

            switch (basicValue.GetType().Name)
            {
                case "UInt32":
                    return basicValue.ToUInt32() == val.ToUInt32();
                case "Int32":
                    return basicValue.ToInt32() == val.ToInt32();
                case "Single":
                    return basicValue.ToFloat() == val.ToFloat();
                case "UInt64":
                    return basicValue.ToUlong() == val.ToUlong();
                case "String":
                    return basicValue.ToString().ContainsText(val.ToString());
                case @"UInt32[]":
                {
                    return ((uint[])basicValue).Any(el => el.ToUInt32() == val.ToUInt32());
                }
                case @"Int32[]":
                {
                    return ((int[])basicValue).Any(el => el.ToInt32() == val.ToInt32());
                }
                case @"Single[]":
                {
                    return ((float[])basicValue).Any(el => el.ToFloat() == val.ToFloat());
                }
            case @"UInt64[]":
                {
                    return ((ulong[])basicValue).Any(el => el.ToUlong() == val.ToUlong());
                }
                case @"String[]":
                {
                    return ((uint[])basicValue).Any(el => el.ToString().ContainsText(val.ToString()));
                }
                // todo: more
                default:
                    return false;
            }
        }

        private static Object GetValue<T>(T entry, MemberInfo field)
        {
            if (field is FieldInfo)
                return entry.GetType().GetField(field.Name).GetValue(entry);
            else if (field is PropertyInfo)
                return entry.GetType().GetProperty(field.Name).GetValue(entry, null);
            else
                return null;
        }
    }
}
