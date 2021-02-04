using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Inheritance_Test
{
    class Raptors : Birds
    {
        //This is a characteristic that is unique to the child class so that there is something to demonstrate how it is different.
        public string Speed { get; set; }

        //In the Raptors constructor, I set "Flies" to true as I believe all Raptors fly.
        public Raptors()
        {
            Flies = true;
        }

        //I copied the questions from the Birds class version of this method. I commented out the code about flying since that has been set to true, and I asked a question about the speed.
        public override void BirdQuiz(Raptors raptors)
        {
            Console.WriteLine("What color is your bird?");
            raptors.Color = Console.ReadLine().ToLower();
            //Console.WriteLine("Can your bird fly?");
            //string flightResponse = Console.ReadLine().ToLower();
            //if (flightResponse.Equals("no") || flightResponse.Equals("n"))
            //{
            //    raptors.Flies = false;
            //}
            //else
            //{
            //    raptors.Flies = true;
            //}
            Console.WriteLine("What does your bird eat?");
            raptors.Diet = Console.ReadLine().ToLower();
            Console.WriteLine("How fast is your bird?");
            raptors.Speed = Console.ReadLine().ToLower();
        }

        //This version of the BirdStatement method incorporates all of the properties of the Raptors class.
        public override void BirdStatement(Raptors raptors)
        {
            Console.WriteLine("O rly?");
            Console.WriteLine($"So it looks like your bird is {Color}, it flies, it eats {Diet}, and it is {Speed}.");
        }
    }
}
