using System;
using System.Collections.Generic;
using System.IO.Enumeration;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {   var viper = new Reptile();
            var eagle = new Bird();
            eagle.Fly = true;
            eagle.CanBePets = false;
            viper.Habitat = "Warm climates";
            viper.Venomous = true;
            viper.CanBeEaten = true;
            viper.CanBePets = true;
            viper.Habitat = "Warm climates";


            // TODO Be sure to follow best practice when creating your classes
            Console.WriteLine($"Today were going to talk about Eagles. Eagles have {eagle.Legs} legs, {eagle.Eyes} eyes that they can see " +
                $"for hundreds of yards." +
                $"They have {eagle.Nails} claws. {eagle.Fur} Eagles have feathers, " +
                $"which I don't think constitutes as fur." +
                $"{eagle.Fly}, they can fly hundreds of feet in there air. " +
                $"They use that to " +
                $"hunt and eat {eagle.Eats}. {eagle.LayEggs}, they find a tall tree to build a nest" +
                $"and lay their eggs. " +
                $"To keep other predators from snatching up their babies. {eagle.CanBePets}, " +
                $"they are a nationally recognized" +
                $"bird, there are laws in place that keep people from having them as pets. " +
                $"That was a little info" +
                $"about eagles.");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("hit any button to continue.");
            Console.WriteLine($"Now! on to the next animal. Viper! {viper.Fur}, they have scales, they use the sun" +
                $" to stay warm. {viper.Fly}, they can not fly, however there are a few species of snakes that can glide." +
                $" Imgaine seeing one gliding towards you!!! {viper.Nails}, no claws, they have {viper.Legs} legs, even though reptiles do have" +
                $" claws. Snakes do not. Vipers hunt by being stealthy. Patiently waiting for their prey ({viper.Eats}) to get close " +
                $" enough to inject posionous {viper.Venomous} venom. {viper.Dangerous}, they can be dangerous" +
                $" some species can kill you. It happens every year, which makes my next statement " +
                $" {viper.CanBeEaten}. It's considered a delicacy in some places. So we get them back" +
                $" for getting us. {viper.LayEggs} they continue their bloodline by laying eggs" +
                $" Which means it's also {viper.CanBePets} they can be pets. Several people enjoy having " +
                $" a dangerous animal as a pet. I don't recommend any one get one now. I say leave that to " +
                $" the professionals. Vipers thrive in {viper.Habitat}. There you go. Welcome to the animal kingdom!!");                      
                                           
                   
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
