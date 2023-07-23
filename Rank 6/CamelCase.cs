using System.Linq;

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