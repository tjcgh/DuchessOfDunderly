using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Collections.Generic;
using DuchessOfDunderly.DAL.Models;
using System.Reflection;

namespace DuchessOfDunderly
{
    class Program
    {
        static LoanGradeCalculator calculator;
        static List<IExceptionRule> rules;

        static void Main(string[] args)
        {
            if(args.Length==0)
            {
                Console.WriteLine("type the input filename with path...");
                return;
            }
            rules = RuleConfiguration.BuildRuleList();
            calculator = new LoanGradeCalculator(args[0], rules);
            calculator.CalculateLoanGrades();
            Console.WriteLine(LoanGrade.Header());
            foreach (LoanGrade grade in calculator.grades)
                Console.WriteLine(grade.ToString());
        }
    }
}
