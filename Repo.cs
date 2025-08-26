using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskCSADV
{
    interface IEntity { int Id { get; set; } }

    class Repository<T> where T : IEntity
    {
        private List<T> items = new();
        public void Add(T item) => items.Add(item);
        public T Get(int id) => items.FirstOrDefault(i => i.Id == id);
        public void Update(T item)
        {
            var index = items.FindIndex(i => i.Id == item.Id);
            if (index >= 0) items[index] = item;
        }
        public void Delete(int id) => items.RemoveAll(i => i.Id == id);
    }
}

