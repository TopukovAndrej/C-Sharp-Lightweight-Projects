namespace FizzBuzz
{
    internal class Program
    {
        static void Main()
        {
            bool isMultipleOfThree;
            bool isMultipleOfFive;

            for (int i = 1; i <= 100; i++)
            {
                isMultipleOfThree = i % 3 == 0;
                isMultipleOfFive = i % 5 == 0;

                if (isMultipleOfThree && isMultipleOfFive)
                {
                    Console.WriteLine(value: "FizzBuzz");
                }
                else if (isMultipleOfThree)
                {
                    Console.WriteLine(value: "Fizz");
                }
                else if (isMultipleOfFive)
                {
                    Console.WriteLine(value: "Buzz");
                }
                else
                {
                    Console.WriteLine(value: i);
                }
            }
        }
    }
}
