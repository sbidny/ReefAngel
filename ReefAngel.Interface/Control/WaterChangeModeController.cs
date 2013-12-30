using System;

namespace ReefAngel.Interface.Control
{
    public interface IControlWaterChangeMode
    {
        void Run();
    }

    internal class WaterChangeModeController : IControlWaterChangeMode
    {
        private readonly IExecuteCommands _commandExecutor;

        public WaterChangeModeController(IExecuteCommands commandExecutor)
        {
            _commandExecutor = commandExecutor;
        }

        public void Run()
        {
            _commandExecutor.Execute("mw");
        }
    }
}
