using System;
using Mediator.Departments;

namespace Mediator
{
    public class DepartmentMediator:Mediator
    {
        private BodyDepartment bodyDepartment;
        private ColorDepartment colorDepartment;
        private PrintDepartment printDepartment;

        public BodyDepartment BodyDepartment
        {
            set { bodyDepartment = value; }
        }

        public ColorDepartment ColorDepartment
        {
            set { colorDepartment = value; }
        }

        public PrintDepartment PrintDepartment
        {
            set { printDepartment = value; }
        }

        public override void Notify(string message, Department department)
        {
            if (department == bodyDepartment)
            {
                colorDepartment.AcceptNotification(message);
            }

            if (department == colorDepartment)
            {
                printDepartment.AcceptNotification(message);
            }

            if (department == printDepartment)
            {
                Console.WriteLine(message);
            }
        }
    }
}