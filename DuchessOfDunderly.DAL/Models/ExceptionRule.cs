namespace DuchessOfDunderly.DAL.Models
{
    public abstract class ExceptionRule
    {
        protected readonly IExceptionDiscount exceptionDiscount;

        public ExceptionRule(IExceptionDiscount exceptionDiscount)
        {
            this.exceptionDiscount = exceptionDiscount;       
        }

        abstract public LoanException CalculateLoanException(Loan source);
    }
}