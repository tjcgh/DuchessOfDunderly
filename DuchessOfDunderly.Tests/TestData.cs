using System;
using System.Collections.Generic;
using DuchessOfDunderly.DAL.Models;

namespace DuchessOfDunderly.Tests
{
    public class TestData
    {
        public static IEnumerable<object[]> CurrentLTV
        {
            get
            {
                yield return new object[] { new Loan { CurrentLTV = 2.0, OriginalLTV = 1.0, FitchProductCategory = "U" }, 0 };
                yield return new object[] { new Loan { CurrentLTV = 2.0, OriginalLTV = 1.0, FitchProductCategory = "P" }, 2 };
                yield return new object[] { new Loan { CurrentLTV = 2.0, OriginalLTV = 1.0, FitchProductCategory = "N" }, 4 };
                yield return new object[] { new Loan { CurrentLTV = 2.0, OriginalLTV = 1.0, FitchProductCategory = "L" }, 6 };
                yield return new object[] { new Loan { CurrentLTV = 2.0, OriginalLTV = 1.0, FitchProductCategory = "M" }, 8 };
                yield return new object[] { new Loan { CurrentLTV = 2.0, OriginalLTV = 1.0, FitchProductCategory = "B" }, 10 };

                yield return new object[] { new Loan { CurrentLTV = 1.0, OriginalLTV = 1.0, FitchProductCategory = "U" }, 0 };
                yield return new object[] { new Loan { CurrentLTV = 1.0, OriginalLTV = 1.0, FitchProductCategory = "P" }, 0 };
                yield return new object[] { new Loan { CurrentLTV = 1.0, OriginalLTV = 1.0, FitchProductCategory = "N" }, 0 };
                yield return new object[] { new Loan { CurrentLTV = 1.0, OriginalLTV = 1.0, FitchProductCategory = "L" }, 0 };
                yield return new object[] { new Loan { CurrentLTV = 1.0, OriginalLTV = 1.0, FitchProductCategory = "M" }, 0 };
                yield return new object[] { new Loan { CurrentLTV = 1.0, OriginalLTV = 1.0, FitchProductCategory = "B" }, 0 };
            }
        }

        public static IEnumerable<object[]> IncomePercent
        {
            get
            {
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1212.0, IncomeBorrower2 = 0.0, FitchProductCategory = "U" }, 0 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1212.0, IncomeBorrower2 = 0.0, FitchProductCategory = "P" }, 0 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1212.0, IncomeBorrower2 = 0.0, FitchProductCategory = "N" }, 0 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1212.0, IncomeBorrower2 = 0.0, FitchProductCategory = "L" }, 0 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1212.0, IncomeBorrower2 = 0.0, FitchProductCategory = "M" }, 0 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1212.0, IncomeBorrower2 = 0.0, FitchProductCategory = "B" }, 0 };

                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1199.0, IncomeBorrower2 = 0.0, FitchProductCategory = "U" }, 0 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1199.0, IncomeBorrower2 = 0.0, FitchProductCategory = "P" }, 2 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1199.0, IncomeBorrower2 = 0.0, FitchProductCategory = "N" }, 4 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1199.0, IncomeBorrower2 = 0.0, FitchProductCategory = "L" }, 6 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1199.0, IncomeBorrower2 = 0.0, FitchProductCategory = "M" }, 8 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1199.0, IncomeBorrower2 = 0.0, FitchProductCategory = "B" }, 10 };

                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1080.0, IncomeBorrower2 = 0.0, FitchProductCategory = "U" }, 0 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1080.0, IncomeBorrower2 = 0.0, FitchProductCategory = "P" }, 2 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1080.0, IncomeBorrower2 = 0.0, FitchProductCategory = "N" }, 4 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1080.0, IncomeBorrower2 = 0.0, FitchProductCategory = "L" }, 6 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1080.0, IncomeBorrower2 = 0.0, FitchProductCategory = "M" }, 8 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1080.0, IncomeBorrower2 = 0.0, FitchProductCategory = "B" }, 10 };

                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1079.0, IncomeBorrower2 = 0.0, FitchProductCategory = "U" }, 0 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1079.0, IncomeBorrower2 = 0.0, FitchProductCategory = "P" }, 3 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1079.0, IncomeBorrower2 = 0.0, FitchProductCategory = "N" }, 6 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1079.0, IncomeBorrower2 = 0.0, FitchProductCategory = "L" }, 10 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1079.0, IncomeBorrower2 = 0.0, FitchProductCategory = "M" }, 13 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 1079.0, IncomeBorrower2 = 0.0, FitchProductCategory = "B" }, 20 };
            
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 959.0, IncomeBorrower2 = 0.0, FitchProductCategory = "U" }, 1 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 959.0, IncomeBorrower2 = 0.0, FitchProductCategory = "P" }, 5 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 959.0, IncomeBorrower2 = 0.0, FitchProductCategory = "N" }, 9 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 959.0, IncomeBorrower2 = 0.0, FitchProductCategory = "L" }, 14 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 959.0, IncomeBorrower2 = 0.0, FitchProductCategory = "M" }, 21 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 959.0, IncomeBorrower2 = 0.0, FitchProductCategory = "B" }, 30 };
            
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 720.0, IncomeBorrower2 = 0.0, FitchProductCategory = "U" }, 3 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 720.0, IncomeBorrower2 = 0.0, FitchProductCategory = "P" }, 12 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 720.0, IncomeBorrower2 = 0.0, FitchProductCategory = "N" }, 20 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 720.0, IncomeBorrower2 = 0.0, FitchProductCategory = "L" }, 30 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 720.0, IncomeBorrower2 = 0.0, FitchProductCategory = "M" }, 40 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 720.0, IncomeBorrower2 = 0.0, FitchProductCategory = "B" }, 50 };

                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 300.0, IncomeBorrower2 = 0.0, FitchProductCategory = "U" }, 10 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 300.0, IncomeBorrower2 = 0.0, FitchProductCategory = "P" }, 20 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 300.0, IncomeBorrower2 = 0.0, FitchProductCategory = "N" }, 40 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 300.0, IncomeBorrower2 = 0.0, FitchProductCategory = "L" }, 50 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 300.0, IncomeBorrower2 = 0.0, FitchProductCategory = "M" }, 60 };
                yield return new object[] { new Loan { CMS = 100.0, IncomeBorrower1 = 300.0, IncomeBorrower2 = 0.0, FitchProductCategory = "B" }, 80 };
            }
        }

        public static IEnumerable<object[]> InterestProfile
        {
            get
            {
                yield return new object[] { new Loan { CurrentIndex = "FIX", CurrentMargin = 2.0, CurrentInterestRate = 2.01, FitchProductCategory = "U" }, 1 };
                yield return new object[] { new Loan { CurrentIndex = "FIX", CurrentMargin = 2.0, CurrentInterestRate = 2.01, FitchProductCategory = "P" }, 1 };
                yield return new object[] { new Loan { CurrentIndex = "FIX", CurrentMargin = 2.0, CurrentInterestRate = 2.01, FitchProductCategory = "N" }, 1 };
                yield return new object[] { new Loan { CurrentIndex = "FIX", CurrentMargin = 2.0, CurrentInterestRate = 2.01, FitchProductCategory = "L" }, 2 };
                yield return new object[] { new Loan { CurrentIndex = "FIX", CurrentMargin = 2.0, CurrentInterestRate = 2.01, FitchProductCategory = "M" }, 2 };
                yield return new object[] { new Loan { CurrentIndex = "FIX", CurrentMargin = 2.0, CurrentInterestRate = 2.01, FitchProductCategory = "B" }, 3 };

                yield return new object[] { new Loan { CurrentIndex = "FIX", CurrentMargin = 2.0, CurrentInterestRate = 2.001, FitchProductCategory = "U" }, 0 };
                yield return new object[] { new Loan { CurrentIndex = "FIX", CurrentMargin = 2.0, CurrentInterestRate = 2.001, FitchProductCategory = "P" }, 0 };
                yield return new object[] { new Loan { CurrentIndex = "FIX", CurrentMargin = 2.0, CurrentInterestRate = 2.001, FitchProductCategory = "N" }, 0 };
                yield return new object[] { new Loan { CurrentIndex = "FIX", CurrentMargin = 2.0, CurrentInterestRate = 2.001, FitchProductCategory = "L" }, 0 };
                yield return new object[] { new Loan { CurrentIndex = "FIX", CurrentMargin = 2.0, CurrentInterestRate = 2.001, FitchProductCategory = "M" }, 0 };
                yield return new object[] { new Loan { CurrentIndex = "FIX", CurrentMargin = 2.0, CurrentInterestRate = 2.001, FitchProductCategory = "B" }, 0 };

                yield return new object[] { new Loan { CurrentIndex = "FI", CurrentMargin = 2.0, CurrentInterestRate = 2.0, FitchProductCategory = "U" }, 0 };
                yield return new object[] { new Loan { CurrentIndex = "FI", CurrentMargin = 2.0, CurrentInterestRate = 2.0, FitchProductCategory = "P" }, 0 };
                yield return new object[] { new Loan { CurrentIndex = "FI", CurrentMargin = 2.0, CurrentInterestRate = 2.0, FitchProductCategory = "N" }, 0 };
                yield return new object[] { new Loan { CurrentIndex = "FI", CurrentMargin = 2.0, CurrentInterestRate = 2.0, FitchProductCategory = "L" }, 0 };
                yield return new object[] { new Loan { CurrentIndex = "FI", CurrentMargin = 2.0, CurrentInterestRate = 2.0, FitchProductCategory = "M" }, 0 };
                yield return new object[] { new Loan { CurrentIndex = "FI", CurrentMargin = 2.0, CurrentInterestRate = 2.0, FitchProductCategory = "B" }, 0 };

                yield return new object[] { new Loan { CurrentIndex = "fix", CurrentMargin = 2.0, CurrentInterestRate = 2.01, FitchProductCategory = "U" }, 1 };
                yield return new object[] { new Loan { CurrentIndex = "fix", CurrentMargin = 2.0, CurrentInterestRate = 2.01, FitchProductCategory = "P" }, 1 };
                yield return new object[] { new Loan { CurrentIndex = "fix", CurrentMargin = 2.0, CurrentInterestRate = 2.01, FitchProductCategory = "N" }, 1 };
                yield return new object[] { new Loan { CurrentIndex = "fix", CurrentMargin = 2.0, CurrentInterestRate = 2.01, FitchProductCategory = "L" }, 2 };
                yield return new object[] { new Loan { CurrentIndex = "fix", CurrentMargin = 2.0, CurrentInterestRate = 2.01, FitchProductCategory = "M" }, 2 };
                yield return new object[] { new Loan { CurrentIndex = "fix", CurrentMargin = 2.0, CurrentInterestRate = 2.01, FitchProductCategory = "B" }, 3 };
            }
        }

        public static IEnumerable<object[]> MaturityCompletionDate
        {
            get
            {
                yield return new object[] { new Loan { MaturityDate = DateTime.MinValue, CompletionDate = DateTime.MaxValue, FitchProductCategory = "U" }, 4 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MinValue, CompletionDate = DateTime.MaxValue, FitchProductCategory = "P" }, 4 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MinValue, CompletionDate = DateTime.MaxValue, FitchProductCategory = "N" }, 4 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MinValue, CompletionDate = DateTime.MaxValue, FitchProductCategory = "L" }, 4 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MinValue, CompletionDate = DateTime.MaxValue, FitchProductCategory = "M" }, 4 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MinValue, CompletionDate = DateTime.MaxValue, FitchProductCategory = "B" }, 4 };

                yield return new object[] { new Loan { MaturityDate = DateTime.MinValue, CompletionDate = DateTime.MinValue, FitchProductCategory = "U" }, 0 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MinValue, CompletionDate = DateTime.MinValue, FitchProductCategory = "P" }, 0 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MinValue, CompletionDate = DateTime.MinValue, FitchProductCategory = "N" }, 0 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MinValue, CompletionDate = DateTime.MinValue, FitchProductCategory = "L" }, 0 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MinValue, CompletionDate = DateTime.MinValue, FitchProductCategory = "M" }, 0 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MinValue, CompletionDate = DateTime.MinValue, FitchProductCategory = "B" }, 0 };

                yield return new object[] { new Loan { MaturityDate = DateTime.MaxValue, CompletionDate = DateTime.MinValue, FitchProductCategory = "U" }, 0 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MaxValue, CompletionDate = DateTime.MinValue, FitchProductCategory = "P" }, 0 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MaxValue, CompletionDate = DateTime.MinValue, FitchProductCategory = "N" }, 0 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MaxValue, CompletionDate = DateTime.MinValue, FitchProductCategory = "L" }, 0 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MaxValue, CompletionDate = DateTime.MinValue, FitchProductCategory = "M" }, 0 };
                yield return new object[] { new Loan { MaturityDate = DateTime.MaxValue, CompletionDate = DateTime.MinValue, FitchProductCategory = "B" }, 0 };
            }
        }





    }
}
