using System;

namespace DateTimeAssignment
{
    class TimeZoneDisplay
    {
        public void DisplayTimeInTimeZones()
        {
            DateTimeOffset utcNow = DateTimeOffset.UtcNow;
            Console.WriteLine($"UTC Time: {utcNow:yyyy-MM-dd HH:mm:ss}");

            // GMT (Greenwich Mean Time) - Same as UTC
            TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcNow, gmtZone);
            Console.WriteLine($"GMT Time: {gmtTime:yyyy-MM-dd HH:mm:ss}");

            // IST (Indian Standard Time)
            TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcNow, istZone);
            Console.WriteLine($"IST Time: {istTime:yyyy-MM-dd HH:mm:ss}");

            // PST (Pacific Standard Time)
            TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcNow, pstZone);
            Console.WriteLine($"PST Time: {pstTime:yyyy-MM-dd HH:mm:ss}");
        }
    }
}
