using System;
using DuchessOfDunderly.DAL.Models;

namespace DuchessOfDunderly.Discount.IncomePercent
{
    public class Discount : IExceptionDiscount
    {
        public double CalculateDiscount(Loan source)
        {
            double result = 0;
            double total_monthly_income = (source.IncomeBorrower1 + source.IncomeBorrower2) / 12;
            double difference = source.CMS - total_monthly_income;
            double percent = (difference / source.CMS) * 100;
            switch (source.FitchProductCategory.ToUpper())
            {
                case "U":
                    result = scaleValue(percent, new int[] { 0, 0, 1, 3, 10 });
                    break;
                case "P":
                    result = scaleValue(percent, new int[] { 2, 3, 5, 12, 20 });
                    break;
                case "N":
                    result = scaleValue(percent, new int[] { 4, 6, 9, 20, 40 });
                    break;
                case "L":
                    result = scaleValue(percent, new int[] { 6, 10, 14, 30, 50 });
                    break;
                case "M":
                    result = scaleValue(percent, new int[] { 8, 13, 21, 40, 60 });
                    break;
                case "B":
                    result = scaleValue(percent, new int[] { 10, 20, 30, 50, 80 });
                    break;
            }
            return result;
        }

        private int scaleValue(double source, int[] scale)
        {
            if (scale == null || scale.Length < 5)
                return 0;
            if (source >= 0 && source <= 10)
                return scale[0];
            else if (source > 10 && source <= 20)
                return scale[1];
            else if (source > 20 && source <= 30)
                return scale[2];
            else if (source > 30 && source <= 50)
                return scale[3];
            else if (source > 50 && source <= 100)
                return scale[4];
            return 0;
        }
    }
}