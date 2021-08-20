using VisitorPattern.Models;

namespace VisitorPattern.Visitors
{
    public class AssetNetWorth: IAssetVisitor
    {
        private int _netWorth;
        public void Visit(BankAccount bankAccount)
        {
            _netWorth += bankAccount.Balance;
            _netWorth += bankAccount.Loan;
        }

        public void Visit(Car car)
        {
            _netWorth += car.Price;
        }

        public void Visit(House house)
        {
            _netWorth += house.Price;
        }

        public int Result => _netWorth;
    }
}