using DesignPattern.Module.Two;
using DesignPattern.Module.Two.Factories.PersonFactory;
using DesignPattern.Module.Two.Interfaces;
using DesignPattern.Module.Two.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void RegisterUser(IUserFactory userFactory)
        {
            IUser user = userFactory.CreateUser("Max", "Planck");
            
            Console.WriteLine("Hello {0}, welcome back!", user);
        }

        static void Main(string[] args)
        {
            var machineFact = new Dictionary<string, Producer>();
            machineFact.Add("Max", new Producer { Name = "Atul" });
            RegisterUser(new MachineFactory(machineFact));

            RegisterUser(new PersonFactory());

            Console.ReadLine();
        }
    }
}
