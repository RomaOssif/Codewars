namespace Codewars
{
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            int _hours = 0, _minutes = 0, _seconds = 0;

            while (seconds / 3600 != 0)
            {
                _hours++;

                seconds -= 3600;
            }

            while (seconds / 60 != 0)
            {
                _minutes++;

                seconds -= 60;
            }

            _seconds = seconds;

            return (_hours   < 10? "0" : "") + $"{_hours}:"   + 
                   (_minutes < 10? "0" : "") + $"{_minutes}:" +
                   (_seconds < 10? "0" : "") + $"{_seconds}";
        }
    }
}