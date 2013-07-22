using System;

namespace Observer
{
    public class Client:IClient
    {
        public string Name { get; set; }

        public Client(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine("{0} received notification: {1}",Name,message);
        }
    }
}