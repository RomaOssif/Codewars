namespace Codewars
{
    class IntoBinaryKata
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            double sum = 0, power = 0;

            foreach (int num in BinaryArray.Reverse())
            {
                sum += (num == 1) ? Math.Pow(2, power) : 0;

                power++;
            }

            return (int)sum;
        }
    }
}