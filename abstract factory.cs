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

    class ConvertibleFord : IConvertible
    {
        public void Convertible()
        {
            Console.WriteLine("I am a convertible Ford and I was produced by the Ford Factory!");
        }
    }

    class PickupFord : IPickup
    {
        public void Pickup()
        {
            Console.WriteLine("I am a pickup Ford and I was produced by the Ford Factory!");
        }
    }

    class ConvertibleDodge : IConvertible
    {
        public void Convertible()
        {
            Console.WriteLine("I am a convertible Dodge and I was produced by the Dodge Factory!");
        }
    }

    class PickupDodge : IPickup
    {
        public void Pickup()
        {
            Console.WriteLine("I am a pickup Dodge and I was produced by the Dodge Factory!");
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

    class Customer
    {
        private IConvertible convertible;
        private IPickup pickup;

        public Customer(ICarFactory factory)
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
            Customer FordClient = new Customer(FordFactory);
            FordClient.UseCar();

            ICarFactory DodgeFactory = new DodgeFactory();
            Customer DodgeClient = new Customer(DodgeFactory);
            DodgeClient.UseCar();
        }
    }
}