using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.Models
{
    class PassengerPlane : Plane, IPassengerPlane
    {
        public string AirlineName { set; get; }
        public int SeatsCount { set; get; }
        public override string ToString()
        {
            return base.ToString() + $"Type : Pessenger Plane; Airline Name : {AirlineName};";
        }
    }
}
