using System;
using System.Collections.Generic;
using System.Text;

namespace SalesApp
{
    /// <summary>
    /// user account info. sales of electronic parts to clients
    /// account # set by admin
    /// account (name, address, billing & shipping adddress, contact tel#, contact name) set by user
    /// balance set by admin, read only
    /// account date auti-fill
    /// </summary>
    class Account
    {
        private double
        public static int LastAccountNumber = 9999;
        private double LastBalance = 0.00;
        #region
        
    public int AccountNumber { get; private set; }
        /// <summary>
        /// client company name
        /// </summary>
    public string AccountName { get; set; }
    public string EmailAddress { get; set; }
    public string BillingAddress { get; set; }
    public string ShippingAddress { get; set; }
    public int ContactNumber { get; set; }
    /// <summary>
    /// client contact person name
    /// </summary>
    public string ContactName { get; set; }
    /// <summary>
    /// acount created date
    /// </summary>
    public DateTime AccountDate { get; private set; }
        /// <summary>
        /// outstanding balance
        /// </summary>
        public double PI { get; private set }



        #endregion

        #region  Constructor

        public Account()
        {
           
            AccountNumber = LastAccountNumber + 5;
            
        }


        #endregion


    }
}
