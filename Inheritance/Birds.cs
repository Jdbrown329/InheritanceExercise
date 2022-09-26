using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Birds:Animal
    {
        public bool DoesFLy { get; set; }  

        public bool LaysEggs { get; set; }

        public bool SharpBeak { get; set; } 

        public string CommonColor { get; set; } 
    }
}
