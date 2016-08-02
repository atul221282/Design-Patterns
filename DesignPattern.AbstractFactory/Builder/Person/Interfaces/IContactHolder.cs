using DesignPattern.Module.Model.Interfaces;
using System.Diagnostics.Contracts;

namespace DesignPattern.AbstractFactory.Builder.Person.Interfaces
{
    public interface IContactHolder
    {
        [Pure]
        bool Contains(IContactInfo contact);

        IPersonBuilder NoMoreContacts();
    }
}