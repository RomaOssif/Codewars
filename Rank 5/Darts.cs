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