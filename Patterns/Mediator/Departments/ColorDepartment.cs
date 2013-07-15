using System;

namespace Mediator.Departments
{
    public class ColorDepartment:Department
    {
        public ColorDepartment(Mediator mediator) : base(mediator)
        {
        }

        public override void AcceptNotification(string message)
        {
            Console.WriteLine("Color department received body. Begin coloring");
            SendNotification("Color is done!");
        }

        public override void SendNotification(string message)
        {
            mediator.Notify(message,this);
        }
    }
}