using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Robot
    {
        //this method will say if the robot is the terminator or not
        public void IsTerminator()
        {
            
        }
        //this method will turn the robot on
        public void StartUp()
        {
            Console.WriteLine("Beep Boop Robot Started");
        }
        //this method will turn the robot off
        public void ShutDown()
        {
            Console.WriteLine("Beep Boop Robot Shutdown");
        }
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
        //this is the robots name property
        public string Name { get; set; }
        //this will see if the robot is asleep
        public bool IsAsleep { get; set; }
    }
}
