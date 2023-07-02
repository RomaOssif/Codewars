using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Codewars
{
    public class StripCommentsKata
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            var result = new List<string>();

            foreach (string sentence in text.Split('\n'))
            {
                string toAdd = sentence;

                foreach (string symbol in commentSymbols)
                {
                    if (sentence.Contains(symbol))
                    {
                        toAdd = sentence.Remove(sentence.IndexOf(symbol)).Trim();
                        break;
                    }
                }

                result.Add(toAdd);
            }

            return string.Join('\n', result);
        }
    }
}