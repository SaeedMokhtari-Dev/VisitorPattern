using System.Collections.Generic;
using System.Linq;
using VisitorPattern.Visitors;

namespace VisitorPattern.Models
{
    public class Person
    {
        public List<Asset> Assets { get; set; }

        public Person(params Asset[] assets)
        {
            Assets = assets.ToList();
        }
        public void AcceptAssetVisitor(IAssetVisitor visitor)
        {
            foreach (var asset in Assets)
            {
                asset.Accept(visitor);
            }
        }
    }
}