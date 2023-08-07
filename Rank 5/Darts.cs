namespace Codewars
{
    public static class Darts
    {
        public static string GetScore(double x, double y)
        {
            double shotRadius = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            double wholeRadius = 170;

            if (shotRadius < 6.35)
                return "DB";
            if (shotRadius < 15.9)
                return "SB";
            if (shotRadius > 170)
                return "X";

            double cosZ = (y * 170) / (shotRadius * wholeRadius);

            double degrees = Math.Acos(cosZ) * (180 / Math.PI);
            degrees = (x >= 0) ? degrees + 9 : 369 - degrees;

            string multiplier;

            if (shotRadius > 99 && shotRadius < 107)
                multiplier = "T";
            else if (shotRadius > 162 && shotRadius < 170)
                multiplier = "D";
            else
                multiplier = "";

            int[] scores =
            {
                20, 1, 18, 4,
                13, 6, 10, 15,
                2, 17, 3, 19,
                7, 16, 8, 11,
                14, 9, 12, 5
            };

            return multiplier + scores[(int)Math.Floor(degrees / 18) % 20];
        }
    }
}

/* Link for the Kata: https://www.codewars.com/kata/5870db16056584eab0000006/csharp
 * Here is the description for Let's Play Darts kata:

Create your own mechanical dartboard that gives back your score based on the coordinates of your dart.

 * Task:
Use the scoring rules for a standard dartboard:

 * Finish method:
public string GetScore(double x, double y);

The coordinates are `(x, y)` are always relative to the center of the board (0, 0).
The unit is millimeters. If you throw your dart 5 centimeters to the left and 3 centimeters below,
it is written as:
var score = dartboard.GetScore(-50, -30);

 * Possible scores are:
Outside of the board: `"X"`
Bull's eye: `"DB"`
Bull: `"SB"`
A single number, example: `"10"`
A triple number: `"T10"`
A double number: `"D10"`

A throw that ends exactly on the border of two sections results in a bounce out.
You can ignore this because all the given coordinates of the tests are within the sections.

The diameters of the circles on the dartboard are:

Bull's eye: `12.70 mm`
Bull: `31.8 mm`
Triple ring inner circle: `198 mm`
Triple ring outer circle: `214 mm`
Double ring inner circle: `324 mm`
Double ring outer circle: `340 mm`
*/