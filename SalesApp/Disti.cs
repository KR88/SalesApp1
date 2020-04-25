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
        /// <summary>
        /// all member of a static class are also assigned static
        /// creating an account with Disti
        /// </summary>
        /// <param name="accountName">customer company name</param>
        /// <param name="emailAddress">customer email address</param>
        /// <param name="billingAddress">customer invoicing address</param>
        /// <param name="shippingAddress">customer courier account or shipping address</param>
        /// <param name="contactNumber">contact phone #</param>
        /// <param name="contactName">contact person name or title</param>
        /// <returns></returns>
        public static Account CreateAccount(string accountName, string emailAddress, string billingAddress, string shippingAddress, 
            int contactNumber, string contactName)
        {
            var account = new Account
            {
                AccountName = accountName,
                EmailAddress = emailAddress,
                BillingAddress = billingAddress,
                ShippingAddress = shippingAddress,
                ContactNumber = contactNumber,
                ContactName = contactName
            };
            return account;
        }
    };

    #endregion






}
