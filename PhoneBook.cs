using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskCSADV
{
    internal class PhoneBook
    {
        Dictionary<string,string> phone=new Dictionary<string,string>();
        public string this[string name]
        {
            get => phone.ContainsKey(name) ? phone[name].ToString() : "Not found";
            set => phone[name] = value;
        }
    }
}
