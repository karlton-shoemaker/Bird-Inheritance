using System;

namespace Bird_Inheritance_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //This establishes variables of both the Birds and Raptors types so that we have something to work on.
            Birds birds = new Birds();
            Raptors raptors = new Raptors();

            //This asks the user whether or not the bird is a raptor. The answer determines which class will be mostly executed for this program.
            Console.WriteLine("Is your bird a raptor?");
            string isRaptor = Console.ReadLine().ToLower();

            if (isRaptor == "no" || isRaptor == "n")
            {
                birds.BirdQuiz(birds);
                birds.BirdStatement(birds);
            }
            if (isRaptor == "yes" || isRaptor == "y")
            {
                raptors.BirdQuiz(raptors);
                raptors.BirdStatement(raptors);
            }


            //Below is the code I had initially written to ask questions about a users bird. I just copy and pasted this code into the Birds class under the "Bird Quiz" method.

            //Console.WriteLine("What color is your bird?");
            //birds.Color = Console.ReadLine().ToLower();
            //Console.WriteLine("Can your bird fly?");
            //string flightResponse = Console.ReadLine().ToLower();
            //if (flightResponse.Equals("no") || flightResponse.Equals("n"))
            //{
            //    birds.Flies = false;
            //}
            //else
            //{
            //    birds.Flies = true;
            //}
            //Console.WriteLine("What does your bird eat?");
            //birds.Diet = Console.ReadLine().ToLower();
        }
    }
}
