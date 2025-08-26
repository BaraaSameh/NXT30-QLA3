using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskCSADV
{
    class ContactManager
    {
        private Dictionary<string, string> contacts = new();
        public void Add(string name, string phone) => contacts[name] = phone;
        public void Remove(string name) => contacts.Remove(name);
        public string Search(string name) => contacts.TryGetValue(name, out var phone) ? phone : "Not Found";
    }

}
