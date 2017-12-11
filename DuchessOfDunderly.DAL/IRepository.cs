using System;
using System.Collections.Generic;
using DuchessOfDunderly.DAL.Models;
                       
namespace DuchessOfDunderly.DAL
{
    public interface IRepository<T> where T : EntityData
    {
        List<Loan> Get();
        Loan GetByID(double id);
        void Insert(Loan item);
        void Delete(double id);
        void Update(Loan item);
        void Save();
    }
}