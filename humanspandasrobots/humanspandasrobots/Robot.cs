using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Robot
    {
        //this will require any new robot has a name
        public string RobotName { get; set; }
        public Robot (string name)
        {
            this.RobotName = name;
        }
        //this method will say if the robot is the terminator or not
        public void IsTerminator()
        {
            
        }
        //this method will turn the robot on
        public void StartUp()
        {
            _IsAsleep = false;
            Console.WriteLine("Robot boot sequence");
        }
        //this method will turn the robot off
        public void ShutDown()
        {
            _IsAsleep = true;
            Console.WriteLine("Robot shutting down");
        }
        //this method will display the robot greeting
        public void DisplayGreeting()
        {
            Console.WriteLine($"Beep Boop Beep {RobotName}");
        }
        //this method will display the robots name
        public void DisplayName()
        {
            Console.WriteLine(RobotName);
        }
        //this is the robots name property
        public string name { get; set; }
        //this will see if the robot is asleep
        public bool IsAsleep { get { return _IsAsleep; } }
        private bool _IsAsleep;
    }
}
