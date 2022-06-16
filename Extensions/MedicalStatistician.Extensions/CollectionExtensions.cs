using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Extensions
{
    public static class CollectionExtensions
    {
        public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            int index = 0;
            foreach (var item in collection)
            {
                if (predicate(item))
                    return index;
                index++;
            }
            return index;
        }
    }
}
