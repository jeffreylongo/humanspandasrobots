using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Panda
    {
        //this method will display the Panda greeting
        public void DisplayGreeting()
        {
            Console.WriteLine("Rawr, I'm a panda...I think...wait, why am I talking?");
        }
        //this method will display the pandas name
        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
        public void Eat()
        {
            Console.WriteLine($"Rawr rawr {food}");
        }
        public string Name { get; set; }
    }
}
