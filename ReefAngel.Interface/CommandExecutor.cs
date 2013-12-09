using System;

namespace ReefAngel.Interface
{
    public interface IExecuteCommands
    {
        string Execute(string command);
    }

    public class CommandExecutor : IExecuteCommands
    {
        private IProvideController _controllerProvider;

        public CommandExecutor(IProvideController controllerProvider)
        {
            _controllerProvider = controllerProvider;
        }

        public string Execute(string command)
        {
            return _controllerProvider.Controller.Uri + "/" + command;
        }
    }
}
