using System;
using System.Collections.Generic;
using System.Text;

namespace SalesApp
{
    enum TypeOfTransaction
    {
        Credit,
        Debit
    }
    class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public TypeOfTransaction TransactionType { get; set; }
        public  decimal Amount { get; set; }
        public  int Account { get; set; }
    }
}
