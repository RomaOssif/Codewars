namespace Codewars
{
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            int _hours = seconds / 3600, _minutes = seconds / 60 % 60, _seconds = seconds % 60;

            return (_hours   < 10? "0" : "") + $"{_hours}:"   + 
                   (_minutes < 10? "0" : "") + $"{_minutes}:" +
                   (_seconds < 10? "0" : "") + $"{_seconds}";
        }
    }
}