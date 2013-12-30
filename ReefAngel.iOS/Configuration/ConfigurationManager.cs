using ReefAngel.Configuration;
using System.IO.IsolatedStorage;

namespace ReefAngel.iOS.Configuration
{
    public class ConfigurationManager : IManageConfiguration
    {
        public void Set(string key, string value)
        {
            using (var store = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (var stream = new IsolatedStorageFileStream("config.xml", System.IO.FileMode.Create, store))
                {

                }
            }
        }
    }
}
