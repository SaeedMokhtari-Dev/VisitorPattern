using System;
using VisitorPattern.Models;
using VisitorPattern.Visitors;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new House()
            {
                Price = 10000,
                MonthlyCost = 20,
                MonthlyRentIncome = 200
            };
            var car = new Car()
            {
                Price = 1000,
                MonthlyCost = 10
            };
            var bankAccount = new BankAccount()
            {
                Balance = 5000,
                Loan = 100,
                MonthlyReturnLoan = 5
            };
            Person person = new Person(bankAccount, car, house);

            var assetMonthlyCost = new AssetMonthlyCost();
            person.AcceptAssetVisitor(assetMonthlyCost);
            Console.WriteLine($"Monthly Cost : {assetMonthlyCost.GetMonthlyCost()}");
            
            var assetNetWorth = new AssetNetWorth();
            person.AcceptAssetVisitor(assetNetWorth);
            Console.WriteLine($"NetWorth : {assetNetWorth.Result}");

            Console.ReadLine();
        }
    }
}