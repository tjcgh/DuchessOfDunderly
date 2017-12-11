using System;
using Xunit;
using DuchessOfDunderly.DAL.Models;

namespace DuchessOfDunderly.Tests
{
    public class Tests
    {
        [Theory]
        [MemberData("CurrentLTV", MemberType = typeof(TestData))]
        public void CurrentLTV(Loan loan, double expected)
        {
            var rule = new DuchessOfDunderly.LoanRule.CurrentLTV.LoanRule(new Discount.CurrentLTV.Discount());
            LoanException result = rule.CalculateLoanException(loan);
            Assert.Equal(expected, result.Discount);
        }

        [Theory]
        [MemberData("IncomePercent", MemberType = typeof(TestData))]
        public void IncomePercent(Loan loan, double expected)
        {
            var rule = new DuchessOfDunderly.LoanRule.IncomePercent.LoanRule(new Discount.IncomePercent.Discount());
            LoanException result = rule.CalculateLoanException(loan);
            Assert.Equal(expected, result.Discount);
        }
    
        [Theory]
        [MemberData("InterestProfile", MemberType = typeof(TestData))]
        public void InterestProfile(Loan loan, double expected)
        {
            var rule = new DuchessOfDunderly.LoanRule.InterestProfile.LoanRule(new Discount.InterestProfile.Discount());
            LoanException result = rule.CalculateLoanException(loan);
            Assert.Equal(expected, result.Discount);
        }

        [Theory]
        [MemberData("MaturityCompletionDate", MemberType = typeof(TestData))]
        public void MaturityCompletionDate(Loan loan, double expected)
        {
            var rule = new DuchessOfDunderly.LoanRule.MaturityCompletionDate.LoanRule(new Discount.MaturityCompletionDate.Discount());
            LoanException result = rule.CalculateLoanException(loan);
            Assert.Equal(expected, result.Discount);
        }

    }
}
