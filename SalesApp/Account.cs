using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SalesApp
{
    enum BrandName
    {
        Xilinx,
        Altera,
        TI,
        Cypress
    }

    enum QualityOfPart 
    {
    NewOriginal,
    NewBulk,
    Referb
    }
    
    /// <summary>
    /// customer account & order info with their relevent properties
    /// </summary>
    class Account
    {

        private static int LastAccountNumber = 9999;
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
        //customer phone#
        public int ContactNumber { get; set; }
        //head buyer name
        public string ContactName { get; set; }
        /// <summary>
        /// outstanding balance
        /// </summary>
        public decimal MyProperty { get; set; }
        public int PartNumber { get; set; }
        public enum BrandName  { }
        public int Quantity { get; set; }
        public decimal TargetUnitprice { get; set; }
        public decimal SalesPrice { get; private set; }
        public enum PartQuality { }
        public DateTime CreatedDate { get; }
        //request for quote date
        public static DateTime RFQDate { get; set; }
        public int LeadTime { get; set; }







        #endregion

        #region  Constructor

        public Account()
        {

            AccountNumber = LastAccountNumber + 5;
            CreatedDate = DateTime.Now;

        }


    }


        #endregion
}
