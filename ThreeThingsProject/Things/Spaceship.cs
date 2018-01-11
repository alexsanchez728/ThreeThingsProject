using System;

namespace ThreeThingsProject.Things
{
    class Spaceship
    {
        protected string _name;
        protected string _destination;
        protected bool _readyToFly;
        // ^ protected fields on a class

        public string Name
        {
            get
            {
                return $"This ship's name is: {_name}";
            }
            set
            {
                _name = value;
            }
        }
        public string Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                _destination = value;
            }
        }
        // ^ public properties that set and get the protected fields.

        public Spaceship()
        {
            Name = "Apollo 8 ";
        }
         //^ Constructor Method to set name "Apollo" on instantiation of 'Spaceship'

        public bool ReadyToFly
        {
            get
            {
                return _readyToFly;
            }
            set
            {
                if (!value)
                {
                    _readyToFly = false;
                }
                if (value)
                {
                    _readyToFly = true;
                }
            }
        }

        public string Launch(bool isReadyToFly) // <== Method to do something
        {
            if (!isReadyToFly)
            {
                Console.WriteLine("Flight Status:");
                Console.WriteLine($"Name: {_name}");
                Console.WriteLine($"Flight Ready: {_readyToFly}");
                Console.WriteLine($"Destination: {_destination}");
                Console.WriteLine("Ship is not ready to fly, and no destination passed to lauch team");

            }
            if (isReadyToFly)
            {
                Console.WriteLine("Flight Status:");
                Console.WriteLine($"Name: {_name}");
                Console.WriteLine($"Flight Ready: {_readyToFly}");
                Console.WriteLine($"Destination: {_destination}");
                Console.WriteLine("Ship is ready to fly, but no destination given");
            }
            return "Sorry";
        }

        public string Launch(bool isReadyToFly, string destination) // <== Method Overload
        {
            if (!isReadyToFly)
            {
                Console.WriteLine("Flight Status:");
                Console.WriteLine($"Name: {_name}");
                Console.WriteLine($"Flight Ready: {_readyToFly}");
                Console.WriteLine($"Destination: {_destination}");
                Console.WriteLine("Ship is not ready to fly");
            }
            Console.WriteLine("Flight Status:");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Flight Ready: {_readyToFly}");
            Console.WriteLine($"Destination: {_destination}");
            Console.WriteLine("Everything looks good. We have lift off");
            return "We have liftoff";
        }
    }
}
