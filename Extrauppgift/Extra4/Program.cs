using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.IsEngineStart = true;
            car.IsEngineStop = true;
            Console.WriteLine(car.StartEngine(car));
            Console.WriteLine(car.StopEngine(car));
            Console.ReadKey();

        }

    }
    public class Car
    {
        public bool IsEngineStart { get; set; }
        public bool IsEngineStop { get; set; }

        public string StartEngine(Car car)
        {
            if (car.IsEngineStart == false)
            {
                return "Engine started";
            }
            return "Engine is already running";
        }
        public string StopEngine(Car carStop)
        {
            if (carStop.IsEngineStop == false)
            {
                return "Engine stopped";
            }
            return "Engine is already stopped";
        }
        public void MoveGear(int NowCear)
        { }
        public void StoreCarModel(string newModel)
        { }
        public string GetCarModel()
        {
            return "";
        }

    }
}
