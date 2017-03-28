﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Human
    {
        //this method will wake the human up.
        public void WakeUp()
        {
            Console.WriteLine($"{ Name} is now awake." );
        }
        //this method will put the human to sleep
        public void GoToSleep()
        {
            Console.WriteLine($"{Name} is now sleeping.");
        }
        //this method will display the human greeting
        public void DisplayGreeting()
        {
            Console.WriteLine($"Hello, I'm {Name}");
        }
        //this method will display the humans name
        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
        public void Eat()
        {
            var food = "Chicken Wings";
            Console.WriteLine($"Yum, I just ate {food}");
        }
        //this is the humans name property
        public string Name { get; set; }
    }
}
