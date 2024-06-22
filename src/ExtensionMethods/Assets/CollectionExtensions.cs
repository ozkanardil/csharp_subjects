using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Assets
{
    public static class CollectionExtensions
    {
        public static void AddRange<T>(this List<T> list, IEnumerable<T> items)
        {
            list.AddRange(items);
        }
    }
}
