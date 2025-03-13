using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleOfDetails
{
    abstract class vehicle
    {
        public string ModelNO { get; set; }
        public int YearMake { get; set; }
        public int NumberOfGear { get; set; }
        public int NumberOfSeat { get; set; }
        public int CapacityOfCC { get; set; }
        public VehicleType Type { get; set; }
        public virtual void RearBack()
        {
            Console.WriteLine("RearBack");
        }
        public virtual void FrontBack()
        {
            Console.WriteLine("FrontBack");
        }
        public virtual void StartEngine()
        {
            Console.WriteLine("StartEngine");
        }
    }
}
