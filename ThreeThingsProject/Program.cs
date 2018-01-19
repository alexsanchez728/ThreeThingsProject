using System;
using System.Collections.Generic;
using ThreeThingsProject.Things; // Have to state "dependancies," other Classes being used in this Main

namespace ThreeThingsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var flowers = new List<Flower> // List of Child instances
            {
                new Flower { Name = "Cosmo", PetalCount = 12, InBloom = false },
                new Flower { Name = "Snapdragons", PetalCount = 6, InBloom = true },
                new Flower { Name = "Lavander", PetalCount = 48, InBloom = true }
                // ^ using object initializers inside of initializing a List
            };

            var books = new List<Book>
            {
                new Book {Name = "Foundation", Pages = 250, IsDigital = false},
                new Book {Name = "Foundation and Empire", Pages = 250, IsDigital = false},
                new Book {Name = "Second Foundation", Pages = 247, IsDigital = false}
            };

            var spaceships = new List<Spaceship>
            {
                new Spaceship {Destination = "Moon", ReadyToFly = true},
                new Spaceship {Name = "Cassini", Destination = "Venus", ReadyToFly = false},
                new Spaceship {Name = "Dragon", Destination = "ISS", ReadyToFly = true}
            };

            var bikes = new List<Bike>
            {
                new Bike {Brand = "Huffy", IsOneSpeed = true},
                new Bike {Brand = "Kona", IsOneSpeed = false},
                new Bike {Brand = "Pure Fix", IsOneSpeed = true}
            };

            foreach (var spaceship in spaceships)
            {
                spaceship.Launch(spaceship.ReadyToFly, spaceship.Destination);
            }

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Name} has {book.Pages} pages and is " + $"{(book.IsDigital ? "an eBook." : "a physical book.")}");
            }

            foreach (var flower in flowers)
            {
                Console.WriteLine($"{flower.Name} has {flower.PetalCount} petals and is " + $"{(flower.InBloom ? "in bloom yay!" : "not in bloom, boo.")}");
            }

            foreach (var bike in bikes)
            {
                if (bike.IsOneSpeed)
                {
                    Console.WriteLine(bike.CoolerThanOthers(bike.IsOneSpeed));
                    continue;
                }
                Console.WriteLine($"Cool {bike.Brand} dude.");
            }

            Console.ReadLine();
        }
    }
}

