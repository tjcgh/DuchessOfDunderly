using DuchessOfDunderly.DAL.Models;

namespace DuchessOfDunderly.LoanRule.CurrentLTV
{
    public class LoanRule : ExceptionRule, IExceptionRule
    {
        public LoanRule(IExceptionDiscount exceptionDiscount) : base(exceptionDiscount)
        {
        }

        public override LoanException CalculateLoanException(Loan source)
        {
            LoanException result = new LoanException();
            if (source.CurrentLTV > source.OriginalLTV)
                result.Trigger(3, exceptionDiscount.CalculateDiscount(source));
//                result.Trigger(3, CalculateDiscount(source));

            return result;
        }

        /*
        private double CalculateDiscount(Loan source)
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
        */

    }
}
