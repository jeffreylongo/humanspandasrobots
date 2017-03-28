using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Panda
    {
        //this will require a name for any new panda
        public string PandaName { get; set; }
        public Panda (string name)
        {
            this.PandaName = name;
        }
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
        //this will see if the panda is asleep
        public bool IsAsleep { get { return _IsAsleep; } }
        private bool _IsAsleep;
    }
}
