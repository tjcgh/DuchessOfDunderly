using System;
using DuchessOfDunderly.DAL.Models;

namespace DuchessOfDunderly.LoanRule.MaturityCompletionDate
{
    public class LoanRule : ExceptionRule, IExceptionRule
    {
        public LoanRule(IExceptionDiscount exceptionDiscount) : base(exceptionDiscount)
        {
        }

        public override LoanException CalculateLoanException(Loan source)
        {
            LoanException result = new LoanException();
            if (source.MaturityDate < source.CompletionDate)
                result.Trigger(1, exceptionDiscount.CalculateDiscount(source));

            return result;
        }

        /*
        private double CalculateDiscount(Loan source)
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
        */

    }
}
