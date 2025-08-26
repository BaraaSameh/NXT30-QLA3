using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskCSADV
{
    delegate void Notify(string message);
    class Notifier
    {
        public Notify Notifications;
        public void Send(string msg) => Notifications?.Invoke(msg);
    }

}
