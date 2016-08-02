using DesignPattern.Module.Two.Interfaces;

namespace DesignPattern.Module.Two.Models
{
    public class MacAddress: IUserIdentity
    {
        public string RawAddress { get; set; }
    }
}
