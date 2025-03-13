using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleOfDetails
{
    internal class TwoWheeler:vehicle,ITwoWheeler
    {
       public string ExteriorDesgine()
        {
            return "sporty Exterioer MotorCycle";
        }
        public string StraticMethod { get; set; }
        public int MaxPower { get; set; }
        public int MaxTorqueNM { get; set; }
        public int MilegeKMPL { get; set; }
        public string Cooling { get; set; }
        public override void FrontBack()
        {
            Console.WriteLine("Motorcycle-specific Front Break");
        }
        public override void RearBack()
        {
            Console.WriteLine("Motorcycle-specific Front Break");
        }

    }
}
