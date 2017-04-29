using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.Models
{
    interface IPassengerPlane
    {
        string AirlineName { set; get; }
        int SeatsCount { set; get; }
    }
}
