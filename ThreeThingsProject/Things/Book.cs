using System;

namespace ThreeThingsProject.Things
{
    class Book
    {
        protected string _name;
        protected int _pages;
        protected bool _isDigital;
        protected string _bookFormat;

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
        public int Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                _pages = value;
            }
        }

        public bool IsDigital { get; set; }
        public string BookFormat { get; set; }

        public Book()
        {
            _name = "War & Peace";
            _bookFormat = "paperback";
        }
        public bool Format(bool isDigital)
        {
            Console.WriteLine($"{_name}, good book");
            if (isDigital)
            {
                _isDigital = true;
                return true;
            }
            _isDigital = false;
            return false;
        }
        public bool Format(bool isDigital, string BookFormat)
        {
            Console.WriteLine($"{_name}, good book");
            if (BookFormat == "pdf" || BookFormat == "ebook")
            {
                _isDigital = true;
                _bookFormat = BookFormat;
            }
            _isDigital = false;
            return true;
        }
    }
}
