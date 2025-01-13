using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class Car : CarBase
    {
        public override string Diller { get; set; } = "Ford";
        public override string Model { get; set; } = "Focus";
        public override string Color { get; set; } = "Red";
        public override decimal Price { get; set; } = 25000.00m;

        
        public Car(string diller, string model, string color, decimal price)
        {
            Diller = diller;
            Model = model;
            Color = color;
            Price = price;
        }

        
    }
}
