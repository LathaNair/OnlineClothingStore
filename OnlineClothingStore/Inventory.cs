using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineClothingStore
{
    class Inventory
    {
        public int SupplierID { get; private set; }
        public int ProductID { get; set; }
        public string Category { get; set; }
        public double UnitPrice { get; set; }
        public int UnitStock { get; set; }

        #region InventoryMethods
        /// <summary>
        /// Add inventory
        /// Increase current inventory and return the updated inventory
        /// </summary>
        /// <param name="addstock"></param>
        /// <returns></returns>
        public int AddInventory(int addinventory)
        {
            UnitStock += addinventory;
            return UnitStock;
        }

        /// <summary>
        /// Sell certain quantity of product
        /// reduce the stock accordingly
        /// </summary>
        /// <param name="sale">order</param>
        /// <returns></returns>
        public int SellStock(int order)
        {
          
            if (order <= UnitStock)
            UnitStock -= order;
            else Console.WriteLine("Out of Stock");

            return UnitStock;
        }
        #endregion
    }
}
