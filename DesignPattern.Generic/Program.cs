using DesignPattern.Module.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //SomeGenericStuff();
            Database.SetInitializer(new DropCreateDatabaseAlways<EmployeeDb>());
            using (IRepository<Employee> employeeRepository = new SqlRepository<Employee>(new EmployeeDb()))
            {
                AddEmployee(employeeRepository);
                AddManagers(employeeRepository);//Contravariance
                CountEmployees(employeeRepository);
                QueryEmployees(employeeRepository);
                DumpPeople(employeeRepository);//Covariance

                Console.ReadLine();
            }
        }

        private static void AddManagers(IWriteOnlyRepository<Manager> employeeRepository)
        {
            employeeRepository.Add(new Manager { Name = "Bani" });
            employeeRepository.Add(new Manager { Name = "Iha" });
            employeeRepository.Commit();
        }

        private static void DumpPeople(IReadOnlyRepository<InternalPerson> employeeRepository)
        {
            var employees = employeeRepository.FindAll();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
        }

        private static void QueryEmployees(IRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.FindById(1);
            Console.WriteLine(employee.Name);
        }

        private static void CountEmployees(IRepository<Employee> employeeRepository)
        {
            Console.WriteLine(employeeRepository.FindAll().Count());
        }

        private static void AddEmployee(IRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { Name = "Scott" });
            employeeRepository.Add(new Employee { Name = "Atul" });
            employeeRepository.Add(new Employee { Name = "Kapil" });
            employeeRepository.Commit();
        }

        private static void SomeGenericStuff()
        {
            Action<double> print = x => Console.WriteLine(x);
            Func<double, double> square = (x) => x * x;
            Predicate<double> IsLessThanTen = x => x < 10;


            //Console.WriteLine(IsLessThanTen(9.9));
            print(square(3));
            print(1.2);
            var personName = new Person[] {new Person("12", "21"),
                new Person("112", "231"),
                new Person("412", "261")
            }.Select(x => double.Parse(x.Name)).Map(x => new DateTime(2010, 1, 1).AddDays(x));

            var employee = new Employee();
            var employeeType = employee.GetType();
            employeeType.GetConstructors()
                .OrderByDescending(x => x.GetParameters()
                .Count())
                .First()
                .GetParameters();

            var methodInfo = employeeType.GetMethod("Speak");
            methodInfo = methodInfo.MakeGenericMethod(typeof(DateTime));
            methodInfo.Invoke(employee, null);

            //Console.ReadLine();

            Console.Clear();

            var pp = new TypeWithAbstract();
            Console.ReadLine();
            var enumTest = new TypeWithEnum();
            Console.ReadLine();
        }
    }
}
