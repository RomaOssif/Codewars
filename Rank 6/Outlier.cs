namespace Codewars
{
    public static class OutlierKata
    {
        public static int Find(int[] integers)
        {
            int outlier = (integers[0] % 2 + integers[1] % 2 + integers[2] % 2 <= 1) ? 1 : 0;

            return integers.Single(number => number % 2 == outlier);
        }
    }
}

//int[] numbers = { 0, 2, 4, 6, 3, 2, 662, 2 };
//Console.WriteLine(OutlierKata.Find(numbers));

//3 elements would give -
//if even: 0 0 0    OR 0 0 1
//if odd:  1 1 1    OR 1 1 0