using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.Models
{
    abstract public class Plane
    {
        #region Consructors
        public Plane()
        {

        }
        #endregion

        #region Propetries
        public string Mark { set; get; }
        public int Number { set; get; }
        public int ReleaseYear { set; get; }
        public AirPlaneCreator Creator { set; get; }
        public override  string  ToString ()
        {
            return $"Number : {Number}; Mark : {Mark}; ReleaseYear : {ReleaseYear};";
        }
        #endregion 
    }
}
