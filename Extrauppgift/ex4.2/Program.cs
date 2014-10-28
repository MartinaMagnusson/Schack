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
            car.StartEngine();
            car.StopEngine();
            Console.ReadKey();

        }

    }
    public class Car
    {
        private Engine engine = new Engine();
        private Gear gear = new Gear();

        public void StartEngine()
        {
            engine.StartEngine();
        }
        public void StopEngine()
        {
            engine.StopEngine();
        }
        public void MoveGear(int NowCear)
        {
            gear.MoveGear();
        }
        public void StoreCarModel(string newModel)
        { }
        public string GetCarModel()
        {
            return "";
        }

    }
    public class Engine
    {
        private bool started = false;
        private bool stopped = true;
        public void StartEngine()
        {
            if (started == false)
            {
                Console.WriteLine("Engine started");
                started = true;
            }
            else
            {
                Console.WriteLine("Engine is already running");
            }

        }
        public void StopEngine()
        {
            if (started == true)
            {
                Console.WriteLine("Engine stopped");
                stopped = false;
            }
            else
            {
                Console.WriteLine("Engine is already stopped");
            }
        }
    }
    public class Gear
    {
        public void MoveGear(int New)
        {
 
        }
    }

}