using System;

namespace Singleton1
{
    class Program
    {
        //The Singleton is a creational design pattern that allows us to create a single instance of an object and to share that instance with all the users that require it.
        //There is a common opinion that the Singleton pattern is not recommended because it presents a code smell, but there are some cases where it fits perfectly.

        /// <summary>
        /// For example, some components have no reason to be instanced more than once in a project. Take a logger for example. 
        /// It is quite common to register logger class as a singleton component because all we have to do is to provide a string to be logged and the logger is going to write it to the file. 
        /// Then multiple classes may require to write in the same file at the same time from different threads, so having one centralized place for that purpose is always a good solution.
        /// 
        /// Or maybe sometimes we have a task to read some data from a file and use them through our project. 
        /// If we know for sure that file won’t change while we read it, we can create a single instance of the object which will read that file and share it through the project to the consumer classes.
        /// 
        /// Singleton class is going to be a thread-safe which is a crucial requirement when implementing a Singleton pattern.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void Main(string[] args)
        {
            //we can call the Instance property as many times as we want, but our object is going to be instantiated only once and shared for every other call
            var db = SingletonDataContainer.Instance;
            var db2 = SingletonDataContainer.Instance;
            var db3 = SingletonDataContainer.Instance;
            var db4 = SingletonDataContainer.Instance;
        }
    }
}
