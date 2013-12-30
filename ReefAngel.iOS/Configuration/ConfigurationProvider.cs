using ReefAngel.Configuration;
using System.IO.IsolatedStorage;

namespace ReefAngel.iOS.Configuration
{
    public class ConfigurationProvider : IProvideConfiguration
    {
        public string Get(string key)
        {
            using (var store = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (var stream = new IsolatedStorageFileStream("config.xml", System.IO.FileMode.Create, store))
                {

                }
            }

            return "";
        }
    }
}
