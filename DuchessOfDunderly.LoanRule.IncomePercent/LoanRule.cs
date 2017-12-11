using System;
using DuchessOfDunderly.DAL.Models;

namespace DuchessOfDunderly.LoanRule.IncomePercent
{
    public class LoanRule : ExceptionRule, IExceptionRule
    {
        public LoanRule(IExceptionDiscount exceptionDiscount) : base(exceptionDiscount)
        {
        }

        public override LoanException CalculateLoanException(Loan source)
        {
            LoanException result = new LoanException();
            double total_monthly_income = (source.IncomeBorrower1 + source.IncomeBorrower2) / 12;
            if (source.CMS > total_monthly_income)
                result.Trigger(4, exceptionDiscount.CalculateDiscount(source));

            return result;
        }
    }
}
