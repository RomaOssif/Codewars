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

/* Link for the Kata: https://www.codewars.com/kata/59c633e7dcc4053512000073
 * Here is the description for Consonant value kata:

Given a lowercase string that has alphabetic characters only and no spaces, return the highest value of consonant substrings.
Consonants are any letters of the alphabet except "aeiou".

We shall assign the following values: a = 1, b = 2, c = 3, .... z = 26.

For example, for the word "zodiacs", let's cross out the vowels. We get: "z o d ia cs"

-- The consonant substrings are: "z", "d" and "cs" and the values are z = 26, d = 4 and cs = 3 + 19 = 22. The highest is 26.
solve("zodiacs") = 26

For the word "strength", solve("strength") = 57
-- The consonant substrings are: "str" and "ngth" with values "str" = 19 + 20 + 18 = 57 and "ngth" = 14 + 7 + 20 + 8 = 49. The highest is 57.
For C: do not mutate input.
*/