using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet_03_Q3
{
    public class Product
    {
        private int productId;
        private string productName;
        private double price;
        private int quantityInStock;

        public Product(int id, string name, double price, int quantity)
        {
            this.productId = id;
            this.productName = name;
            this.price = price;
            this.quantityInStock = quantity;
        }
        public int ProductId
        {
            get => productId;
            set => productId = value;
        }
        public string ProductName
        {
            get => productName;
            set => productName = value;
        }
        public double Price
        {
            get => price;
            set => price = value;
        }
        public int QuantityInStock
        {
            get => quantityInStock;
            set => quantityInStock = value;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product ID: {ProductId}");
            Console.WriteLine($"Name: {ProductName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
        }
    }
}
