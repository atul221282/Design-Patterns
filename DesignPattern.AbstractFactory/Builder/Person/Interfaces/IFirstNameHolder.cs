using System.Diagnostics.Contracts;

namespace DesignPattern.AbstractFactory.Builder.Person.Interfaces
{
    //[ContractClass(typeof(FirstNameHolderContracts))]
    public interface IFirstNameHolder
    {
        ILastNameHolder WithFirstName(string name);
        [Pure]
        bool IsValidFirstName(string name);
    }
}
