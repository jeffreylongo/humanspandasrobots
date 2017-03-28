using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Robot
    {
        //this method will display the robot greeting
        public void DisplayGreeting()
        {
            Console.WriteLine("Beep Boop Beep");
        }
        //this method will display the robots name
        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
        public string Name { get; set; }
    }
}
