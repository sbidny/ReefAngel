using System;

namespace ReefAngel.Interface.Control
{
    public interface IControlFeedMode
    {
        void Run();
    }

    internal class FeedModeController : IControlFeedMode
    {
        private readonly IExecuteCommands _commandExecutor;

        public FeedModeController(IExecuteCommands commandExecutor)
        {
            _commandExecutor = commandExecutor;
        }

        public void Run()
        {
            _commandExecutor.Execute("mf");
        }
    }
}
