using System.Diagnostics.Contracts;
using DesignPattern.Module.Model.Interfaces;

namespace DesignPattern.AbstractFactory.Builder.Person.Interfaces
{
    //[ContractClass(typeof(SecondaryContactHolderContracts))]
    public interface ISecondaryContactHolder : IContactHolder
    {
        ISecondaryContactHolder WithSecondaryContact(IContactInfo contact);
        IPersonBuilder AndNoMoreContacts();
    }
}