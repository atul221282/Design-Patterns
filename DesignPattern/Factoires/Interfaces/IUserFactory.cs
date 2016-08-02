using DesignPattern.Module.Two.Interfaces;

namespace DesignPattern.Module.Two
{
    public interface IUserFactory
    {
        IUser CreateUser(string name1, string name2);
        IUserIdentity CreateIdentity();
    }
}
