using DesignPattern.Module.Three.Factories.Interfaces;
using DesignPattern.Module.Three.Factories.Person;
using DesignPattern.Module.Three.Interfaces;
using DesignPattern.Module.Three.Models;

namespace DesignPattern.Module.Three
{
    class Program
    {

        static void RegisterUser(IUserFactory userFactory)
        {
            IUser user = userFactory.CreateUser("Max", "Planck");
            IUserIdentity id = userFactory.CreateIdentity();
            user.SetIdentity(id);
        }

        static void Main(string[] args)
        {
            RegisterUser(new PersonFactory());
        }
    }
}
