using System;

namespace Wolverine
{
    interface IConvertible
    {
        void RideConvertible();
    }

    interface IPickup
    {
        void RidePickup();
    }

    class ConvertibleCar : IConvertible
    {
        public void RideConvertible()
        {
            Console.WriteLine("I am a convertible! You can ride me only in summer.");
        }
    }

    class PickupCar : IPickup
    {
        public void RidePickup()
        {
            Console.WriteLine("I am a pickup! You can ride me even in winter.");
        }
    }

    class Dodge : IConvertible
    {
        public void DodgeCar()
        {
            Console.WriteLine("I am the Dodge and I was produces be the Dodge factory!.");
        }
    }

    class Ford : IConvertible
    {
        public void FordCar()
        {
            Console.WriteLine("I am the Ford and I was produces be the Ford factory!.");
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
            convertible.RideConvertible();
            pickup.RidePickup();
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