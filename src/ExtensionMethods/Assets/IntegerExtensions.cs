using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Assets
{
    public static class IntegerExtensions
    {
        public static int MultiplyBy(this int value, int factor)
        {
            return value * factor;
        }
    }
}
