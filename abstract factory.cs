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
    
    class Program
    {
        static void Main()
        {
            ICarFactory DodgeFactory = new DodgeFactory();
            IConvertible Dodge = DodgeFactory.Convertible();
            Dodge.Convertible();
        }
    }
}