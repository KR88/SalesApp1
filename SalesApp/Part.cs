using System;
using System.Collections.Generic;
using System.Text;

namespace SalesApp
{
    class Part
    {


        #region

        public int PartNumber { get; set; }
        public enum BrandName { get; set; }
        public int quantity { get; set; }
        public int TargetUnitprice { get; set; }
        public decimal MarketUnitprice { get; private set; }
        public enum PartQuality { }
        public DateTime RFQDate { get; private set; }
        public int LeadTime { get; set; }
        public double SubTotal { get; private set; }


        #endregion

        #region Constructor
        public Part()
        {

        }

        #endregion


    }
}
