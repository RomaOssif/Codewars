using System;
using System.Linq;
using System.Collections.Generic;

namespace Codewars
{
    public class KataTesting
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(StripCommentsKata.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));
        }
    }
}