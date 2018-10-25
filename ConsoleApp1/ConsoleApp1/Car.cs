using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car : Vehicle
    {
        private string color;

        public string Color { get; set; }

        public Car(string color) => Color = color;

        public Car() { }

        public override void Ride() => Console.WriteLine("wrooom!");


    }
}
