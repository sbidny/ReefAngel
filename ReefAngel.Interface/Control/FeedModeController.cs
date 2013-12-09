using System;

namespace ReefAngel.Interface
{
    public interface IControlFeedMode
    {
        void Run();
    }

    public class FeedModeController : IControlFeedMode
    {
        private readonly IExecuteCommands _commandExecutor;

        public FeedModeController(IExecuteCommands commandExecutor)
        {
            _commandExecutor = commandExecutor;
        }

        public void Run()
        {
            _commandExecutor.Execute("/mf");
        }
    }
}
