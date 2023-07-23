namespace Codewars
{
    public class CollatzKata
    {
        public static string Collatz(int number)
        {
            if (number == 1)
                return "1";

            List<int> list = new List<int>()
            { 
                number
            };

            while (number != 1)
            {
                number = (number % 2 == 0) ? number/2 : 3*number + 1;
                
                list.Add(number);
            }

            return string.Join("->", list);
        }
    }
}

/* Link for the Kata: https://www.codewars.com/kata/5286b2e162056fd0cb000c20
 * Here is the description for Collatz kata:

 * Preface
A collatz sequence, starting with a positive integern, is found by repeatedly applying the following function to n until n == 1 :

n/2, if n is even
3n+1, if n is odd



 * The Problem
Create a function collatz that returns a collatz sequence string starting with the positive integer argument
passed into the function, in the following form:

"X0->X1->...->XN"

Where Xi is each iteration of the sequence and N is the length of the sequence.

 * Sample Input
Input: 4
Output: "4->2->1"

Input: 3
Output: "3->10->5->16->8->4->2->1"

Don't worry about invalid input. Arguments passed into the function are guaranteed to be valid integers >= 1.
*/