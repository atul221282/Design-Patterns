
using DesignPattern.Module.Two.Interfaces;
using DesignPattern.Module.Two.Models;

namespace DesignPattern.Module.Two.Factories.PersonFactory
{
    public class PersonFactory : IUserFactory
    {
        public IUser CreateUser(string name1, string name2)
        {
            return new Person(name1, name2);
        }

        public IUserIdentity CreateIdentity()
        {
            
            return new IdentityCard();
        }
    }
}
