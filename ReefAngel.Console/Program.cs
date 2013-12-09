using System;
using ReefAngel.Interface;
using ReefAngel;

namespace ReefAngel.Console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var reefAngelClientFactory = new ReefAngelClientFactory();
            var uri = new Uri("");
            var reefAngelClient = reefAngelClientFactory.CreateReefAngelClient(uri, "test");
            System.Console.WriteLine(reefAngelClient.ParametersProvider.Parameters.Temperature1);
        }
    }
}
