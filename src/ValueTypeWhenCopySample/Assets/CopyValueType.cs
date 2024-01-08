using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeWhenCopySample.Assets
{
    internal static class CopyValueType
    {
        public static void CopyValueTypeMethod(int number)
        {
            int b = number;
            int c = b;
            ++c;

            Console.WriteLine($"Variable b is {b} \n");
            Console.WriteLine($"Variable c is {c} \n");
        }
    }
}
