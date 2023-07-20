namespace Codewars
{
    public static class Darts
    {
        public static string GetScore(double x, double y)
        {
            double shotRadius = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            double wholeRadius = 340;

            double difference = shotRadius - wholeRadius;

            if (shotRadius < 6.35)
                return "DB";
            if (shotRadius < 15.9)
                return "SB";
            if (shotRadius > 170)
                return "X";


            //string[] 

            return "";
        }
    }
}

/*
 * Outside of the board: `"X"`
Bull's eye: `"DB"`
Bull: `"SB"`
A single number, example: `"10"`
A triple number: `"T10"`
A double number: `"D10"`
*/