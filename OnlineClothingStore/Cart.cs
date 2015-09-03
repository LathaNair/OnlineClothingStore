using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineClothingStore
{
    class Cart
    {
        #region CartProperties
        /// <summary>
        /// Shopping cart properties
        /// </summary>
        public int CartID { get; set; }
        public int ProdID { get; set; }
        public int ProdQty { get; set; }
        public double Prodprice { get; set; }
        public double TotalProdPrice { get; set; }
        #endregion

        #region CartMethods
        /// <summary>
        /// Return total price based on total quantity of a product added to cart
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public double TotalPrice(int quantity)
        {
            TotalProdPrice = Prodprice * quantity;
            return TotalProdPrice;
        }

        #endregion
    }
}
