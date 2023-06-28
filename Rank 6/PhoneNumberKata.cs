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