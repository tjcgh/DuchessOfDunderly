namespace DuchessOfDunderly.DAL.Models
{
    public interface IExceptionRule
    {
        LoanException CalculateLoanException(Loan source);
    }
}