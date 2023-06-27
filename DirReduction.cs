using Codewars;

namespace Codewars
{
    public class DirReduction
    {
        private static bool areOpposite(string direction1, string direction2)
        {
            if (direction1 == "NORTH" && direction2 == "SOUTH")
                return true;
            if (direction1 == "SOUTH" && direction2 == "NORTH")
                return true;

            if (direction1 == "WEST" && direction2 == "EAST")
                return true;
            if (direction1 == "EAST" && direction2 == "WEST")
                return true;

            return false;
        }

        public static string[] dirReduc(string[] arr)
        {
            var list = new List<string>(arr);

            for (int i = 1; i < list.Count; i++)
            {
                if (list.Count == 0)
                    break;

                if (areOpposite(list[i-1], list[i]))
                {
                    list.RemoveAt(i-1);
                    list.RemoveAt(i - 1);

                    i = 0;
                }
            }

            return list.ToArray();
        }
    }
}

//Test:

//foreach (var direction in DirReduction.dirReduc(new string[] { "EAST", "NORTH", "SOUTH", "WEST", "SOUTH", "EAST" }))
//    Console.WriteLine(direction);