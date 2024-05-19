using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypeAsParameterSample.Assets
{
    internal static class ListContainer
    {
        public static void AddOneToList(List<int> list)
        {
            list.Add(1);
        }
    }
}
