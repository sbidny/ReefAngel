namespace ReefAngel.Configuration
{
    public interface IProvideConfiguration
    {
        string Get(string key);
    }
}
