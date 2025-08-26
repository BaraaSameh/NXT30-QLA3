using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskCSADV
{
    static class CollectionExtensions
    {
        public static IEnumerable<List<T>> Batch<T>(this IEnumerable<T> source, int size) =>
            source.Select((x, i) => new { x, i }).GroupBy(x => x.i / size).Select(g => g.Select(x => x.x).ToList());
    }

}
