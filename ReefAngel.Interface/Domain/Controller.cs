using System;

namespace ReefAngel.Interface
{
    public class Controller
    {
        public Uri Uri { get; private set; }
        public string Name { get; private set; }

        public Controller(Uri uri, string name)
        {
            Uri = uri;
            Name = name;
        }
    }
}
