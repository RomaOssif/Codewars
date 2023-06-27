namespace Codewars
{
    public static class OrderKata
    {
        public static string Order(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return string.Empty;

            var words = sentence.Split(' ');
            var result = new string[words.Length];

            foreach (var word in words)
                result[word.First(c => c <= '9') - '1'] = word;

            return string.Join(" ", result);
        }
    }
}

//Test: Console.WriteLine(OrderKata.Order("Fo1r the2 g3ood 4of th5e pe6ople"));