using System;

namespace ReefAngel.Interface
{
    public interface IProvideController
    {
        Controller Controller { get; }
    }

    public class ControllerProvider
    {

        public ControllerProvider()
        {
        }
    }
}
