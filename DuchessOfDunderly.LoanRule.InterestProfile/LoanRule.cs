using System;
using DuchessOfDunderly.DAL.Models;
using DuchessOfDunderly.DAL;

namespace DuchessOfDunderly.LoanRule.InterestProfile
{
    public class LoanRule : ExceptionRule, IExceptionRule
    {
        public LoanRule(IExceptionDiscount exceptionDiscount) : base(exceptionDiscount)
        {
        }

        public override LoanException CalculateLoanException(Loan source)
        {
            LoanException result = new LoanException();
            if (source.CurrentIndex.Equals("FIX",StringComparison.InvariantCultureIgnoreCase) && 
                (source.CurrentMargin.NotEqual(source.CurrentInterestRate)))
                result.Trigger(2, exceptionDiscount.CalculateDiscount(source));

            return result;
        }
    }
}
