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
                        toAdd = sentence.Remove(sentence.IndexOf(symbol));
                        break;
                    }
                }

                result.Add(toAdd.Trim());
            }

            return string.Join('\n', result);
        }
    }
}

/* Link for the Kata: https://www.codewars.com/kata/51c8e37cee245da6b40000bd
 * Here is the description for Strip Comments kata:

Complete the solution so that it strips all text that follows any of a set of comment markers passed in.
Any whitespace at the end of the line should also be stripped out.

 * Example:

Given an input string of:

apples, pears # and bananas
grapes
bananas !apples

The output expected would be:

apples, pears
grapes
bananas

The code would be called like so:

string stripped = StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new [] { "#", "!" })
// result should == "apples, pears\ngrapes\nbananas"
*/