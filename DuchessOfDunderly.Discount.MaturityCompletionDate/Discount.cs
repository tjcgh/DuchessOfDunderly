using System;
using DuchessOfDunderly.DAL.Models;

namespace DuchessOfDunderly.Discount.MaturityCompletionDate
{
    public class Discount : IExceptionDiscount
    {
        public double CalculateDiscount(Loan source)
        {
            double result = 0;
            switch (source.FitchProductCategory.ToUpper())
            {
                case "U":
                    result = 4;
                    break;
                case "P":
                    result = 4;
                    break;
                case "N":
                    result = 4;
                    break;
                case "L":
                    result = 4;
                    break;
                case "M":
                    result = 4;
                    break;
                case "B":
                    result = 4;
                    break;
            }
            return result;
        }
    }
}