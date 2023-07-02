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