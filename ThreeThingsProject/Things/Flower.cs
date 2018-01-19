using System;

namespace ThreeThingsProject.Things
{
    class Flower
    {
        protected bool _inBloom;

        public string Name { get; set; }
        public int PetalCount { get; set; }
        public bool InBloom
        {
            get
            {
                return _inBloom;
            }
            set
            {
                if (value)
                {
                    _inBloom = true;
                }
                if (!value)
                {
                    _inBloom = false;
                }
            }
        }
        public Flower()
        {
            Name = "Daisy";
        }
        public string Blossoming(bool Inbloom)
        {
            if (!Inbloom)
            {
                Console.WriteLine($"{Name} is not in bloom. Must not be spring.");
                return "Too cold";
            }
            Console.WriteLine($"{Name} is in bloom! It must be spring.");
            return "yay";
        }
    }
}
