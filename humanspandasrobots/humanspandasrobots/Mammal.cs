using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    abstract class Mammal
    {
        //this method will require a name for any new human or panda
        public string Name { get; set; }
        public Mammal(string name)
        {
            this.Name = name;
        }
        //this method will display the humans or panda name
        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
    }
}
