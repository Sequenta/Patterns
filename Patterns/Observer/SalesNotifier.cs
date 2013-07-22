using System;
using System.Collections.Generic;

namespace Observer
{
    public abstract class SalesNotifier
    {
        private List<IClient> clients;
        private string message;
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                Notify();
            }
        }

        protected SalesNotifier()
        {
            clients = new List<IClient>();
        }

        public void Subscribe(IClient client)
        {
            clients.Add(client);
        }

        public void Unsubscribe(IClient client)
        {
            clients.Remove(client);
        }

        public void Notify()
        {
            var notified = 0;
            foreach (var client in clients)
            {
                client.Update(Message);
                notified += 1;
            }
            Console.WriteLine("Notified clients:{0}",notified);
        }
    }
}