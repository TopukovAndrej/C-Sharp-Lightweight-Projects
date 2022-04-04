using System;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number between 1 and 100!\n");
            Console.WriteLine("==============================================================\n\n");

            Random random = new Random();

            int number = random.Next(1, 101);
            int numberOfGuesses = 0;

            while (true)
            {
                try
                {
                    string? line = Console.ReadLine();

                    if (line == null)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    else
                    {
                        int guess = Int32.Parse(line);

                        if (guess < number)
                        {
                            Console.WriteLine("The number is bigger!\n");
                            numberOfGuesses++;

                            continue;
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("The number is smaller!\n");
                            numberOfGuesses++;

                            continue;
                        }
                        else
                        {
                            numberOfGuesses++;

                            Console.WriteLine("\nCongratulations! You guessed the number!\n");
                            Console.WriteLine(String.Format("Number of guesses used: {0}", numberOfGuesses));

                            break;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input must be an integer!");
                    continue;
                }
            }

            Environment.Exit(0);
            Console.ReadKey();
        }
    }
}