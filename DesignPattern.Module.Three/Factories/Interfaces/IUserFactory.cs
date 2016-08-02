using DesignPattern.Module.Three.Interfaces;

namespace DesignPattern.Module.Three.Factories.Interfaces
{
    public interface IUserFactory
    {
        IUser CreateUser(string name1, string name2);
        IUserIdentity CreateIdentity();
    }
}
