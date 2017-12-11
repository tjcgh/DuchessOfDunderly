using System;
namespace DuchessOfDunderly.DAL.Models
{
    public class Loan : EntityData, IArraySourced
    {
        //        public DateTime DataExtractDate { get; set; }
        //        public double Portfolio { get; set; }
        public double LoanID { get; set; }
        public double PropertyID { get; set; }
        //        public double OriginalBalance { get; set; }
        //        public double CurrentBalance { get; set; }
        //        public double ArrearsBalance { get; set; }
        //        public double MonthsInArrears { get; set; }
        public double CMS { get; set; }
        public double CurrentLTV { get; set; }
        public double OriginalLTV { get; set; }
        //        public double LatestValuationAmount { get; set; }
        //        public DateTime LatestValuationDate { get; set; }
        public string FitchProductCategory { get; set; }
        //        public string OriginatorProductCategory { get; set; }
        //        public string FurtherAdvance { get; set; }
        public DateTime CompletionDate { get; set; }
        //        public string OriginalTerm { get; set; }
        public DateTime MaturityDate { get; set; }
        //        public string InterestRateType { get; set; }
        public string CurrentIndex { get; set; }
        //        public string ReversionaryIndex { get; set; }
        public double CurrentInterestRate { get; set; }
        public double CurrentMargin { get; set; }
        //        public double ReversionaryMargin { get; set; }
        //        public DateTime ReversionDate { get; set; }
        //        public string LoanPurpose { get; set; }
        //        public string RepaymentType { get; set; }
        //        public string FTBFlag { get; set; }
        //        public string RTBFlag { get; set; }
        //        public string SelfCertFlag { get; set; }
        //        public string PropertyType { get; set; }
        //        public string Occupancy { get; set; }
        //        public string Region { get; set; }
        //        public string Tenure { get; set; }
        //        public string Bankruptcy_Marker { get; set; }
        //        public double NoOfCCJs { get; set; }
        //        public double ValueOfCCJs { get; set; }
        public double IncomeBorrower1 { get; set; }
        public double IncomeBorrower2 { get; set; }
        //        public double IndexReference_Rate { get; set; }
        //        public string Originator { get; set; }
        //        public string PossessionFlag { get; set; }
        public LoanGrade Grade { get; set; }

        public Loan()
        {
            Grade = new LoanGrade();
        }

        public void BuildFromArray(string[] fields)
        {
            LoanID = parseDouble(fields[2]);
            CMS = parseDouble(fields[8]);
            FitchProductCategory = fields[13];
            CompletionDate = parseDate(fields[16]);
            MaturityDate = parseDate(fields[18]);
            CurrentIndex = fields[20];
            CurrentMargin = parseDouble(fields[23]);
            CurrentInterestRate = parseDouble(fields[22]);
            IncomeBorrower1 = parseDouble(fields[38]);
            IncomeBorrower2 = parseDouble(fields[39]);
        }

        private DateTime parseDate(string source)
        {
            DateTime result = DateTime.MinValue;
            if (source.Length == 6)
                source += "01";
            DateTime.TryParseExact(source,
                                   "yyyyMMdd",
                                   System.Globalization.CultureInfo.InvariantCulture,
                                   System.Globalization.DateTimeStyles.None,
                                   out result);
            return result;
        }

        private double parseDouble(string source)
        {
            double target = 0;
            double.TryParse(source, out target);
            return target;
        }

        public string ToStringParseDiag(bool header = false)
        {
            if (header)
                return string.Format("Loan_ID, ComplDate, MatDate, CurrIdx, CurrMargin, CurrIntRate, CurrLTV, OrigLTV, CMS, IncBor1, IncBor2, FitchProdCat");
            return string.Format("LOAN:{0} {1:MM/dd/yyyy}, {2:MM/dd/yyyy}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}", LoanID, CompletionDate, MaturityDate, CurrentIndex, CurrentMargin, CurrentInterestRate, CurrentLTV, OriginalLTV, CMS, IncomeBorrower1, IncomeBorrower2, FitchProductCategory);
        }
    }

}