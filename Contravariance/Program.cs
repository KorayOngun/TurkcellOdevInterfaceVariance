using System.Linq;

namespace Contravariance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee> {
               new Employee() {Name = "Michael"},
               new Employee() {Name = "Jeff"},
            };
            foreach (var item in employees)
            {
                Console.WriteLine(item.Name + "---" + item.age);
            }
            
            IPersonComparer<Employee> EmployeeComparer = new PersonComparer(); // IPersonComparer<in T>

            var result = EmployeeComparer.Compare(employees[0], employees[1]);
            Console.WriteLine(result);
        }
    }
}