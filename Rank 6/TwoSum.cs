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

/* Link for the Kata: https://www.codewars.com/kata/52c31f8e6605bcc646000082
 * Here is the description for Two Sum kata:

Write a function that takes an array of numbers (integers for the tests) and a target number.
It should find two different items in the array that, when added together, give the target value.
The indices of these items should then be returned in a tuple / list (depending on your language) like so: (index1, index2).

For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.

The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers;
target will always be the sum of two different items from that array).

two_sum([1, 2, 3], 4) == {0, 2}
*/