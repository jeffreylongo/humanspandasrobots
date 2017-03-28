using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Human
    {
        //this method will display the humans name
        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
        public string Name { get; set; }
    }
}
