using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineClothingStore
{
    public class Customer
    {
        #region CustomerEnum
        
        public enum TypeofCard
        {
            CreditCard,
            DebitCard
        }
        #endregion 


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
        [Key]
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
        public string ShippingAddressZipCode { get; set; }

        /// <summary>
        /// Billing address of the customer
        /// </summary>
        public string BillingAddressLine1 { get; set; }
        public string BillingAddressLine2 { get; set; }
        public string BillingAddressZipCode { get; set; }

        /// <summary>
        /// Card type
        /// Debit or Credit
        /// </summary>
        public TypeofCard CardType { get; set; }
        /// <summary>
        /// Card number
        /// </summary>
        public int CardNumber { get; set; }
        #endregion

        #region CustomerConstructor

        public Customer(string custname)
        {
            CustomerID = ++lastCustomerId;
            CustomerName = custname;
        }

        #endregion
    }
}
