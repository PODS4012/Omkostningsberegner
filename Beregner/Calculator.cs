using System;
using System.Collections.Generic;
using System.Text;

namespace Beregner
{
    public static class Calculator
    {
        public static double AverageIncome(double totalIncome, double MonthToDate)
        {
            return totalIncome / MonthToDate;
        }
        public static double AverageConsumption(double totalConsumption, double MonthToDate)
        {
            return totalConsumption / MonthToDate;
        }
        public static double SavingsRate(double totalIncome, double totalConsumption)
        {
            return (totalIncome - totalConsumption) / totalIncome;
        }
    }
}
