using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Panda :Mammal
    {
        //this method will wake the panda up.
        public void WakeUp()
        {
            _IsAsleep = false;
            Console.WriteLine($"{ Name} is now awake.");
        }
        //this method will put the panda to sleep
        public void GoToSleep()
        {
            _IsAsleep = true;
            Console.WriteLine($"{Name} is now sleeping.");
        }
        //this method will display the Panda greeting
        public void DisplayGreeting()
        {
            Console.WriteLine($"Rawr, I'm a panda named {Name}...I think...wait, why am I talking?");
        }
        public void Eat()
        {
            var food = "leaves or whatever";
            Console.WriteLine($"Rawr rawr {food}");
        }
        //this is the panda name property
        public string Name { get; set; }
        //this will see if the panda is asleep
        public bool IsAsleep { get { return _IsAsleep; } }
        private bool _IsAsleep;

        public Panda(string name) : base(name)
        {
        }
    }
}
