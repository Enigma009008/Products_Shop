using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Products_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product("Вишня","Полезная ягода","5%"),
                new Product("Яблоко","Полезный фрукт","10%"),
                new Product("Огурец","Полезный овощ","15%"),
                new Product("Абрикос","Полезный фрукт","10%"),
                new Product("Авокадо","Полезный фрукт","5%"),
                new Product("Ананас","Полезный фрукт","15%"),


            };

            Console.WriteLine("Скидки есть - 5%  10%  15%");
            Console.Write("Введите скидку:");
            string searchText = Console.ReadLine();

            var search = products.Where(item => item.Discount.Contains(searchText));

            Console.WriteLine("Результат поиска:");
            Console.WriteLine($"Количество: { search.Count()}");
            foreach(var item in search)
            {
                Console.WriteLine(item.GetInfo());
            }
          

        }
    }
}
