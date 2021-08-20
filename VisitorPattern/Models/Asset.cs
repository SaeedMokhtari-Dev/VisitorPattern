using System.Data;
using VisitorPattern.Visitors;

namespace VisitorPattern.Models
{
    public abstract class Asset
    {
        public abstract void Accept(IAssetVisitor visitor);
    }
}