using System;

namespace PremiumCalculator.Api.Common
{
    public static class DateTimeExtensions
    {
        public static int Age(this DateTime source)
        {
            if (DateTime.Today.Month < source.Month ||
            DateTime.Today.Month == source.Month &&
            DateTime.Today.Day < source.Day)
            {
                return DateTime.Today.Year - source.Year - 1;
            }

            return DateTime.Today.Year - source.Year;
        }
    }
}
