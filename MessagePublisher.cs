using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class MessagePublisher
    {
        public event Action<string> SendMessage;

        public void Send(string message)
        {
            SendMessage?.Invoke(message);
        }
    }
}
