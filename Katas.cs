using System;
using System.Linq;
using System.Collections.Generic;

namespace Codewars
{
    public class KataTesting
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(RomanNumerals.Decode("MDCLXVI"));
            Console.WriteLine(RomanNumerals.Encode(1666));
        }
    }
}