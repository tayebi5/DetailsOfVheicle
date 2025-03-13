using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace vehicleOfDetails
{
    sealed class MotorCycle:TwoWheeler
    {
        public object NumberOfDoor { get; internal set; }
        public MotorCycle() { }
        public MotorCycle(string modelNo,int yearmake,int numberofGear,int numberofseat,string straticMethod,int maxPower,int maxTorqueNM,int KMPL,string Cool, VehicleType type,int Capaccity) {

            ModelNO = modelNo;
            YearMake = yearmake;
            NumberOfGear = numberofGear;
            NumberOfSeat = numberofseat;
            CapacityOfCC = Capaccity;
            Type = type;
            StraticMethod = straticMethod;
            MaxPower = maxPower;
            MaxTorqueNM = maxTorqueNM;
            MilegeKMPL = KMPL;
            Cooling = Cool; 
        }

        public override void StartEngine()
        {
            Console.WriteLine("MotorCycle start kik ");
        }
        public string GetMotorCycleModel()
        {
            return $"Model name={ModelNO}";
        }
    }
}
