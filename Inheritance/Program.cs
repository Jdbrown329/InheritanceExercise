using System;

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


            var bird1 = new Birds();
            bird1.ClassName = "Parrot";
            bird1.SharpBeak = true;
            bird1.EatsMeat = true;
            bird1.DoesFLy = true;
            bird1.LifeSpan = 80;


            var Reptile1 = new Reptiles();
            Reptile1.ClassName = "Komodo Dragon";
            Reptile1.IsExtinct = false;
            Reptile1.LandSea = false;
            Reptile1.LifeSpan = 30;
            Reptile1.HasShell = false;
            Reptile1.EatsMeat = true;

            Console.WriteLine($"My favorite reptile is the {Reptile1.ClassName}. There rumor it is extinct is {Reptile1.IsExtinct}. There is so much misinformation about this animal. Some believe it to be Amphibious and that is also {Reptile1.LandSea} ");
            Console.WriteLine($"The average {Reptile1.ClassName} lives about 30 years and it is {Reptile1.EatsMeat} that there is a video of one devouring an entire deer. There is a {Reptile1.HasShell} claim that they have shells, do not believe this!");

            Console.WriteLine($"The ealry colonist were gifted with the {bird1.ClassName} and it is {bird1.SharpBeak} they're beaks could harm. It is also {bird1.EatsMeat} that they eat other animals.They are {bird1.DoesFLy} to the skies when they fly and can live {bird1.LifeSpan} years");
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
