using System.Linq;
namespace Codewars
{
    public class ScrambliesKata
    {
        public static bool Scramble(string str1, string str2)
        {
            List<char> lettersGot = new List<char> (str1.Where(x => str2.Any(e => e == x)));
            List<char> splitWord = new List<char> (str2);

            for (int i = 0; i < splitWord.Count; i++)
            {
                if (lettersGot.Contains(splitWord[i]))
                {
                    char toRemove = splitWord[i];

                    splitWord.Remove(toRemove);
                    lettersGot.Remove(toRemove);

                    i = -1;
                }
                else
                    return false;
            }

            return true;
        }

    }
}

/* Link for the Kata: https://www.codewars.com/kata/55c04b4cc56a697bb0000048
 * Here is the description for Scramblies kata:

Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2,
otherwise returns false.

 * Notes:
Only lower case letters will be used (a-z). No punctuation or digits will be included. Performance needs to be considered.

 * Examples:
scramble('rkqodlw', 'world') ==> True
scramble('cedewaraaossoqqyt', 'codewars') ==> True
scramble('katas', 'steak') ==> False
*/