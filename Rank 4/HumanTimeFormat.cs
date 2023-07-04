using System.Linq;
using System.Collections.Generic;

namespace Codewars
{
    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            if (seconds == 0)
                return "now";

            int _years = seconds / 31_536_000;
            int _days = seconds / 86_400 % 365;
            int _hours = seconds / 3600 % 24;
            int _minutes = seconds / 60 % 60;
            int _seconds = seconds % 60;

            List<string> time = new List<string>();

            if(_years > 0)
                time.Add($"{_years} {(_years > 1? "years" : "year" )}");

            if (_days > 0)
                time.Add(_days.ToString() + " " + (_days > 1 ? "days" : "day"));

            if (_hours > 0)
                time.Add(_hours.ToString() + " " + (_seconds > 1 ? "hours" : "hour"));

            if (_minutes > 0)
                time.Add(_minutes.ToString() + " " + (_minutes > 1 ? "minutes" : "minute"));

            if (_seconds > 0)
                time.Add(_seconds.ToString() + " " + (_seconds > 1 ? "seconds" : "second"));


            if (time.Count >= 3)
            {
                return $"{string.Join(", ", time.Take(time.Count - 1))} and {time[time.Count - 1]}";
            }

            else if (time.Count == 2)
            {
                return string.Join(" and ", time);
            }

            else
            {
                return time[0];
            }
        }
    }
}