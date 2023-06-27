namespace Codewars
{
    public static class KataPangram
    {
        public static bool IsPangram(string sentence)
        {
            List<char> alphabet = new List<char>()
            {
                'a',
                'b',
                'c',
                'd',
                'e',
                'f',

                'g',
                'h',
                'i',
                'k',
                'l',

                'm',
                'n',
                'o',
                'p',
                'q',
                'r',

                's',
                't',
                'u',
                'v',
                'w',

                'x',
                'y',
                'z',
            };

            sentence = sentence.ToLower();

            foreach (char letter in sentence)
            {
                if (alphabet.Contains(letter))
                {
                    alphabet.Remove(letter);
                }
            }

            return (alphabet.Count == 0) ? true : false;
        }

    }

}