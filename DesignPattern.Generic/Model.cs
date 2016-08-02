using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Generic
{
    public interface IEntity
    {
        bool IsValid();
    }
    public class InternalPerson
    {
        public string Name { get; set; }
    }
    public class Employee : InternalPerson, IEntity
    {
        public int Id { get; set; }
        public virtual void DoWork()
        {
            Console.WriteLine("Doing real work");
        }

        public bool IsValid()
        {
            return true;
        }

        public void Speak<T>()
        {
            Console.Write(typeof(T).Name);
        }
    }
    public class Manager : Employee
    {
        public override void DoWork()
        {
            Console.WriteLine("Create some meeting");
        }


    }
}
