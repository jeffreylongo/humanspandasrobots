using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();
            var jim = new Human("Jim");
            humans.Add(jim);
            jim.Age = 95;
            jim.HairColor = "pink";

            List<Panda> pandas = new List<Panda>();
            var pinky = new Panda("Pinky");
            pandas.Add(pinky);
            pinky.Age = 1;
            pinky.HairColor = "b&w";

            List<Robot> robots = new List<Robot>();
            var bender = new Robot("Bender");
            robots.Add(bender);

            bender.StartUp();
            bender.DisplayGreeting();
            bender.ShutDown();

            jim.WakeUp();
            jim.DisplayGreeting();
            jim.GoToSleep();

            pinky.WakeUp();
            pinky.DisplayGreeting();
            pinky.GoToSleep();


            Console.ReadLine();
        }
    }
}
