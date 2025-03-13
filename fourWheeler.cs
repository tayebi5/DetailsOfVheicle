using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleOfDetails
{
    internal class fourWheeler:vehicle,IFourWheler
    {
        public string InteriorDesgine()
        {
            return "sporty Exterioer Car";
        }
        public int NumbewrOfDoor { get; set; }
        public string interiorDesgine { get; set; }
        public override void FrontBack()
        {
            Console.WriteLine("sporty FrontBack Car");
        }
        public override void RearBack()
        {
            Console.WriteLine("sporty RearBack Car");
        }
    }
}
