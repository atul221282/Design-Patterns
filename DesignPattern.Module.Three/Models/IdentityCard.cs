using DesignPattern.Module.Three.Interfaces;

namespace DesignPattern.Module.Three.Models
{
    public class IdentityCard: IUserIdentity
    {
        public string SSN { get; set; }
    }
}
