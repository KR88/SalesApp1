using System;

namespace SalesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object of account
            var company1 = new Account();
            company1.AccountName = "Infinite Supply";
            company1.EmailAddress = "163@163.com";
            company1.ContactName = "purchaser";
            company1.ContactNumber = 2127778899;
            company1.BillingAddress = "";
            company1.ShippingAddress = "";
            Console.WriteLine($"A#: { company1.AccountNumber}, An: {company1.ContactName}, Aemail: {company1.EmailAddress}, " +
                $"Acn: {company1.ContactName}, Ac#: {company1.ContactNumber}, Aba: {company1.BillingAddress}, " +
                $"Asd: {company1.ShippingAddress}, Acd: {company1.AccountDate: Now}, Aosb: {company1.OSBalance}");
            var company1P = new Part();
            company1P.PartNumber = 5445;
            company1P.quantity = 3000;
            company1P.SalesPrice = 25.75;
            company1P.TargetUnitprice = 21.50;
            company1P.Total = 




         }
        
    }
}
