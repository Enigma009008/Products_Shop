using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Shop
{
    public class Product
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Discount { get; set; }

        public Product(string title, string description, string discount)
        {
            this.Title = title;
            this.Description = description;
            this.Discount = discount;

        }

        public string GetInfo()
        {
            if (!string.IsNullOrEmpty(Title) && !string.IsNullOrEmpty(Description) && !string.IsNullOrEmpty(Discount))
            {
                return $"Наименование: { Title} Описание: {Description}  Скидка: { Discount}";
            }
            else
            {
                return "Нет данных!";
            }
        }


    }
}
