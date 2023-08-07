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

/* Link for the Kata: https://www.codewars.com/kata/5526fc09a1bbd946250002dc
 * Here is the description for Find The Parity Outlier kata:

You are given an array (which will have a length of at least 3, but could be very large) containing integers.
The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N.
Write a method that takes the array as an argument and returns this "outlier" N.

Examples
[2, 4, 0, 100, 4, 11, 2602, 36]
Should return: 11 (the only odd number)

[160, 3, 1719, 19, 11, 13, -21]
Should return: 160 (the only even number)
*/