using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colors.Net
{
    public struct RichString
    {
        private readonly string _value;

        public RichString(string value)
        {
            _value = value;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override string ToString()
        {
            return _value;
        }

        public string Value
        {
            get
            {
                return _value.Length > 0 && _value[0] > '\uE000' && _value[0] == _value[_value.Length - 1]
                    ? _value.Trim(_value[0])
                    : _value;
            }
        }

        public override bool Equals(object obj)
        {
            return ToString().Equals(obj);
        }

        public bool Equals(RichString other)
        {
            return ToString().Equals(other.ToString());
        }

        public static bool operator ==(RichString rs1, RichString rs2)
        {
            return rs1.Equals(rs2);
        }

        public static bool operator !=(RichString rs1, RichString rs2)
        {
            return !rs1.Equals(rs2);
        }

        public static bool operator ==(string str, RichString rs2)
        {
            return str.Equals(rs2.ToString());
        }

        public static bool operator !=(string str, RichString rs2)
        {
            return !str.Equals(rs2.ToString());
        }

        public static RichString operator +(RichString rs1, RichString rs2)
        {
            return new RichString(rs1.ToString() + rs2.ToString());
        }

        public static RichString operator +(string str, RichString rs2)
        {
            return new RichString(str + rs2.ToString());
        }
    }
}
