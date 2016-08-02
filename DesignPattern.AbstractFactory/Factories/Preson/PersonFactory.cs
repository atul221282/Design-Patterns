using DesignPattern.Builder.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Module.Model.Interfaces;
using DesignPattern.Module.Model;

namespace DesignPattern.Builder.Factories.Preson
{
    public class PersonFactory : IUserfactory
    {
        public IUserIdentity CreateIdentity()
        {
            return new IdentityCard();
        }

        public IUser CreateUser()
        {
            return new Person();
        }
    }
}
