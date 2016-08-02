using System.Diagnostics.Contracts;

namespace DesignPattern.AbstractFactory.Builder.Person.Interfaces
{
    //[ContractClass(typeof(LastNameHolderContracts))]
    public interface ILastNameHolder
    {
        IPrimaryContactHolder WithLastName(string surname);
        [Pure]
        bool IsValidLastName(string surname);
    }
}