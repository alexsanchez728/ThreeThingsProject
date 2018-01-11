using System;
using ThreeThingsProject.Things;

namespace ThreeThingsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var flower = new Flower
            {
                Name = "Cosmo",
                PetalCount = 12,
                InBloom = false
            };
            flower.Blossoming(flower.InBloom);




            // Object Initialization
            var spaceship = new Spaceship
            {
                Name = "Cassini",
                Destination = "Venus",
                ReadyToFly = false
            };
            spaceship.Launch(spaceship.ReadyToFly); // Using Method
            Console.ReadLine();

            // Another Object Initialization
            var secondSpaceship = new Spaceship
            {
                // Name not set; wanted to use the inital value 'Apollo 8' in this case
                Destination = "Moon",
                ReadyToFly = true
            };
            secondSpaceship.Launch(secondSpaceship.ReadyToFly, secondSpaceship.Destination); // Using Overloaded Method
            Console.ReadLine();
        }

    }
}

