using System;
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
        public abstract void AutoStart();


        public abstract void Geolocation();


        public abstract void CruiseСontrol();


        public abstract void TurnOnTheDisco();
        
    }
}
