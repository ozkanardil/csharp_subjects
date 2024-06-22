using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Assets
{
    public static class DateTimeExtensions
    {
        public static string ToFormattedString(this DateTime dateTime, string format)
        {
            return dateTime.ToString(format);
        }
    }
}
