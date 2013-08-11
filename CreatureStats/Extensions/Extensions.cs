using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CreatureStats.Extensions
{
    public static class Extensions
    {
        public static string ReadCString(this BinaryReader reader)
        {
            byte number;
            var temp = new List<byte>();

            while ((number = reader.ReadByte()) != 0)
            {
                temp.Add(number);
            }

            return Encoding.UTF8.GetString(temp.ToArray());
        }

        public static T ReadStruct<T>(this BinaryReader reader) where T : struct
        {
            byte[] rawData = reader.ReadBytes(Marshal.SizeOf(typeof(T)));

            GCHandle handle = GCHandle.Alloc(rawData, GCHandleType.Pinned);
            T returnObject = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));

            handle.Free();

            return returnObject;
        }

        public static void SetEnumValues<T>(this ComboBox cb, string NoValue)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("NAME");

            dataTable.Rows.Add(new Object[] { -1, NoValue });

            foreach (var str in Enum.GetValues(typeof(T)))
            {
                dataTable.Rows.Add(new Object[] { (int)str, "(" + ((int)str).ToString("000") + ") " + str });
            }

            cb.DataSource = dataTable;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
        }

        public static void SetStructFields<T>(this ComboBox cb)
        {
            cb.Items.Clear();

            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(MemberInfo));
            dataTable.Columns.Add("NAME", typeof(String));

            var type = typeof(T).GetMembers();
            var i = 0;
            foreach (var str in type)
            {
                if (!(str is FieldInfo) && !(str is PropertyInfo))
                    continue;

                var dataRow = dataTable.NewRow();
                dataRow["ID"] = str;
                dataRow["NAME"] = String.Format("({0:000}) {1}", i, str.Name);
                dataTable.Rows.Add(dataRow);
                i++;
            }

            cb.DataSource = dataTable;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
        }

        public static byte ToByte(this Object val)
        {
            if (val == null)
                return 0;

            byte number;
            byte.TryParse(val.ToString(), out number);
            return number;
        }

        public static uint ToUInt32(this Object val)
        {
            if (val == null)
                return 0;

            uint number;
            uint.TryParse(val.ToString(), out number);
            return number;
        }

        public static uint ToUInt32FromPossibleHexString(this Object val)
        {
            if (val.GetType() == typeof(String))
            {
                var newVal = ((String)val).Replace("0x", String.Empty);
                if (newVal.Equals(val))
                    return val.ToUInt32();

                try
                {
                    return uint.Parse(newVal, System.Globalization.NumberStyles.AllowHexSpecifier);
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0u;
                }
            }

            return val.ToUInt32();
        }

        public static string ToHex(this Object val)
        {
            return String.Format("0x{0:X}", val);
        }

        public static int ToInt32(this Object val)
        {
            if (val == null)
                return 0;

            int number;
            int.TryParse(val.ToString(), out number);
            return number;
        }

        public static float ToFloat(this Object val)
        {
            if (val == null)
                return 0.0f;

            float number;
            float.TryParse(val.ToString().Replace(',', '.'), out number);
            return number;
        }

        public static ulong ToUlong(this Object val)
        {
            if (val == null)
                return 0U;

            ulong number;
            ulong.TryParse(val.ToString(), out number);
            return number;
        }

        public static bool ContainsText(this string text, string compareText)
        {
            return (text.ToUpper().IndexOf(compareText.ToUpper(), StringComparison.CurrentCultureIgnoreCase) != -1);
        }

        public static bool ContainsText(this string text, string[] compareText)
        {
            return compareText.Any(str => (text.IndexOf(str, StringComparison.CurrentCultureIgnoreCase) != -1));
        }
    }
}
