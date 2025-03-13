using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleOfDetails
{
    sealed class Car:fourWheeler
    {
        public Car() { }
        public Car(string modelNo,int yearMake,int gear,int seat,int CC,int Door,string Desgine,VehicleType type) {
            ModelNO = modelNo;
            YearMake = yearMake;
            NumberOfGear = gear;
            NumberOfSeat = seat;
            CapacityOfCC = CC;
            NumbewrOfDoor = Door;
            interiorDesgine = Desgine;
            Type = type;
        }
        public string GetCarModel()
        {
            return $"Model Name: {ModelNO}";
        }
        public string GetCarModel(int year)
        {
            return $"Model : {ModelNO}, year : {year}";
        }
        public override void StartEngine()
        {
            Console.WriteLine("Car start key ");
        }

    }
}
