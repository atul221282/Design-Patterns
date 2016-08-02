using DesignPattern.Module.Three.Interfaces;

namespace DesignPattern.Module.Three.Models
{
    public class MacAddress: IUserIdentity
    {
        public string NicPart { get; set; }
    }
}
