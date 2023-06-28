namespace Codewars
{
    public class DigitalRootKata
    {
        public static int DigitalRoot(int n)
        {
            if (n <= 9)
                return n;
            else
            {
                int sum = 0;

                while (n > 0)
                {
                    sum += n % 10;

                    n /= 10;
                }

                return DigitalRoot(sum);
            }
        }
    }
}