using System;

namespace ReefAngel.Interface
{
    public interface IProvideController
    {
        Controller Controller { get; }
    }

    public class ControllerProvider : IProvideController
    {
        public Controller Controller { get; private set; }

        public ControllerProvider(Controller controller)
        {
            Controller = controller;
        }
    }
}
