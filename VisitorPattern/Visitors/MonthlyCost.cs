using VisitorPattern.Models;

namespace VisitorPattern.Visitors
{
    public class AssetMonthlyCost: IAssetVisitor
    {
        private int _monthlyCost;
        public void Visit(BankAccount bankAccount)
        {
            _monthlyCost += bankAccount.MonthlyReturnLoan;
        }

        public void Visit(Car car)
        {
            _monthlyCost += car.MonthlyCost;
        }

        public void Visit(House house)
        {
            _monthlyCost += house.MonthlyCost;
            _monthlyCost -= house.MonthlyRentIncome;
        }

        public int GetMonthlyCost()
        {
            return _monthlyCost;
        }
    }
}