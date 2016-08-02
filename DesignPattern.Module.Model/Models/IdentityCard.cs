using DesignPattern.Module.Model.Interfaces;

namespace DesignPattern.Module.Model
{
    public class IdentityCard: IUserIdentity
    {
        public string SSN { get; set; }
    }
}
