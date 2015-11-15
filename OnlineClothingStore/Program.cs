using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineClothingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //New customer user1

            // Customer User1 = new Customer("Lats");
            //Take user deails
            /* Console.WriteLine("Enter your name:");
             User1.CustomerName = Console.ReadLine();
             Console.WriteLine("Enter Email address:");
             User1.Email = Console.ReadLine();
             Console.WriteLine("Enter Shipping address:");
             User1.ShippingAddressLine1 = Console.ReadLine();
             Console.WriteLine("Enter City and state:");
             User1.ShippingAddressLine2 = Console.ReadLine();
             Console.WriteLine("Enter Zip code:");
             User1.ShippingAddressZipCode = Console.ReadLine();

             Console.WriteLine("Enter Billing address:");
             User1.BillingAddressLine1 = Console.ReadLine();
             Console.WriteLine("Enter City and state:");
             User1.BillingAddressLine2 = Console.ReadLine();
             Console.WriteLine("Enter Zip code:");
             User1.BillingAddressZipCode = Console.ReadLine();

             //Display user details
             Console.WriteLine("CustomerID: {0}, Name: {1}, Shipping Address: {2} {3} {4}, Billing Address: {5} {6} {7}", 
             User1.CustomerID,User1.CustomerName, 
             User1.ShippingAddressLine1,User1.ShippingAddressLine2,User1.ShippingAddressZipCode,
             User1.BillingAddressLine1, User1.BillingAddressLine2, User1.BillingAddressZipCode);
             */

            Customer ThisCustomer = StoreFactory.CreateCustomer("Lats", "abc@xyz.com", "123 ne 456 place", "##", "1432424321",
               "123 ne 456 place", "##", "1432424321", 1234567890);

            Console.WriteLine("CustomerID: {0}, Name: {1}, Shipping Address: {2} {3} {4}, Billing Address: {5} {6} {7}",
             ThisCustomer.CustomerID,ThisCustomer.CustomerName,ThisCustomer.ShippingAddressLine1,ThisCustomer.ShippingAddressLine2,
             ThisCustomer.ShippingAddressZipCode,ThisCustomer.BillingAddressLine1,ThisCustomer.BillingAddressLine2,
             ThisCustomer.BillingAddressZipCode);

            //New Product Item1
            // Product Item1 = new Product();
            // Item1.ProductName = "Graphic Tee";
            // Item1.ProductDesc = "Graphic Tee from Calvin & Hobbes, Colors avaialbe";

            Product ThisProduct = StoreFactory.CreateProduct("Graphic Tee", "Graphic Tee from Calvin and Hobbes", 10, 15.00);
            Console.WriteLine("ProductID: {0}, Name: {1}, Description: {2}, Category: {3}, SubCategory: {4}, Size: {5},Color: {6}, Stock: {7}, Price: {8}",
                 ThisProduct.ProductID, ThisProduct.ProductName, ThisProduct.ProductDesc,ThisProduct.Category, ThisProduct.SubCategory, ThisProduct.Size,
                 ThisProduct.Color, ThisProduct.Stock, ThisProduct.Price);

            Cart ThisCart = StoreFactory.CreateCart(1234, 12, 10009, 2, 15.00);
            Console.WriteLine("CustomerID: {0}, CartID: {1}, ProdID: {2}, ProdQty: {3}, Price: {4}",
                 ThisCart.CustomerID, ThisCart.CartID, ThisCart.ProdID, ThisCart.ProdQty, ThisCart.Prodprice, ThisCart.TotalProdPrice);

        }
    }
}
