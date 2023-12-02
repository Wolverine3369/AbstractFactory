using System;

namespace Wolverine
{
    interface IConvertible
    {
        void Convertible();
    }

    interface IPickup
    {
        void Pickup();
    }

    class Convertible : IConvertible
    {
        public void Convertible()
        {
            Console.WriteLine("I am a convertible! You can ride me only in summer.");
        }
    }

    class Pickup : IPickup
    {
        public void Pickup()
        {
            Console.WriteLine("I am a pickup! You can ride me even in winter.");
        }
    }

    class Dodge : IConvertible
    {
        public void Convertible()
        {
            Console.WriteLine("I am a convertible! You can ride me only in summer.");
        }
    }

    class Ford : IPickup
    {
        public void Pickup()
        {
            Console.WriteLine("I am a pickup! You can ride me even in winter.");
        }
    }

    interface ICarFactory
    {
        IConvertible Convertible();
        IPickup Pickup();
    }

    class FordFactory : ICarFactory
    {
        public IConvertible Convertible()
        {
            return new Ford();
        }

        public IPickup Pickup()
        {
            return new Ford();
        }
    }

    class DodgeFactory : ICarFactory
    {
        public IConvertible Convertible()
        {
            return new Dodge();
        }

        public IPickup Pickup()
        {
            return new Dodge();
        }
    }

    class Client
    {
        private IConvertible convertible;
        private IPickup pickup;

        public Client(ICarFactory factory)
        {
            convertible = factory.Convertible();
            pickup = factory.Pickup();
        }

        public void UseCar()
        {
            convertible.Convertible();
            pickup.Pickup();
        }
    }

    class Program
    {
        static void Main()
        {
            ICarFactory FordFactory = new FordFactory();
            Client FordClient = new Client(FordFactory);
            FordClient.UseCar();

            //IFurnitureFactory victorianFactory = new VictorianFurnitureFactory();
            //Client victorianClient = new Client(victorianFactory);
            //victorianClient.UseFurniture();
        }
    }
}