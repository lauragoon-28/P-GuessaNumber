using System;

namespace Guess_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int randNum;
            int minNum;
            int maxNum;
            
            Console.WriteLine("Please enter a number that will be used as a minimum boundary. Whole numbers only.");
            string answer1 = Console.ReadLine();

            if (int.TryParse(answer1, out minNum) == false)
            {
                Console.WriteLine("Sorry, this is an invalid response");
            }

            Console.WriteLine("Please enter a number that will be used as a maximum boundary. Whole numbers only.");
            string answer2 = Console.ReadLine();

            if (int.TryParse(answer2, out maxNum) == false)
            {
                Console.WriteLine("Sorry, this is an invalid response");
            }

            // so the guesser doesn't pick a max number that is greater than the min
            while (minNum >= maxNum) 
            {
                Console.WriteLine("Your minimum number exceeds your maximum number. Please try again.");
            }

            // generate random number
            Random rand = new Random();
            randNum = rand.Next(minNum, maxNum);

            Console.WriteLine("Please guess a number between your minimum and maximum, guess until you get it right!");
            string answer3 = Console.ReadLine();
            int guess;

            // loop for guessing random number
            
            bool isAnsweranInt = int.TryParse(answer3, out guess);
            while (true )
            {
                if (guess == randNum)
                {
                    Console.WriteLine("Congrats! You guessed right! Yay!");
                    return;
                }
                else
                {
                    Console.WriteLine("Keep on guessing! You'll get it eventually!");
                    answer3 = Console.ReadLine();
                }
            }
            while (isAnsweranInt == false)
            {
                guess = Convert.ToInt32(answer3);
                Console.WriteLine("You guessed wrong.");
                Console.WriteLine("Enter another number");
            }
            
        }
    }
}
