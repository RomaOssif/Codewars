namespace Codewars
{
    public class PhoneNumberKata
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            return $"({string.Join("", numbers.Take(3))}) " +
                   $"{string.Join("", numbers.Skip(3).Take(3))}-" +
                   $"{string.Join("", numbers.Skip(6))}";
        }
    }
}

/* Link for the Kata: https://www.codewars.com/kata/525f50e3b73515a6db000b83
 * Here is the description for Create Phone Number kata:

Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

Example
Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
The returned format must be correct in order to complete this challenge.

Don't forget the space after the closing parentheses!
*/