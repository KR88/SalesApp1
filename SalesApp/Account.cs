using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SalesApp
{
    enum ETATime
    {
        stock,
        threedays,
        sevendays,
        tendays,
        fifteendays
    }

    enum TypeOfRFQ 
    { 
    spotbuy,
    recurring,
    scheduled,
    longterm

    }

    enum BrandNames
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

        private static int lastAccountNumber = 9999;
        private decimal lastBalance = 0;

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
        public string PartNumber { get; set; }
        public BrandNames  PartBrandName { get; set; }
        public int Quantity { get; set; }
        public double TargetUnitprice { get; set; }
        public decimal SalesPrice { get; private set; }
        public QualityOfPart PartQuality { get; set; }
        public DateTime CreatedDate { get; private set; }
        //request for quote date
        public DateTime RFQDate { get; set; }
        public TypeOfRFQ RFQType { get; set; }
        public ETATime LeadTime { get; private set; }
        public  double  Invoice { get; private set; }







        #endregion

        

        #region  Constructor

        public Account()
        {

            lastAccountNumber += 5;
            AccountNumber = lastAccountNumber;
            CreatedDate = DateTime.Now;



        }


    }


        #endregion
}
