using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Pug : Dog
    {
        public Pug()
        {
            Name = "Pugly";
            Size = "Small";
            NmbrOfLegs = 1;
            BarkSound = "yip";
        }
    }
}
