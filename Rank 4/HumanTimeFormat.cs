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

            int[] timeIntervals =
            {
                seconds / 31_536_000,
                seconds / 86_400 % 365,
                seconds / 3600 % 24,
                seconds / 60 % 60,
                seconds % 60
            };

            string[] timeLiterals = { "year", "day", "hour", "minute", "second" };

            List<string> time = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                if (timeIntervals[i] > 0)
                    time.Add($"{timeIntervals[i]} {timeLiterals[i]}" + (timeIntervals[i] > 1 ? "s" : ""));
            }

            if (time.Count >= 3)
                return string.Join(", ", time.SkipLast(1)) + $" and {time.Last()}";

            else if (time.Count == 2)
                return string.Join(" and ", time);

            else
                return time[0];
        }
    }
}