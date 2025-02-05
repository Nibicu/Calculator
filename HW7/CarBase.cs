﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public abstract class CarBase
    {
        public abstract string Diller { get; set; }
        public abstract string Model { get; set; }
        public abstract string Color { get; set; }
        public abstract decimal Price { get; set; }
        public void AutoStart()
        {
            Console.WriteLine("Автомобиль запущен автоматически.");
        }

        public void Geolocation()
        {
            Console.WriteLine("Геолокация: текущие координаты автомобиля.");
        }

        public void CruiseСontrol()
        {
            Console.WriteLine("Круиз-контроль активирован.");
        }

        public void TurnOnTheDisco()
        {
            Console.WriteLine("Дискотека включена! Музыка играет.");
        }
    }
}
