using Models = DesignPattern.Module.Model;

namespace DesignPattern.AbstractFactory.Builder.Person.Interfaces
{
    public interface IPersonBuilder
    {
        Models.Person Build();
    }
}