using System;
using ThreeThingsProject.Things; // Have to state "dependancies," other Classes being used in this Main

namespace ThreeThingsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Initialization
            var flower = new Flower
            {
                Name = "Cosmo",
                PetalCount = 12,
                InBloom = false
            };
            flower.Blossoming(flower.InBloom);

            // Object Initialization
            var book = new Book
            {
                Name = "Foundation and Empire",
                Pages = 275,
                IsDigital = false
            };
            book.Format(book.IsDigital); // Using non-overloaded Method

            // Object Initialization
            var spaceship = new Spaceship
            {
                Name = "Cassini", // By setting the name here, I'm writting over the inital value in Spaceship class
                Destination = "Venus",
                ReadyToFly = false
            };
            spaceship.Launch(spaceship.ReadyToFly); // Using Method
            Console.ReadLine();

            // Another Object Initialization
            var secondSpaceship = new Spaceship
            {
                // Name not set; Name will be inital value: 'Apollo 8'
                Destination = "Moon",
                ReadyToFly = true
            };
            secondSpaceship.Launch(secondSpaceship.ReadyToFly, secondSpaceship.Destination); // Using Overloaded Method
            Console.ReadLine();
        }

    }
}

