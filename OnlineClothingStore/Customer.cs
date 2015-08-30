using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineClothingStore
{
    class Customer
    {

        #region CustomerVariables

        private static int lastCustomerId = 0;
        
        #endregion

        #region CustomerProperties
        /// <summary>
        /// Customer name
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// Customer ID
        /// </summary>
        public int CustomerID { get; private set; }
        /// <summary>
        /// Customer email id
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Shipping address of the customer
        /// </summary>
        public string ShippingAddressLine1 { get; set; }
        public string ShippingAddressLine2 { get; set; }
        public int ShippingAddressZipCode { get; set; }

        /// <summary>
        /// Billing address of the customer
        /// </summary>
        public string BillingAddressLine1 { get; set; }
        public string BillingAddressLine2 { get; set; }
        public int BillingAddressZipCode { get; set; }

        /// <summary>
        /// Card type
        /// Debit or Credit
        /// </summary>
        public string CardType { get; set; }
        /// <summary>
        /// Card number
        /// </summary>
        public int CardNumber { get; set; }
        #endregion

        #region CustomerConstructor

        public Customer()
        {
            CustomerID = ++lastCustomerId;
        }

        #endregion
    }
}
