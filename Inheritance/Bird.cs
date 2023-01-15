using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            BreathesAir = true;
            Eyes = 2;
            HasTail = true;
            CanSwim = true;

        }
        public bool CanFly { get; set; } = true; 
        public bool HasFeathers { get; set; } = true;
        public bool CanSing { get; set; } = true;
        public bool BuildsNest { get; set; } = true;

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
        }
    }
     
    
}
