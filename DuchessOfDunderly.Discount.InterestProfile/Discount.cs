using System;
using DuchessOfDunderly.DAL.Models;

namespace DuchessOfDunderly.Discount.InterestProfile
{
    public class Discount : IExceptionDiscount
    {
        public double CalculateDiscount(Loan source)
        {
            double result = 0;
            switch (source.FitchProductCategory.ToUpper())
            {
                case "U":
                    result = 1;
                    break;
                case "P":
                    result = 1;
                    break;
                case "N":
                    result = 1;
                    break;
                case "L":
                    result = 2;
                    break;
                case "M":
                    result = 2;
                    break;
                case "B":
                    result = 3;
                    break;
            }
            return result;
         }
    }}
