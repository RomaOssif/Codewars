namespace Codewars
{
    public class CollatzKata
    {
        public static string Collatz(int number)
        {
            if (number == 1)
                return "1";

            List<int> list = new List<int>()
            { 
                number
            };

            while (number != 1)
            {
                number = (number % 2 == 0) ? number/2 : 3*number + 1;
                
                list.Add(number);
            }

            return string.Join("->", list);
        }
    }
}