using System.Linq;

namespace Codewars
{
    public static class CamelCase
    {
        public static string ToCamelCase(string str)
        {
            string[] words = str.Split('_', '-');
            string camel = words[0];

            foreach (string word in words.Skip(1))
            {
                camel += word[0].ToString().ToUpper() + word.Substring(1);
            }

            return camel;
        }
    }
}