using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineClothingStore
{
    class Product
    {
        #region ProductVariables
        private static int lastProdctID = 1000;
        #endregion

        #region ProductProperties
        /// <summary>
        /// Name of the product
        /// </summary>
        public string ProductName { get; private set; }
        /// <summary>
        /// Customer ID number
        /// </summary>
        public int ProductID { get; private set; }
        /// <summary>
        /// Product description
        /// </summary>
        public string ProductDesc { get; private set; }
        /// <summary>
        /// Catogory of product
        /// like T-shirt, dress, etc.
        /// </summary>
        public string Category { get; private set; }
        /// <summary>
        /// Product size
        /// 'L','S','M' etc.
        /// </summary>
        public string Size { get; private set; }
        /// <summary>
        /// Color of the product
        /// </summary>
        public string Color { get; private set; }
        /// <summary>
        /// Stock for a product
        /// </summary>
        public int Stock { get; private set; }
        /// <summary>
        /// Price of the product
        /// </summary>
        public double Price { get; private set; }
        #endregion

        #region ProductMethods
        /// <summary>
        /// Add Stocks
        /// Increase current stock and return the updated stock
        /// </summary>
        /// <param name="addstock"></param>
        /// <returns></returns>
       /* public int AddStock(int addstock)
        {
            Stock += addstock;
            return Stock;
        }*/

       
        /// <summary>
        /// Sell certain quantity of product
        /// reduce the stock accordingly
        /// </summary>
        /// <param name="sale"></param>
        /// <returns></returns>
        public int SellStock(int order)
        {
            Stock -= order; 
            return order;
        }
        #endregion

        #region ProductConstructors
        public Product()
        {
            ProductID = ++lastProdctID;
        }

        #endregion
    }

}
