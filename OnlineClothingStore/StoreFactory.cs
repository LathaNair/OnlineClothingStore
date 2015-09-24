using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineClothingStore
{
    class StoreFactory
    {

        public static string Name { get; set; }

        public static string WebAddress { get; set; }

        /// <summary>
        /// Method for creating new customer
        /// </summary>
        /// <param name="custname"></param>
        /// <param name="email"></param>
        /// <param name="shipadd1"></param>
        /// <param name="shipadd2"></param>
        /// <param name="shipadd3"></param>
        /// <param name="billadd1"></param>
        /// <param name="billadd2"></param>
        /// <param name="billadd3"></param>
        /// <param name="cardnumber"></param>
        /// <returns></returns>
        public static Customer CreateCustomer(string custname, string email, string shipadd1, string shipadd2, string shipadd3,
        string billadd1, string billadd2, string billadd3, int cardnumber)
        {
            Customer customer = new Customer(custname);
            customer.Email = email;
            customer.ShippingAddressLine1 = shipadd1;
            customer.ShippingAddressLine2 = shipadd2;
            customer.ShippingAddressZipCode = shipadd3;
            customer.BillingAddressLine1 = billadd1;
            customer.BillingAddressLine2 = billadd2;
            customer.BillingAddressZipCode = billadd3;
            customer.CardType = Customer.TypeofCard.CreditCard;
            customer.CardNumber = cardnumber;

            return customer;

        }
        
        /// <summary>
        /// Method fro entering a new product into DB
        /// </summary>
        /// <param name="prodname"></param>
        /// <param name="proddesc"></param>
        /// <param name="stock"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public static Product CreateProduct(string prodname, string proddesc, int stock, double price)
        {
            Product product = new Product(prodname);
            product.ProductDesc = proddesc;
            product.Category = Product.TypeCategory.Men;
            product.SubCategory = Product.TypeSubCategory.TShirts;
            product.Color = Product.TypeColor.Blue;
            product.Size = Product.TypeSize.Large;
            product.Stock = stock;
            product.Price = price;

            return product;
        }
    }
}
