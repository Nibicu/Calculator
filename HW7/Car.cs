using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class Car : CarBase
    {
        public override string Diller { get; set; } 
        public override string Model { get; set; } 
        public override string Color { get; set; }
        public override decimal Price { get; set; }

        private bool autoStart;
        private bool geolocation;
        private bool cruiseСontrol;
        private bool turnOnTheDisco;


        public Car(string diller, string model, string color, decimal price)
        {
            Diller = diller;
            Model = model;
            Color = color;
            Price = price;
        }

        public override void AutoStart()
        {
            autoStart = true;
            Console.WriteLine("Автозапуск включен.");
        }
        public override void Geolocation()
        {
            geolocation = true;
            Console.WriteLine("Автозапуск включен.");
        }


        public override void CruiseСontrol()
        {
            cruiseСontrol = true;
            Console.WriteLine("Автозапуск включен.");
        }


        public override void TurnOnTheDisco()
        {
            turnOnTheDisco = true;
            Console.WriteLine("Автозапуск включен.");
        }
    }
}
