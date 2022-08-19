using System;
using System.Collections.Generic;
using System.IO.Enumeration;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            
            var eagle = new Bird();
            Console.WriteLine("An Eagle");
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine(eagle.Legs);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(eagle.Eyes);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(eagle.Nails);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(eagle.Fur);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            eagle.Fur = true;
            Console.WriteLine(eagle.Fur);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            eagle.Fly = true;
            Console.WriteLine(eagle.Fly);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            eagle.Eats = "Reptiles, Other birds, Large Mammels";
            Console.WriteLine(eagle.Eats);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            eagle.LayEggs = true;
            Console.WriteLine(eagle.LayEggs);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            var viper = new Reptile();
            Console.WriteLine("A Viper");
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(viper.Fur);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine(viper.Fly);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine(viper.Nails);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine(viper.Eats);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine(viper.Legs);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(viper.LayEggs);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            viper.CanBePets = true;
            Console.WriteLine(viper.CanBePets);
            Console.WriteLine("Experienced personal only!");
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            viper.CanBeEaten = true;
            Console.WriteLine(viper.CanBeEaten);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            viper.Venomous = true;
            Console.WriteLine(viper.Venomous);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            viper.Dangerous = true;
            Console.WriteLine(viper.Dangerous);
            Console.WriteLine("May not kill you but will hurt if you're bitten");
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine();

            viper.Habitat = "Warm climates";
            Console.WriteLine(viper.Habitat);
            Console.WriteLine("hit any button");
            Console.ReadLine();
            Console.WriteLine("Thank you for watching!");












            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */


        }
    }
}
