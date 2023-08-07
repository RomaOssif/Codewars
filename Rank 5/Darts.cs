namespace Codewars
{
    public static class Darts
    {
        public static string GetScore(double x, double y)
        {
            double shotRadius = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            double wholeRadius = 170;

            //double difference = wholeRadius - shotRadius;

            if (shotRadius < 6.35)
                return "DB";
            if (shotRadius < 15.9)
                return "SB";
            if (shotRadius > 170)
                return "X";


            double circleX = 0;
            double circleY = 170;

            double cosZ = (x * circleX + y * circleY) / (shotRadius * wholeRadius);

            double degreesRad = Math.Acos(cosZ);

            double degrees = degreesRad * (180 / Math.PI);

            return degrees.ToString();
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
difference^2 = (x1-x2)^2 + (y1-y2)^2
wholeRadius^2 = x2^2 + y^2
*/

// 5 3
// 12 6
// 7 3

/*
 * v1 = x1, y1
 * v2 = y2, y2
 * 
 * n1 = -y1, x1
 * 
 * projection = x2 * n1.x + y2 * n1.y
 * Or rather:
 * projection = x2 * (-y1) + y2 * x1
 * bool areClockWise(v1, v2)
 * return (-v1.y*v2.x + v2.y*v1.x) < 0
 * 
 * 
 * 
 * Every part takes 18 degrees between 20 sectors
 * so we moved the vector by 9 degrees?
 */