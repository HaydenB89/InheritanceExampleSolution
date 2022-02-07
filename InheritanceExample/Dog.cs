using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Dog
    {
        public string Name { get; set; } = "Fido";
        public int NmbrOfLegs { get; set; } = 4;
        public bool HasTail { get; set; } = true;
        public string BarkSound { get; set; } = "Woof";
        public string Size { get; set; } = "Medium";

        public void Print()
        {
            Console.WriteLine($"{Name} has {NmbrOfLegs} legs, has a tail {HasTail}, "
                              + $"the barke sounds like {BarkSound}, "
                              + $"and is {Size}");
        }
    }
}
