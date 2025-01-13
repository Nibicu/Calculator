using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class Car : CarBase
    {
        public override string Diller { get; } = "Ford";
        public override string Model { get; } = "Focus";
        public override string Color { get; } = "Red";
        public override decimal Price { get; } = 25000.00m;

        public Car(string diller, string model, string color, decimal price)
        {
            Diller = diller;
            Model = model;
            Color = color;
            Price = price;
        }

        public Car()
        {

        }
    }
}
