namespace DesignPattern.Module.Model.Interfaces
{
    public interface IUser
    {
        void SetIdentity(IUserIdentity identity);
        bool CanAccpetIdentity(IUserIdentity identity);
        void Add(IContactInfo contact);
        void SetPrimaryContact(IContactInfo contact);
    }
}
