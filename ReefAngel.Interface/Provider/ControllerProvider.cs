using System;

namespace ReefAngel.Interface
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
