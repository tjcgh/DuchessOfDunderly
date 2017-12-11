using System;
namespace DuchessOfDunderly.DAL.Models
{
    public class LoanException
    {
        public int Id { get; set; }
        public double Discount { get; set; }
        public bool Triggered { get; set; }

        public LoanException()
        {
            Id = 0;
            Discount = 0;
            Triggered = false;
        }

        public void Trigger(int id, double discount)
        {
            this.Triggered = true;
            this.Id = id;
            this.Discount = discount;
        }

    }
}