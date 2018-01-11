using System;

namespace ThreeThingsProject.Things
{
    class Flower
    {
        protected string _name;
        protected int _petalCount;
        protected bool _inBloom;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int PetalCount
        {
            get
            {
                return _petalCount;
            }
            set
            {
                _petalCount = value;
            }
        }
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
                Console.WriteLine($"{_name} is not in bloom. Must not be spring.");
                return "Too cold";
            }
            Console.WriteLine($"{_name} is in bloom! It must be spring.");
            return "yay";
        }
    }
}
