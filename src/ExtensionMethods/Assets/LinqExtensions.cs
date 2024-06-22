using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Assets
{
    public static class LinqExtensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return source.Where(item => !predicate(item));
        }
    }
}
