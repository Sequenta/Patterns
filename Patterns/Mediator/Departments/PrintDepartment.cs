using System;

namespace Mediator.Departments
{
    public class PrintDepartment:Department
    {
        public PrintDepartment(Mediator mediator) : base(mediator)
        {
        }

        public override void AcceptNotification(string message)
        {
            Console.WriteLine("Print department received colored body. Begin printing");
            SendNotification("Print is done!");
        }

        public override void SendNotification(string message)
        {
            mediator.Notify(message,this);
        }
    }
}