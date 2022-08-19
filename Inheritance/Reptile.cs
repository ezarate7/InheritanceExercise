using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{   //DONE Create a class Reptile
    // give this class 4 members that are specific to Reptile
    //DONE Set this class to inherit from your Animal Class

    internal class Reptile : Bird
    {
        public Reptile()
        {
            Legs = 0;
            Eyes = 2;
            Nails = 20;
            Fur = false;
            Fly = false;
            LayEggs = true;
            Eats = "Other Reptiles";
            CanBePets = true;
        }
        public string Habitat { get; set; }
        
        
        public bool Venomous { get; set; }
        public bool CanBeEaten { get; set; }
        public bool Dangerous { get; set; }

            

        
    }
}
