namespace Codewars
{
    public class Morse1
    {
        public static string Decode(string input)
        {
            input = input.Trim();

            var _translation = new Dictionary<string, string>()
            {
                [".-"] = "A",
                ["-..."] = "B",
                ["-.-."] = "C",
                ["-.."] = "D",

                ["."] = "E",
                ["..-."] = "F",
                ["--."] = "G",
                ["...."] = "H",

                [".."] = "I",
                [".---"] = "J",
                ["-.-"] = "K",
                [".-.."] = "L",

                ["--"] = "M",
                ["-."] = "N",
                ["---"] = "O",
                [".--."] = "P",

                ["--.-"] = "Q",
                [".-."] = "R",
                ["..."] = "S",
                ["-"] = "T",

                ["..-"] = "U",
                ["...-"] = "V",
                [".--"] = "W",

                ["-..-"] = "X",
                ["-.--"] = "Y",
                ["--.."] = "Z",

                ["...---..."] = "SOS",

                ["-.-.--"] = "!",
                [".-.-.-"] = ".",
                ["..--.."] = "?",
                ["--..--"] = ",",
                ["---..."] = ":"
            };

            string result = "";

            foreach (var word in input.Split("   "))
            {
                foreach (var letter in word.Split(" "))
                {
                    result += _translation[letter];
                }
                result += " ";
            }

            return result.TrimEnd();
        }
    }
}