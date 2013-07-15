using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Departments;

namespace Mediator
{
    class Program
    {
        static void Main()
        {
            var departmentMediator = new DepartmentMediator();
            var bodyDepartment = new BodyDepartment(departmentMediator);
            var colorDepartment = new ColorDepartment(departmentMediator);
            var printDepartment = new PrintDepartment(departmentMediator);

            departmentMediator.BodyDepartment = bodyDepartment;
            departmentMediator.ColorDepartment = colorDepartment;
            departmentMediator.PrintDepartment = printDepartment;

            Console.WriteLine("Body department created t-shirt body");
            bodyDepartment.SendNotification("Body is done!");

            Console.ReadKey();
        }
    }
}
