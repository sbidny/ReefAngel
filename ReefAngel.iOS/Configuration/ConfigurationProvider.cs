using ReefAngel.Configuration;
using System.IO.IsolatedStorage;
using System.Xml.Serialization;
using System.Linq;
using Config = ReefAngel.Configuration.Domain.Configuration;

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
                    var serializer = new XmlSerializer(typeof(Config));
                    var configuration = (Config) serializer.Deserialize(stream);
                    return configuration.properties.First(x => x.Key.Equals(key)).Value;
                }
            }
        }
    }
}
