using System;
namespace assessment1

{

    class Car {

        private string _colour;
        private string _make;
        private string _gearbox;



        public string GetColour() {
            return _colour;

        }
        public void SetColour(string colour) {
            _colour = colour;

        }
        public string GetMake() {
            return _make;

        }
        public void SetMake(string make) {
            _make = make;

        }
        public string GetGearbox() {
            return _gearbox;

        }
        public void SetGearbox(string gearbox) {
            _gearbox = gearbox;

        }
        public string DescribeCar() {
            return $"This car is a {GetMake()} and is {GetColour()}, the transmission is a {GetGearbox()}.";

        }

    }

    class Program

    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter new car details below:");
            Console.Write("Colour: ");
            var colour = Console.ReadLine();
            Console.Write("Make: ");
            var make = Console.ReadLine();
            Console.Write("Gearbox: ");
            var gearbox = Console.ReadLine();
            Console.WriteLine();

            var car1 = new Car();
            car1.SetMake(make);
            car1.SetColour(colour);
            car1.SetGearbox(gearbox);

            Console.WriteLine(car1.DescribeCar());
            Console.ReadKey();

        }

    }

}