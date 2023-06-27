using System;
public enum Roman
{
	I = 1,
	V = 5,
	X = 10,
	L = 50,
	C = 100,
	D = 500,
	M = 1000,
}

public static class RomanNumerals
{
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

		while (roman >= 1000)
		{
			result += "M";

			roman -= 1000;
			continue;
		}

		if (roman >= 900)
		{
            result += "CM";

            roman -= 900;
        }

		while (roman >= 500)
		{
			result += "D";

            roman -= 500;
            continue;
        }

        if (roman >= 400)
        {
            result += "CD";

            roman -= 400;
        }

        while (roman >= 100)
        {
            result += "C";

            roman -= 100;
            continue;
        }

        if (roman >= 90)
        {
            result += "XC";

            roman -= 90;
        }

        while (roman >= 50)
        {
            result += "L";

            roman -= 50;
            continue;
        }

        if (roman >= 40)
        {
            result += "XL";

            roman -= 40;
        }

        while (roman >= 10)
        {
            result += "X";

            roman -= 10;
            continue;
        }

        if (roman >= 9)
        {
            result += "IX";

            roman -= 9;
        }

        while (roman >= 5)
        {
            result += "V";

            roman -= 5;
            continue;
        }

        if (roman >= 4)
        {
            result += "IV";

            roman -= 4;
        }

        while (roman >= 1)
        {
            result += "I";

            roman -= 1;
            continue;
        }

        return result;
	}
}