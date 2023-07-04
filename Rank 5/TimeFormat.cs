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