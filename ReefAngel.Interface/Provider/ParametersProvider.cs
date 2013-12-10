using System;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using ReefAngel.Interface.Transformer;

namespace ReefAngel.Interface
{
    public interface IProvideParameters
    {
        Parameters Parameters { get; }
    }

    public class ParametersProvider : IProvideParameters
    {
        private readonly ITransformParameters _parameterTransformer;
        private readonly IExecuteCommands _commandExecutor;

        public ParametersProvider(ITransformParameters parameterTransformer,
                                  IExecuteCommands commandExecutor)
        {
            _parameterTransformer = parameterTransformer;
            _commandExecutor = commandExecutor;
        }

        public Parameters Parameters
        {
            get
            {
                var xmlSerializer = new XmlSerializer(typeof(RA));
                RA ra;
                var result = _commandExecutor.Execute("r99");

                using (var textReader = new StringReader(result))
                {
                    ra = (RA)xmlSerializer.Deserialize(textReader);
                }

                var parameters = _parameterTransformer.Transform(ra);

                return parameters;
            }
        }
    }
}
