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

            while (int.TryParse(answer1, out minNum) == false)
            {
                Console.WriteLine("Sorry, this is an invalid response. Please enter a whole number");
                answer1 = Console.ReadLine();
            }

            Console.WriteLine("Please enter a number that will be used as a maximum boundary. Whole numbers only.");
            string answer2 = Console.ReadLine();

            while (int.TryParse(answer2, out maxNum) == false)
            {
                Console.WriteLine("Sorry, this is an invalid response. Please enter a whole number");
                answer2 = Console.ReadLine();
            }

            // so the guesser doesn't pick a max number that is greater than the min
            while (minNum >= maxNum) 
            {
                Console.WriteLine($"Your minimum number exceeds your maximum number. Please input a new maximum value that is greater than {minNum}.");
                answer2 = Console.ReadLine();

                while (int.TryParse(answer2, out maxNum) == false)
                {
                    Console.WriteLine("Sorry, this is an invalid response. Please enter a whole number");
                    answer2 = Console.ReadLine();
                }
            }

            // generate random number
            Random rand = new Random();
            randNum = rand.Next(minNum, maxNum + 1);

            Console.WriteLine("Please guess a number between your minimum and maximum values, guess until you get it right!");
            string answer3 = Console.ReadLine();
            int guess;

            // loop for guessing random number

            while (int.TryParse(answer3, out guess) == false)
            {
                Console.WriteLine("Invalid guess. Please enter a whole number");
                answer3 = Console.ReadLine();
            }
            while (guess != randNum)
            {
                Console.WriteLine("Your guess is incorrect. Keep on trying!!");
                answer3 = Console.ReadLine();
                while (int.TryParse(answer3, out guess) == false)
                {
                    Console.WriteLine("Invalid guess. Please enter a whole number");
                    answer3 = Console.ReadLine();
                }
            }

            Console.WriteLine("Congrats! You guessed it right!!! YAY!! Go you!!! :))))");
            
        }
    }
}
