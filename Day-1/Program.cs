using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello World";
            int num = 1492;
            bool haveDog = false;
            DateTime today = DateTime.Now;
            decimal someMoney = 5.45M;
            char oneChar = 'X';

            string sentenceOne = "Columbas sailed the world in ";

            String sentencePart1 = "It is";
            String sentencePart2 = "that I have a dog at home";

            string[] stringArray = new string[] { "Chevy", "Ford", "Honda", "Toyota" };

            var hobbies = new[]
            {
               new { id=1, hobby= "Boating" },
               new { id=2, hobby= "Fixing Cars" },
               new { id=3, hobby= "Gardening" },
               new { id=4, hobby= "Cooking" },
             };

            Console.WriteLine(firstString);
            Console.WriteLine(sentenceOne + num);
            Console.WriteLine(string.Format("{0}{1}.", sentenceOne, num));
            Console.WriteLine(string.Format("{0} {1} {2}.", sentencePart1, haveDog, sentencePart2));
            Console.WriteLine("Today is " + today.ToString("MMMM dd,yyyy" + "."));
            Console.WriteLine("I spent $" + someMoney + " on a cheeseburger.");
            Console.WriteLine(oneChar + " marks the spot.");

            foreach (var hobby in hobbies)
            {
                Console.WriteLine("Hobby " + hobby.id + ": " + hobby.hobby);
            }

            Console.ReadLine();
        }
    }
}
