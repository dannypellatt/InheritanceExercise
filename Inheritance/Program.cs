using System;
using Inheritance;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common



            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird kiwi = new Bird();


            kiwi.vertebrate = true;
            kiwi.legs = 2;
            kiwi.heterotrophy = "a herbivore";
            kiwi.reproduction = "lays eggs";
            kiwi.canFly = false;
            kiwi.wings = "small";
            kiwi.beak = "long";
            kiwi.feathers = "soft";

            Console.WriteLine($"The animal Kiwi belongs to the type Bird. It _ a vertibrate. It has {kiwi.legs} legs, " +
                $"it {kiwi.reproduction} and is {kiwi.heterotrophy}.");
            Console.WriteLine($"The Iguana has {kiwi.wings} wings, a {kiwi.beak} beak, and {kiwi.feathers} feathers.");
            Console.WriteLine($"It _ fly");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */



            Reptile iguana = new Reptile();

            iguana.vertebrate = true;
            iguana.legs = 4;
            iguana.heterotrophy = "an omnivore";
            iguana.reproduction = "lays eggs";
            iguana.scaleColor = "green";
            iguana.beak = false;
            iguana.cute = false;
            iguana.landOrWater = "both land and water";

            Console.WriteLine($"The animal Iguana belongs to the type Reptile. It _ a vertibrate. It has {iguana.legs} legs, " +
                $"it {iguana.reproduction} and is an {iguana.heterotrophy}.");
            Console.WriteLine($"The Iguana is {iguana.scaleColor}, and lives on {iguana.landOrWater}.");
            Console.WriteLine($"It _ cute and has _ beak.");


            // NOTES figure out how to include bools with $ and replace _s
        }
    }
}
