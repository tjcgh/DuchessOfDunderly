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
            if(args.Length!=2)
            {
                Console.WriteLine("provide the fully qualified input and output filenames as an arguments to the program...");
                return;
            }
            Console.WriteLine("Calculating Loan Grades...");
            rules = RuleConfiguration.BuildRuleList();
            calculator = new LoanGradeCalculator(args[0], rules);
            calculator.CalculateLoanGrades();
            using (StreamWriter outputFile = new StreamWriter(args[1]))
            {
                outputFile.WriteLine(LoanGrade.Header());
                foreach (LoanGrade grade in calculator.grades)
                    outputFile.WriteLine(grade.ToString());
            }
            Console.WriteLine("Done...");
        }
    }
}
