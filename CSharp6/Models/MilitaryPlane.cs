using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharp6.Models
{
    [Serializable]
    public class MilitaryPlane:Plane,IMilitaryPlane
    {
        public MilitaryPlane() { }
        public int Capacity { get; set; }
        [XmlArray("crewmembers")]
        [XmlArrayItem("crewmembers")]
        public List<string> CrewMembers { set; get; }
        public override string ToString()
        {
            return base.ToString()+$"Type Military Plane Capacity {Capacity}";
        }
    }
}
