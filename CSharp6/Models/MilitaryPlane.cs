using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.Models
{
    class MilitaryPlane:Plane,IMilitaryPlane
    {
        public int Capacity { get; set; }
        public List<string> CrewMembers { set; get; }
        public override string ToString()
        {
            return base.ToString()+$"Type Military Plane Capacity {Capacity}";
        }
    }
}
