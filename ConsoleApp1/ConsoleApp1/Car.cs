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

        private static int count = 0;

        public Car(string color)
        {
            Color = color;
            count++;
        }

        public Car() => count++;

        public override void Ride() => Console.WriteLine("wrooom!");

        public void Steer() => Console.WriteLine("turn right");
    }
}
