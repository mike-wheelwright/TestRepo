using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mainline
{
    class Car : Vehicle, ISteerable
    {
        private string color;

        public string Color { get; set; }

        public Car(string color) => Color = color;

        public Car() { }

        public override void Ride() => Console.WriteLine("wrooom!");

        public void Steer() => Console.WriteLine("turn right");
    }
}
