using System;
using ReefAngel.Interface.Transformer;

namespace ReefAngel.Interface
{
    public interface ICreateReefAngelClient
    {
        IProvideReefAngelClient CreateReefAngelClient(Uri uri, string name);
    }

    public class ReefAngelClientFactory : ICreateReefAngelClient
    {
        public IProvideReefAngelClient CreateReefAngelClient(Uri uri, string name)
        {
            return new ReefAngelClient(uri, name);
        }
    }

    public interface IProvideReefAngelClient
    {
        IControlWaterChangeMode WaterChangeModeController { get; }
        IControlFeedMode FeedModeController { get; }
        IProvideParameters ParametersProvider { get; }
        IProvideController ControllerProvider { get; }
    }

    internal class ReefAngelClient : IProvideReefAngelClient
    {
        public IControlWaterChangeMode WaterChangeModeController { get; private set; }
        public IControlFeedMode FeedModeController { get; private set; }
        public IProvideParameters ParametersProvider { get; private set; }
        public IProvideController ControllerProvider { get; private set; }

        public ReefAngelClient(Uri uri, string name)
        {
            var parameterTransformer = new ParametersTransformer();
            var controller = new Controller(uri, name);
            ControllerProvider = new ControllerProvider(controller);
            var commandExecutor = new CommandExecutor(ControllerProvider);
            WaterChangeModeController = new WaterChangeModeController(commandExecutor);
            FeedModeController = new FeedModeController(commandExecutor);
            ParametersProvider = new ParametersProvider(parameterTransformer, commandExecutor);
        }
    }
}
