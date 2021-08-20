using VisitorPattern.Visitors;

namespace VisitorPattern.Models
{
    public class Car: Asset
    {
        public int Price { get; set; }
        public int MonthlyCost { get; set; }
        public override void Accept(IAssetVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}