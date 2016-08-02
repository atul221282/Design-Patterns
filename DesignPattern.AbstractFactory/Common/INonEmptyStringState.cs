namespace DesignPattern.AbstractFactory.Common
{
    public interface INonEmptyStringState
    {
        INonEmptyStringState Set(string value);
        string Get();
    }
}
