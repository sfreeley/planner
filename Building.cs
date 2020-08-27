using System;

namespace Planner
{
    public class Building
    {
        //private fields
        private string _designer;
        private DateTime _dateConstructed;

        private string _address;

        private string _owner;

        //public properties
        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        //if only use get, will know it is readonly property
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        //constructor = special method in a class that is called when an instance of the class is created; initializes the fields in that class
        //this constructor will accept single string parameter (address) so when the instance of new Building is created, we can pass it in
        public Building(string address)
        {
            _address = address;
        }

        //methods 
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string personName)
        {
            _owner = personName;
        }

        public void Design(string designerName)
        {
            _designer = designerName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(_address);
            Console.WriteLine("---------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");

        }

    }
}