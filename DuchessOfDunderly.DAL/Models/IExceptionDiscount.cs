namespace DuchessOfDunderly.DAL.Models
{
    public interface IExceptionDiscount
    {
        double CalculateDiscount(Loan source);
    }
}