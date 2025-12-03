using System;

namespace Adapter
{
    public class Donkey
    {
        private string _name;

        public Donkey(string name)
        {
            _name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"Осёл '{_name}' кушает");
        }

        public string GetName()
        {
            return _name;
        }
    }
}

