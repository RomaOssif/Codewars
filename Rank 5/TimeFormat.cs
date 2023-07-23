namespace Codewars
{
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            return string.Format("{0:00}:{1:00}:{2:00}", seconds / 3600, seconds / 60 % 60, seconds % 60);
        }
    }
}

/* Link for the Kata: https://www.codewars.com/kata/52685f7382004e774f0001f7
 * Here is the description for Human Readable Time kata:

Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

HH = hours, padded to 2 digits, range: 00 - 99
MM = minutes, padded to 2 digits, range: 00 - 59
SS = seconds, padded to 2 digits, range: 00 - 59
The maximum time never exceeds 359999 (99:59:59)

You can find some examples in the test fixtures.
*/