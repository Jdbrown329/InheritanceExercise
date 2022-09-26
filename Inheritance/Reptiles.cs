using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptiles :Animal
    {
        public bool HasShell { get; set; }  

        public bool HasLegs { get; set; }   

        public bool LandSea { get; set; }   

        public  bool IsExtinct { get; set; }    
    }
}
