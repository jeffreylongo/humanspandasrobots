using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Panda
    {
        //this method will display the pandas name
        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
        public string Name { get; set; }
    }
}
