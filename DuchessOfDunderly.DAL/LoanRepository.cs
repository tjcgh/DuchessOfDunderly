using System;
using System.Collections.Generic;
using DuchessOfDunderly.DAL.Models;

namespace DuchessOfDunderly.DAL
{
    public class LoanRepository : IRepository<Loan>
    {
        private Context context;

        public LoanRepository(string filepath)
        {
            this.context = new Context(filepath);
        }
        public LoanRepository(Context context)
        {
            this.context = context;
        }

        public List<Loan> Get()
        {
            return context.Loans;
        }

        public Loan GetByID(double id)
        {
            return new Loan();
        }

        public void Insert(Loan item)
        {
            context.Loans.Add(item);
        }

        public void Delete(double id)
        {
            Loan item = context.Loans.Find(p=>p.Id.EqualsExactly(id));
            context.Loans.Remove(item);
        }

        public void Update(Loan item)
        {
            Loan source = context.Loans.Find(p => p.Id.EqualsExactly(item.Id));
            context.Loans.Remove(source);
            context.Loans.Add(item);
        }

        public void Save()
        {
        }

    }
}