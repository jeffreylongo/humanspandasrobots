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

            List<Panda> pandas = new List<Panda>();
            var pinky = new Panda("Pinky");
            pandas.Add(pinky);

            List<Robot> robots = new List<Robot>();
            var bender = new Robot("Bender");
            robots.Add(bender);
        }
    }
}
