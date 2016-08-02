using DesignPattern.Module.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.Factories.Interfaces
{
    public interface IUserfactory
    {
        IUser CreateUser();
        IUserIdentity CreateIdentity();
    }
}
