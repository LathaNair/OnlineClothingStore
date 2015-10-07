using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineClothingStore
{
    public class Supplier
    {

        #region SupplierProperties
        /// <summary>
        /// Supplier name
        /// </summary>
        public string SupplierName { get; private set; }
        /// <summary>
        /// Supplier identification number
        /// </summary>
        public int SupplierID { get; private set; }
        /// <summary>
        /// Supplier address
        /// </summary>
        public string SupplierAddress { get; private set; }
        /// <summary>
        /// Product inventory provided by the supplier
        /// </summary>
        public int Inventory { get; set; }
        #endregion

        #region SupplierMethods
     
        #endregion
    }
}
