using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Deligets
{
    public class Program
    {       

        static ShoppingCartModel cart = new ShoppingCartModel();
        static void Main(string[] args)
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"The Total for the cart is {cart.GenarateTotal(SubTotalAlert, CalculateLeveledDiscount, AlertUser):C2}");

            Console.ReadLine();
            Console.Write("Please press any key to exit the application.");
            Console.ReadKey();

            double amount = cart.Calculation(cogs);
            Console.WriteLine(amount);
        }

        public static double cogs(double Qty, double StockQty, double PurPrice)
        {
            double Amount = 0;
            if (Qty > StockQty)
            {
                Amount += PurPrice * Qty;
            }
            else
            {
                Amount += PurPrice * StockQty;
            }            
            return Amount;
        }

        private static void AlertUser(string message)
        {
            Console.WriteLine(message);
        }

        private static decimal CalculateLeveledDiscount(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal > 100)
            {
                return subTotal * 0.80M;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.90M;
            }
            else
            {
                return subTotal;
            }
        }

        private static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The subtotal is {subTotal:C2}");
        }

        private static void PopulateCartWithDemoData()
        {
            cart.items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.items.Add(new ProductModel { ItemName = "Milk", Price = 2.93M });
            cart.items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.73M });
            cart.items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.83M });
        }
    }
}