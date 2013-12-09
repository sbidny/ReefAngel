using System;
using System.Net;
using System.Xml.Serialization;
using System.IO;

namespace ReefAngel.Interface
{
    public interface IProvideParameters
    {
        Parameters Parameters { get; }
    }

    public class ParametersProvider
    {
        private readonly ITransformParameters _parameterTransformer;
        private readonly Uri _uri;
        private readonly WebClient _webClient;

        public ParametersProvider(ITransformParameters parameterTransformer)
        {
            _parameterTransformer = parameterTransformer;
            _webClient = new WebClient();
            _uri = new Uri("http://reefangel.sbidny.com:2000/r99");

        }

        public Parameters Parameters
        {
            get
            {
                var download = _webClient.DownloadString(_uri);
                var xmlSerializer = new XmlSerializer(typeof(RA));
                RA ra;

                using (var textReader = new StringReader(download))
                {

                    ra = (RA)xmlSerializer.Deserialize(textReader);
                }

                var parameters = _parameterTransformer.Transform(ra);

                return parameters;
            }
        }
    }
}
