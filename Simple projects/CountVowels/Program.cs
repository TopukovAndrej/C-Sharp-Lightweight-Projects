namespace CountVowels
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<char, int> vowelsCount = new()
            {
                ['a'] = 0,
                ['e'] = 0,
                ['i'] = 0,
                ['o'] = 0,
                ['u'] = 0,
            };

            Console.WriteLine(value: "Enter the text from the vowels should be counted:");

            string? text = Console.ReadLine();

            if (string.IsNullOrEmpty(value: text))
            {
                Console.WriteLine(value: "The text cannot be null or an empty string!");

                Environment.Exit(exitCode: -1);
            }

            char vowelInLowerCase;

            for (int i = 0; i < text!.Length; i++)
            {
                if (!CheckIfCharacterIsVowel(c: text[i]))
                {
                    continue;
                }

                vowelInLowerCase = char.ToLower(c: text[i]);

                if (vowelsCount.TryGetValue(key: vowelInLowerCase, value: out int value))
                {
                    vowelsCount[vowelInLowerCase] = ++value;
                }
            }

            Console.WriteLine(value: "*******************************************");
            Console.WriteLine("Summary:");
            Console.WriteLine(value: $"Total number of vowels: {vowelsCount.Values.Sum()}");
            Console.WriteLine(value: $"Number of 'a' vowels: {vowelsCount['a']}");
            Console.WriteLine(value: $"Number of 'e' vowels: {vowelsCount['e']}");
            Console.WriteLine(value: $"Number of 'i' vowels: {vowelsCount['i']}");
            Console.WriteLine(value: $"Number of 'o' vowels: {vowelsCount['o']}");
            Console.WriteLine(value: $"Number of 'u' vowels: {vowelsCount['u']}");
        }

        private static bool CheckIfCharacterIsVowel(char c)
        {
            return "aeiou".Contains(value: c, comparisonType: StringComparison.OrdinalIgnoreCase);
        }
    }
}
