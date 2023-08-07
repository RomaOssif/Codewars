using System;

public static class RomanNumerals
{
	enum Roman
	{
		I = 1,
		V = 5,
		X = 10,
		L = 50,
		C = 100,
		D = 500,
		M = 1000,
	}

	public static int Decode(string roman)
	{
		int sum = 0;

		for (int i = 0; i < roman.Length; i++)
		{
			int current = (int)Enum.Parse(typeof(Roman), roman[i].ToString());
			int next;

			try
			{
				next = (int)Enum.Parse(typeof(Roman), roman[i+1].ToString());
			}
			catch
			{
				next = 0;
			}

            if (current < next)
            {
				sum += next - current;

				i++;
			}
			else
			{
				sum += current;
			}
		}

		return sum;
	}

	public static string Encode(int roman)
	{
		string result = "";

        int[] toCompare = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] numerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};

        for (int i = 0; i < 13; i++)
        {
            while (roman >= toCompare[i])
            {
                result += numerals[i];

				roman -= toCompare[i];
            }
        }

        return result;
	}
}

/* Link for the Kata: https://www.codewars.com/kata/51b66044bce5799a7f000003
 * Here is the description for Roman Numerals Helper kata:

Write two functions that convert a roman numeral to and from an integer value.
Multiple roman numeral values will be tested for each function.

Modern Roman numerals are written by expressing each digit separately starting with
the left most digit and skipping any digit with a value of zero.

In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC.
2008 is written as 2000=MM, 8=VIII; or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.

Input range : 1 <= n < 4000

In this kata 4 should be represented as IV, NOT as IIII (the "watchmaker's four").

Examples
to roman:
2000 -> "MM"
1666 -> "MDCLXVI"
1000 -> "M"
 400 -> "CD"
  90 -> "XC"
  40 -> "XL"
   1 -> "I"

from roman:
"MM"      -> 2000
"MDCLXVI" -> 1666
"M"       -> 1000
"CD"      -> 400
"XC"      -> 90
"XL"      -> 40
"I"       -> 1

*/