namespace Mediator.Departments
{
    public abstract class Department
    {
        protected Mediator mediator;

        protected Department(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void AcceptNotification(string message);
        public abstract void SendNotification(string message);
    }
}