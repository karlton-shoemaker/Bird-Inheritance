using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Inheritance_Test
{
    class Birds
    {
        //Here are three characteristics of birds I selected to manipulate
        public string Color { get; set; }
        public bool Flies { get; set; }
        public string Diet { get; set; }

        //This method is just to print out the information to the console so that we can verify what was entered was processed correctly
        public void BirdStatement(Birds birds)
        {
            if (Flies)
            {
                Console.WriteLine($"So it looks like your bird is {Color}, it flies, and it eats {Diet}.");
            }
            else
            {
                Console.WriteLine($"So it looks like your bird is {Color}, it does not fly, and it eats {Diet}.");
            }
        }

        //This is the original text of the program I ended up shifting over to this method. I think our virtual pet project could become easier if we moved certain sections of code into classes.
        public void BirdQuiz(Birds birds)
        {
            Console.WriteLine("What color is your bird?");
            birds.Color = Console.ReadLine().ToLower();
            Console.WriteLine("Can your bird fly?");
            string flightResponse = Console.ReadLine().ToLower();
            if (flightResponse.Equals("no") || flightResponse.Equals("n"))
            {
                birds.Flies = false;
            }
            else
            {
                birds.Flies = true;
            }
            Console.WriteLine("What does your bird eat?");
            birds.Diet = Console.ReadLine().ToLower();
        }

        //These two methods are just here with a "Raptors" argument so that they can be inherited by the child class.
        public virtual void BirdQuiz(Raptors raptors)
        {

        }
        public virtual void BirdStatement(Raptors raptors)
        {

        }
    }
}
