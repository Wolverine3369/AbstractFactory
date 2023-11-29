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
        public void SitOn()
        {
            Console.WriteLine("Sitting on a modern chair");
        }
    }

    class Dodge : ICar
    {
        public void RelaxOn()
        {
            Console.WriteLine("Relaxing on a modern sofa");
        }
    }

    // Concrete product for Victorian furniture
    class VictorianChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a Victorian chair");
        }
    }

    class VictorianSofa : ISofa
    {
        public void RelaxOn()
        {
            Console.WriteLine("Relaxing on a Victorian sofa");
        }
    }

    // Abstract factory interface
    interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }

    // Concrete factory for Modern furniture
    class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
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