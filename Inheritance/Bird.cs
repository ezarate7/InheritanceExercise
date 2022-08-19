using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{    //DONE Create a class Bird
     //DONE give this class 4 members that are specific to Bird
     //DONE Set this class to inherit from your Animal Class
    internal class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            Eyes = 2;
            Nails = 6;
            Fur = true;

        }   
        public bool Fly { get; set; }
        
        public bool LayEggs { get; set; }
        public string Eats { get; set; }
        public bool CanBePets { get; set; }


        
        
        
    }
}
