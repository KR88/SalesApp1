using System;
using System.Collections.Generic;
using System.Text;

namespace SalesApp
{
    /// <summary>
    /// admin called Disti
    /// </summary>
    static class Disti

    #region Method
    {
        private static List<Account> accounts = new List<Account>();
        private static List<Transaction> transactions = new List<Transaction>();
        /// <summary>
        /// all member of a static class are also assigned static
        /// creating an account with Disti
        /// </summary>
        /// <param name="accountName">customer company name</param>
        /// <param name="emailAddress">customer email address</param>
        /// <param name="contactName">contact person name or title</param>
        /// <returns></returns>
        public static Account CreateAccount(string accountName, string emailAddress, string contactName)
        {
            var account = new Account()
            {
                AccountName = accountName,
                EmailAddress = emailAddress,
                ContactName = contactName
            };
            return account;
        }
    };

    #endregion






}
