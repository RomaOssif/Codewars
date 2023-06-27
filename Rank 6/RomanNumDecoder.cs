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

public static class RomanDecoder
{
	public static int Decoder(string roman)
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
}