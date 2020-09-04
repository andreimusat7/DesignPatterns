using Singleton1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Singleton1
{
    public class SingletonDataContainer : ISingletonContainer
    {
        //1.we hid our constructor from the consumer classes by making it private
        private Dictionary<string, int> _capitals = new Dictionary<string, int>();

        private SingletonDataContainer()
        {
            Console.WriteLine("Initializing singleton object");

            var elements = File.ReadAllLines("capitals.txt");

            for (var i = 0; i < elements.Length; i += 2)
            {
                _capitals.Add(elements[i], int.Parse(elements[i + 1]));
            }
        }
        public int GetPopulation(string name)
        {
            return _capitals[name];
        }

        //Threadsafe
        //we’ve created a single instance of our class and exposed it through the Instance property.
        //modify our class to implement a thread-safe Singleton by using the Lazy type
        //It is loaded in a lazy way which means that our instance is going to be created only when it is actually needed
        private static readonly Lazy<SingletonDataContainer> instance = new Lazy<SingletonDataContainer>(() => new SingletonDataContainer());
        public static SingletonDataContainer Instance => instance.Value;
    }
}
