using System;
using DuchessOfDunderly.DAL.Models;

namespace DuchessOfDunderly.Discount.CurrentLTV
{
    public class Discount : IExceptionDiscount
    {
        public double CalculateDiscount(Loan source)
        {
            double result = 0;
            switch (source.FitchProductCategory.ToUpper())
            {
                case "U":
                    result = 0;
                    break;
                case "P":
                    result = 2;
                    break;
                case "N":
                    result = 4;
                    break;
                case "L":
                    result = 6;
                    break;
                case "M":
                    result = 8;
                    break;
                case "B":
                    result = 10;
                    break;
            }
            return result;
        }        
    }
}