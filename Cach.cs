using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskCSADV
{
    internal class Cach<TKey, TValue>
    {
        private Dictionary<TKey, TValue> cache = new Dictionary<TKey, TValue>();
        public TValue this[TKey key]
        {
            get => cache.ContainsKey(key) ? cache[key] : default(TValue);
            set => cache[key] = value;
        }///xxx
    }
}
