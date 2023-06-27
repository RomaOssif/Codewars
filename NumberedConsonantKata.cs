namespace Codewars
{
    public class NumberedConsonantKata
    {
        public static int Solve(string word)
        {
            var consonants = ValidateInput(word).Split('_', StringSplitOptions.RemoveEmptyEntries);

            int maxValue = 0;

            foreach (var consonant in consonants)
            {
                int counter = 0;

                foreach (char c in consonant)
                {
                    counter += c - 'a' + 1;
                }

                if (counter > maxValue)
                    maxValue = counter;
            }

            return maxValue;
        }

        private static string ValidateInput(string input)
        {
            char[] vowels =
            {
                'a',
                'e',
                'i',
                'o',
                'u'
            };

            return input.Replace('a', '_')
                        .Replace('e', '_')
                        .Replace('i', '_')
                        .Replace('o', '_')
                        .Replace('u', '_');
        }
    }
}

//Test: Console.WriteLine(NumberedConsonantKata.Solve("streeengteueuh"));