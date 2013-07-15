using Mediator.Departments;

namespace Mediator
{
    public abstract class Mediator
    {
        public abstract void Notify(string message, Department department);
    }
}