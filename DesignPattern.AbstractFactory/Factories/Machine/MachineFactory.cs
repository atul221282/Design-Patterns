using DesignPattern.Builder.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Module.Model.Interfaces;
using Model = DesignPattern.Module.Model;

namespace DesignPattern.Builder.Factories.Machine
{
    public class MachineFactory : IUserfactory
    {
        public IUserIdentity CreateIdentity()
        {
            return new Model.MacAddress();
        }

        public IUser CreateUser()
        {
            return new Model.Machine();
        }
    }
}
