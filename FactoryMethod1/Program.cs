using System;
using System.ComponentModel.Design;

namespace FactoryMethod1
{
    class Program
    {
        /// <summary>
        /// Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
        }
    }

    //defines the interface of objects the factory method creates
    abstract class Product
    { }

    //implements the Product interface
    class ConcreteProductA : Product
    { }

    class ConcreteProductB : Product
    { }

    //declares the factory method, which returns an object of type Product. Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
    //may call the factory method to create a Product object.
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    //overrides the factory method to return an instance of a ConcreteProduct.
    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
