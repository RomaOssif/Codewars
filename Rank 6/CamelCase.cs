namespace Codewars
{
    public static class CamelCase
    {
        public static string ToCamelCase(string str)
        {
            string[] words = str.Split('_', '-');

            return words[0] + string.Concat(words.Skip(1).Select(e => e[0].ToString().ToUpper() + e.Substring(1)));
        }
    }
}

/* Link for the Kata: https://www.codewars.com/kata/517abf86da9663f1d2000003
 * Here is the description for Convert string to camel case kata:

Complete the method/function so that it converts dash/underscore delimited words into camel casing.
The first word within the output should be capitalized only if the original word was capitalized
(known as Upper Camel Case, also often referred to as Pascal case). The next words should be always capitalized.

 * Examples
"the-stealth-warrior" gets converted to "theStealthWarrior"

"The_Stealth_Warrior" gets converted to "TheStealthWarrior"

"The_Stealth-Warrior" gets converted to "TheStealthWarrior"
*/