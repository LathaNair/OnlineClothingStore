using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineClothingStore
{
    class Product
    {

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
        ///Category of product
        /// like Men,Women,kids
        /// </summary>
        public TypeCategory Category { get; private set; }
        /// <summary>
        ///Subcategory of product
        /// like T-shirt, dress, etc.
        /// </summary>
        public TypeSubCategory SubCategory { get; private set; }
        /// <summary>
        /// Product size
        /// 'L','S','M' etc.
        /// </summary>
        public TypeSize Size { get; private set; }
        /// <summary>
        /// Color of the product
        /// </summary>
        public TypeColor Color { get; private set; }
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

       
        #endregion

        #region ProductConstructors
        public Product()
        {
            ProductID = ++lastProdctID;
        }

        #endregion
    }

}
