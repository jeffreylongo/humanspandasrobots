using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Panda
    {
        //this method will wake the panda up.
        public void WakeUp()
        {
            Console.WriteLine($"{ Name} is now awake.");
        }
        //this method will put the panda to sleep
        public void GoToSleep()
        {
            Console.WriteLine($"{Name} is now sleeping.");
        }
        //this method will display the Panda greeting
        public void DisplayGreeting()
        {
            Console.WriteLine($"Rawr, I'm a panda named {Name}...I think...wait, why am I talking?");
        }
        //this method will display the pandas name
        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
        public void Eat()
        {
            var food = "leaves or whatever";
            Console.WriteLine($"Rawr rawr {food}");
        }
        //this is the panda name property
        public string Name { get; set; }
    }
}
