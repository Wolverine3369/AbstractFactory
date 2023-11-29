using System;

namespace Wolverine
{
    // Abstract product interfaces
    interface ICar
    {
        void RideInWinter();
    }

    interface IMotorcycle
    {
        void RideInSummer();
    }

    // Concrete product for Modern furniture
    class Ford : ICar
    {
        public void RideInWinter()
        {
            Console.WriteLine("I am the Ford and I was produced by the Ford factory! You can ride me even in winter.");
        }
    }

    class Dodge : ICar
    {
        public void RideInWinter()
        {
            Console.WriteLine("I am the Dodge and I was produced by the Dodge factory! You can ride me even in winter.");
        }
    }

    // Concrete product for Victorian furniture
    class Harley : IMotorcycle
    {
        public void RideInSummer()
        {
            Console.WriteLine("I am the Harley and I was produced by the Harley factory! You can ride me only in summer.");
        }
    }

    class Indian : IMotorcycle
    {
        public void RideInSummer()
        {
            Console.WriteLine("I am the Indian and I was produced by the Idian factory! You can ride me only in summer.");
        }
    }

    // Abstract factory interface
    interface ICarFactory
    {
        ICar Model2022();
        ICar Model2023();
    }

    // Concrete factory for Modern furniture
    class FordFactory : ICarFactory
    {
        public ICar Model2022()
        {
            return new Ford();
        }

        public ICar Model2023()
        {
            return new Ford();
        }
    }

    // Concrete factory for Victorian furniture
    class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }

    // Client class that uses the abstract factory
    class Client
    {
        private IChair chair;
        private ISofa sofa;

        public Client(IFurnitureFactory factory)
        {
            chair = factory.CreateChair();
            sofa = factory.CreateSofa();
        }

        public void UseFurniture()
        {
            chair.SitOn();
            sofa.RelaxOn();
        }
    }

    class Program
    {
        static void Main()
        {
            // Client uses Modern furniture
            IFurnitureFactory modernFactory = new ModernFurnitureFactory();
            Client modernClient = new Client(modernFactory);
            modernClient.UseFurniture();

            // Client uses Victorian furniture
            IFurnitureFactory victorianFactory = new VictorianFurnitureFactory();
            Client victorianClient = new Client(victorianFactory);
            victorianClient.UseFurniture();
        }
    }
}