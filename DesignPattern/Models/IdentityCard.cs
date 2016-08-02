using DesignPattern.Module.Two.Interfaces;

namespace DesignPattern.Module.Two.Models
{
    public class IdentityCard: IUserIdentity
    {
        public string SSN { get; set; }
    }
}
