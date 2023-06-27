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