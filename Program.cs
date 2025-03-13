using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleOfDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "Alice", Age = 30 };
            MotorCycle Mymotor = new MotorCycle("red betel m-665", 2023, 6, 1, "sell", 7, 350, 167, "lequied", VehicleType.MotorCycle, 450);
            Console.WriteLine("Details of MotorCycle--\n");
            Console.WriteLine(Mymotor.GetMotorCycleModel());
            Console.WriteLine("Model Name : "+ Mymotor.ModelNO);

            Console.WriteLine(" Makeing Year : "+ Mymotor.YearMake);
            Console.WriteLine("Number OF seat : "+ Mymotor.NumberOfSeat);
            Console.WriteLine("Number of Gear :"+ Mymotor.NumberOfGear);
            Console.WriteLine("Max power of MotorCycle: "+ Mymotor.MaxPower);
            Console.WriteLine("Max torqer NM: "+ Mymotor.MaxTorqueNM);
            Console.WriteLine("Start bike : "+ Mymotor.StraticMethod);
            Console.WriteLine("KMPL : "+ Mymotor.MilegeKMPL);
            Console.WriteLine("cooling : "+ Mymotor.Cooling);
            Console.WriteLine("Type : "+Mymotor.Type);
            Console.WriteLine($"Capacity oF CC: {Mymotor.CapacityOfCC}\n");
            Mymotor.FrontBack();
            Mymotor.RearBack();
            Mymotor.StartEngine();

            Car mycar = new Car("BMDW-E4",2024,4,4,350,4,"metalic",VehicleType.Car);
            Console.WriteLine("-----Details of Car ----\n");
            Console.WriteLine(mycar.GetCarModel());
            Console.WriteLine("Model of car : "+ mycar.ModelNO);
            Console.WriteLine("Making year: "+ mycar.YearMake);
            Console.WriteLine("Number of Seat : "+ mycar.NumberOfSeat);
            Console.WriteLine("Number of Gear : "+ mycar.NumberOfGear);
            Console.WriteLine("Capacity of CC : "+ mycar.CapacityOfCC);
            Console.WriteLine("Number oF Door: "+ mycar.NumbewrOfDoor);
            Console.WriteLine("Desgine of Car: "+ mycar.interiorDesgine);
            Console.WriteLine("type : "+ mycar.Type);
            mycar.FrontBack();
            mycar.RearBack();
            mycar.StartEngine();
            Console.Read();
        }
    }
}
