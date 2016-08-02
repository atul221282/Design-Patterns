namespace DesignPattern.Module.Three.Interfaces
{
    public interface IUser: ITicketHolder
    {
        void SetIdentity(IUserIdentity identity);
    }
}
