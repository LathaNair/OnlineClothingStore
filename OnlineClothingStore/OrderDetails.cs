using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineClothingStore
{
    class OrderDetails
    {
        #region OrderProperties
        /// <summary>
        /// Order ID
        /// </summary>
        public int OrderID { get; set; }
        /// <summary>
        /// Order quantity
        /// </summary>
        public int OrderQty { get; set; }
        /// <summary>
        /// price of the product at a given time
        /// it can be original price or promotional price
        /// </summary>
        public double OrderPrice { get; set; }
        /// <summary>
        /// Shipping status
        /// </summary>
        public string OrderStatus { get; set; }
        #endregion

        #region OrderMethods
        /// <summary>
        /// % promotion discount provided by seller
        /// Reduce the price of prduct based on promotion %
        /// return the new price after discount 
        /// </summary>
        /// <param name="promotion"></param>
        /// <returns></returns>
        public double Promotion(int promotion)
        {
            OrderPrice = OrderPrice - (OrderPrice * promotion / 100);
            return OrderPrice;
        }
        #endregion
    }
}
