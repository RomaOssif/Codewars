namespace Codewars
{
    public class TwoSumKata
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            List<int> copy = new List<int> (numbers);

            foreach(int n in copy)
            {
                if (copy.Contains(target - n))
                {
                    result[0] = copy.IndexOf(n);

                    if (n == target - n)
                        copy[result[0]] = int.MinValue;
                    
                    result[1] = copy.IndexOf(numbers.First(e => e == target - n));

                    break;
                }
            }

            return result;
        }
    }
}