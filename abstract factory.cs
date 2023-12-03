using System;

namespace Wolverine
{
    interface IConvertible
    {
        void ConvertibleModel2022();
        void ConvertibleModel2023();
    }

    interface IPickup
    {
        void PickupModel2022();
        void PickupModel2023();
    }

    class ConvertibleFord : IConvertible
    {
        public void ConvertibleModel2022()
        {
            Console.WriteLine("I am a convertible Ford model 2022 and I was produced by the Ford Factory!");
        }

        public void ConvertibleModel2023()
        {
            Console.WriteLine("I am a convertible Ford model 2023 and I was produced by the Ford Factory!");
        }
    }

    class PickupFord : IPickup
    {
        public void PickupModel2022()
        {
            Console.WriteLine("I am a pickup Ford model 2022 and I was produced by the Ford Factory!");
        }

        public void PickupModel2023()
        {
            Console.WriteLine("I am a pickup Ford model 2023 and I was produced by the Ford Factory!");
        }
    }

    class ConvertibleDodge : IConvertible
    {
        public void ConvertibleModel2022()
        {
            Console.WriteLine("I am a convertible Dodge model 2022 and I was produced by the Dodge Factory!");
        }

        public void ConvertibleModel2023()
        {
            Console.WriteLine("I am a convertible Dodge model 2023 and I was produced by the Dodge Factory!");
        }
    }

    class PickupDodge : IPickup
    {
        public void PickupModel2022()
        {
            Console.WriteLine("I am a pickup Dodge model 2022 and I was produced by the Dodge Factory!");
        }

        public void PickupModel2023()
        {
            Console.WriteLine("I am a pickup Dodge model 2023 and I was produced by the Dodge Factory!");
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

        public void ConvertibleModel2022()
        {
            convertible.ConvertibleModel2022();
        }

        public void ConvertibleModel2023()
        {
            convertible.ConvertibleModel2023();
        }

        public void PickupModel2022()
        {
            pickup.PickupModel2022();
        }

        public void PickupModel2023()
        {
            pickup.PickupModel2023();
        }
    }

    class Program
    {
        static void Main()
        {
            ICarFactory FordFactory = new FordFactory();
            Customer FordCustomer = new Customer(FordFactory);
            FordCustomer.ConvertibleModel2022();
            FordCustomer.PickupModel2023();

            ICarFactory DodgeFactory = new DodgeFactory();
            Customer DodgeCustomer = new Customer(DodgeFactory);
            DodgeCustomer.PickupModel2023();
        }
    }
}