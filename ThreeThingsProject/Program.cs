using System;
using ThreeThingsProject.Things;

namespace ThreeThingsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var spaceship = new Spaceship
            {
                Name = "Cassini",
                Destination = "Venus",
                ReadyToFly = false
            };
            spaceship.Launch(spaceship.ReadyToFly);
            Console.ReadLine();

            var secondSpaceship = new Spaceship
            {
                Destination = "Moon",
                ReadyToFly = true
            };
            secondSpaceship.Launch(secondSpaceship.ReadyToFly, secondSpaceship.Destination);
            Console.ReadLine();
        }

    }
}

