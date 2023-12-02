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

    class ConvertibleDodge : IConvertible
    {
        public void RideConvertible()
        {
            Console.WriteLine("I am a convertible! You can ride me only in summer.");
        }
    }

    class PickupDodge : IPickup
    {
        public void RidePickup()
        {
            Console.WriteLine("I am a pickup! You can ride me even in winter.");
        }
    }

    class ConvertibleFord : IConvertible
    {
        public void RideConvertible()
        {
            Console.WriteLine("I am a convertible! You can ride me only in summer.");
        }
    }

    class PickupFord : IPickup
    {
        public void RidePickup()
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
            return new ConvertibleFord();
        }

        public IPickup Pickup()
        {
            return new PickupFord();
        }
    }

    class DodgeFactory : ICarFactory
    {
        public IConvertible Convertible()
        {
            return new ConvertibleDodge();
        }

        public IPickup Pickup()
        {
            return new PickupDodge();
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