using System;
using System.Collections.Generic;
using DuchessOfDunderly.DAL.Models;
using DuchessOfDunderly.DAL.Parsers;

namespace DuchessOfDunderly.DAL
{
    public class Context
    {
        public List<Loan> Loans { get; set; }
        CSVParser Parser; 

        public Context()
        {
            Loans = new List<Loan>();
            Parser = new CSVParser();
        }

        public Context(string filepath) : this()
        {
            Loans = Parser.BuildRepository<Loan>(filepath);
        }
    }
}
