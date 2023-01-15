using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            BreathesAir = true;
            Eyes = 2;
            HasTail = true;
            CanSwim = false;
        }

        public bool IsColdBlooded { get; set; } = true;
        public string Movement { get; set; }
        public bool HasScales { get; set; }
        public bool HasForkedTongue { get; set; }
            
        public void PrintDetails() 
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"iS Cold-Blooded: {IsColdBlooded}");
            Console.WriteLine($"Mobility: {Movement}");
        }
        
    }
}
