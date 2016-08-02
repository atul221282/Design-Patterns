namespace DesignPattern.Module.Two.Interfaces
{

    public interface ITicketHolder
    {
    }

    public interface IUser: ITicketHolder
    {
        void SetIdentity(IUserIdentity identity);
    }
}
