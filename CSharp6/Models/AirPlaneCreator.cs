using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.Models
{
    public class AirPlaneCreator
    {
        //  Возможные поля: имя, страна, год основания, типы производимых самолетов и т.д. 

        public string Name { set; get; }
        public string Country { set; get; }
        public int FoundationYear { set; get; }
        public List<string> AirPlanesTypes { set; get; }
    }
}
