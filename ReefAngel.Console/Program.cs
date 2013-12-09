using System;
using ReefAngel.Interface;
using ReefAngel;

namespace ReefAngel.Console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var parameterTransformer = new ParametersTransformer();
            var parametersProvider = new ParametersProvider(parameterTransformer);
            var tmp = parametersProvider.Parameters;
            System.Console.WriteLine(tmp.Temperature1);
        }
    }
}
