namespace Mediator.Departments
{
    public class BodyDepartment:Department
    {
        public BodyDepartment(Mediator mediator) : base(mediator)
        {
        }

        public override void AcceptNotification(string message)
        {
            
        }

        public override void SendNotification(string message)
        {
            mediator.Notify(message,this);
        }
    }
}