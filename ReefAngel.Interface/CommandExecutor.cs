using System;
using System.Net.Http;
using ReefAngel.Interface.Provider;

namespace ReefAngel.Interface
{
    public interface IExecuteCommands
    {
        string Execute(string command);
    }

    internal class CommandExecutor : IExecuteCommands
    {
        private IProvideController _controllerProvider;

        public CommandExecutor(IProvideController controllerProvider)
        {
            _controllerProvider = controllerProvider;
        }

        public string Execute(string command)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = _controllerProvider.Controller.Uri;
            var response = httpClient.GetAsync(command).Result;
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
