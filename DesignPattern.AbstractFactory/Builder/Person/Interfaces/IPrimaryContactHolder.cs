using DesignPattern.Module.Model.Interfaces;
using System.Diagnostics.Contracts;

namespace DesignPattern.AbstractFactory.Builder.Person.Interfaces
{
    //[ContractClass(typeof(PrimaryContactHolderContracts))]
    public interface IPrimaryContactHolder : IContactHolder
    {
        IContactHolder WithPrimaryContact(IContactInfo contact);
    }
}