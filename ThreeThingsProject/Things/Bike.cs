using System;
using System.Collections.Generic;

namespace ThreeThingsProject.Things
{
    class Bike
    {
        public string Brand { get; set; }
        public bool IsOneSpeed { get; set; }

        public string CoolerThanOthers(bool isCool)
        {
            return isCool
                ? $"A {Brand} is still just a bike, get over yourself you're not cool."
                : "Good, you know you're not cool, now I don't have to say it.";
        }
    }
}
