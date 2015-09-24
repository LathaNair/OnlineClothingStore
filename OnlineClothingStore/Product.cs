using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineClothingStore
{
    class Product
    {
        #region ProductEnum
        public enum TypeCategory
        {
            Men,
            Women,
            Kids
        }

        public enum TypeSubCategory
        {
            Activewear,
            Jeans,
            TShirts,
            Dresses,
            Shorts,
            Skirts
        }

        public enum TypeSize
        {
            XLarge,
            Large,
            Medium,
            Small,
            XSmall
        }

        public enum TypeColor
        {
            Black,
            White,
            Red,
            Yellow,
            Blue,
            Grey,
            Pink,
            Orange
        }
        #endregion
        #region ProductVariables
        private static int lastProdctID = 1000;
        #endregion

        #region ProductProperties
        /// <summary>
        /// Name of the product
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// Customer ID number
        /// </summary>
        public int ProductID { get; private set; }
        /// <summary>
        /// Product description
        /// </summary>
        public string ProductDesc { get; set; }
        /// <summary>
        ///Category of product
        /// like Men,Women,kids
        /// </summary>
        public TypeCategory Category { get;  set; }
        /// <summary>
        ///Subcategory of product
        /// like T-shirt, dress, etc.
        /// </summary>
        public TypeSubCategory SubCategory { get;  set; }
        /// <summary>
        /// Product size
        /// 'L','S','M' etc.
        /// </summary>
        public TypeSize Size { get; set; }
        /// <summary>
        /// Color of the product
        /// </summary>
        public TypeColor Color { get; set; }
        /// <summary>
        /// Stock for a product
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// Price of the product
        /// </summary>
        public double Price { get; set; }
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

       
        #endregion

        #region ProductConstructors
        public Product(string prodname)
        {
            ProductID = ++lastProdctID;
            ProductName = prodname;
        }

        #endregion
    }

}
