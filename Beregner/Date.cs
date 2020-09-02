using System;
using System.Collections.Generic;
using System.Text;

namespace Beregner
{
    public static class Date
    {
        public static DateTime Today { get; } = DateTime.Today;
        public static DateTime FistDay { get; } = DateTime.Parse($"01-01-{Today .Year}");
        public static int CalculateDaysFormBeginningOfTheYear()
        {
            return (int)Math.Floor((Today.Ticks - FistDay.Ticks) / (24 * 60 * 60 * 1e7));
        }
        public static double CalculateMonthsFormBeginningOfTheYear()
        {
            return (double)CalculateDaysFormBeginningOfTheYear() / (365 / 12);
        }
    }
}
