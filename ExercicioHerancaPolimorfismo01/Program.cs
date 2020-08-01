using System;
using System.Collections.Generic;
using ExercicioHerancaPolimorfismo01.Entities;

namespace ExercicioHerancaPolimorfismo01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i) ?: ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(type == 'u')
                {
                    Console.Write("Manuacture Date: ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    UsedProduct used = new UsedProduct(name, price, manufactureDate);
                    list.Add(used);
                }else if(type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    ImportedProduct imported = new ImportedProduct(name, price, customsFee);
                    list.Add(imported);
                }
                else
                {
                    Product product = new Product(name, price);
                    list.Add(product);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach(Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
