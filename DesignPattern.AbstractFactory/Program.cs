using DesignPattern.AbstractFactory.Builder.Person;
using DesignPattern.Builder.Factories.Interfaces;
using DesignPattern.Module.Model.Interfaces;
using System;
using Model = DesignPattern.Module.Model;

namespace DesignPattern.Builder
{
    class Program
    {
        static void ConfigureUser()
        {
            Model.Person person = new PersonBuilder()
                .WithFirstName("Iha")
                .WithLastName("Chaudhary")
                .WithPrimaryContact(new Model.EmailAddress("iha@iha.com"))
                .NoMoreContacts()
                .Build();


            foreach (var con in person.Contacts)
                Console.WriteLine(con.ToString());
            Console.WriteLine(person.ToString());
        }
        static void Main(string[] args)
        {
            ConfigureUser();
            Console.ReadLine();
        }
    }
}
