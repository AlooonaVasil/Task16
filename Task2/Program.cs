using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Task2
{ class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Task16/bin/Debug/Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }

            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxProduct = products[0];
            foreach (Product prod in products)
            {
                if (prod.Price > maxProduct.Price)
                {
                    maxProduct = prod;
                }
            }

            Console.WriteLine($"Товар с максимальной ценой: {maxProduct.Code} {maxProduct.Name} {maxProduct.Price}");
            Console.ReadKey();
        }
    }
}
