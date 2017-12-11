using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Extensions;

namespace DuchessOfDunderly.DAL.Models
{
    public class LoanGrade
    {
        public double Id { get; set; }
        public SortedList<double, LoanException> Exceptions { get; set; }
        public int Grade { get; set; }

        public LoanGrade()
        {
            Id = 0;
            Exceptions = new SortedList<double, LoanException>();
            Grade = 0;
        }
        public LoanGrade(double id) : this()
        {
            this.Id = id;
        }

        public static string Header()
        {
            return "Loan ID\tLoan Grade\tException IDs";
        }

        public void AddException(LoanException exception)
        {
            Exceptions.Add(exception.Id, exception);
        }

        public override string ToString()
        {
            string sExceptions = "";
            foreach (LoanException item in Exceptions.Values)
                sExceptions += string.Format("{0}|", item.Id);
            if (sExceptions.Length > 0)
                sExceptions = sExceptions.Substring(0, sExceptions.Length - 1);
            return string.Format("{0}\t{1}\t{2}", Id, Grade, sExceptions);
        }

        public void Recalculate()
        {
            double totalDiscount = 0;
            foreach (LoanException item in Exceptions.Values)
            {
                totalDiscount += item.Discount;
            }
            Grade = (int)(100 - totalDiscount);
            if (Grade < 0)
                Grade = 0;
            else if (Grade > 100)
                Grade = 100;
        }

    }
}