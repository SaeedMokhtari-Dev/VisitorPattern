using VisitorPattern.Visitors;

namespace VisitorPattern.Models
{
    public class BankAccount: Asset
    {
        public int Balance { get; set; }
        public int Loan { get; set; }
        public int MonthlyReturnLoan { get; set; }
        
        public override void Accept(IAssetVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}