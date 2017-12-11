using System.Collections.Generic;
using DuchessOfDunderly.DAL;
using DuchessOfDunderly.DAL.Models;
using System.Linq;

namespace DuchessOfDunderly
{
    public class LoanGradeCalculator
    {
        List<IExceptionRule> rules;
        LoanRepository repo;
        public List<LoanGrade> grades { get; }

        public LoanGradeCalculator()
        {
            rules = new List<IExceptionRule>();
            grades = new List<LoanGrade>();
        }

        public LoanGradeCalculator(string source, List<IExceptionRule> rules) : this()
        {
            this.rules.AddRange(rules);
            repo = new LoanRepository(source);
        }

        public void CalculateLoanGrades()
        {
            foreach (Loan loan in repo.Get())
            {
                LoanGrade grade = new LoanGrade(loan.LoanID);
                foreach (IExceptionRule rule in rules)
                {
                    LoanException loanException = rule.CalculateLoanException(loan);
                    if (loanException.Triggered)
                        grade.AddException(loanException);
                }
                grade.Recalculate();
                loan.Grade = grade;
                grades.Add(grade);
            }
        }

    }    
}