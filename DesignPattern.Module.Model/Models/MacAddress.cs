using DesignPattern.Module.Model.Interfaces;

namespace DesignPattern.Module.Model
{
    public class MacAddress : IUserIdentity
    {
        public string NicPart { get; set; }

        public string RawAddress { get; set; }
    }
}
