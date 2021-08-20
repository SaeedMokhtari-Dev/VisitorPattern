using VisitorPattern.Models;

namespace VisitorPattern.Visitors
{
    public interface IAssetVisitor
    {
        void Visit(BankAccount bankAccount);
        void Visit(Car car);
        void Visit(House house);
    }
}