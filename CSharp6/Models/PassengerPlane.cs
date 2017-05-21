using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharp6.Models
{
    [Serializable]
    [XmlType("PassengerPlane")]
    public class PassengerPlane : Plane, IPassengerPlane
    {
        public PassengerPlane()
        {

        }
        public string AirlineName { set; get; }
        public int SeatsCount { set; get; }
        public override string ToString()
        {
            return base.ToString() + $"Type : Pessenger Plane; Airline Name : {AirlineName};";
        }
    }
}
