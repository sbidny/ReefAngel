using ReefAngel.Interface.Domain;

namespace ReefAngel.Interface.Provider
{
    public interface IProvideController
    {
        Controller Controller { get; }
    }

    internal class ControllerProvider : IProvideController
    {
        public Controller Controller { get; private set; }

        public ControllerProvider(Controller controller)
        {
            Controller = controller;
        }
    }
}
