using SeedData.Modele;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeedData
{
    public  class LProduct
    {
        public static void Linq()
        {
            List<Product> product = Data.GetProduct();
            var Available = new List<Product>();
            foreach (var item in product)
            {
                if (item.StockQuantity > 0)
                    Available.Add(item);
            }
            var OrderByPrice = Available.OrderByDescending(n => n.Price);
            Console.WriteLine("Available Products order by Price in descending:");
            foreach(var item in OrderByPrice) {Console.WriteLine($"Product Name : {item.Name} ,product Id : {item.Id} ,Product Category : {item.Category} ,Product Price : {item.Price} ,Product StockQuantity : {item.StockQuantity}"); };
            Console.WriteLine("----------------------------------------------------------");
            var PhoneProduct = product.Where(n => n.Category == "phone");
            Console.WriteLine("Products in phone category :");
            foreach (var item in PhoneProduct) { Console.WriteLine($"Product Name : {item.Name} ,product Id : {item.Id} ,Product Category : {item.Category} ,Product Price : {item.Price} ,Product StockQuantity : {item.StockQuantity}"); }
            Console.WriteLine("----------------------------------------------------------");
            var Name = product.Select(n => n.Name);
            Console.WriteLine("Products Name :");
            foreach (var item in Name) { Console.WriteLine(item); }
            Console.WriteLine("----------------------------------------------------------");
            var MaxPrice = product.Max(n => n.Price);
            Console.WriteLine("Products Max Price :");
            Console.WriteLine(MaxPrice);
            Console.WriteLine("----------------------------------------------------------");
            var AveragePrice = product.Average(n => n.Price);
            Console.WriteLine("Products Average Price :");
            Console.WriteLine(AveragePrice);
            Console.WriteLine("----------------------------------------------------------");
            var GroupLaptop = product.GroupBy(n => n.Category);
            Console.WriteLine("Number of Products in each category :");
            foreach(var item in GroupLaptop) { Console.WriteLine(item.Key + ":"+ item.Count(n=>n.Category==item.Key)); }
            Console.WriteLine("----------------------------------------------------------");
            var Count = product.Count(n => n.Category == "Laptop");
            Console.WriteLine("Number of Laptop Products  :");
            Console.WriteLine(Count);
            Console.WriteLine("----------------------------------------------------------");
            var Any = product.Any(n => n.Price >= 1500);
            Console.WriteLine("Are there products whose price greater than 1500:");
            Console.WriteLine(Any);
            Console.WriteLine("----------------------------------------------------------");
            var ProductOrderByAscending = product.OrderBy(n => n.Price);
            var Skip = ProductOrderByAscending.Skip(2);
            var Take = Skip.Take(3);
            Console.WriteLine("First 3 Products After Order them in Ascending by price and skip first 2 products:");
            foreach (var item in Take) { Console.WriteLine($"Product Name : {item.Name} ,product Id : {item.Id} ,Product Category : {item.Category} ,Product Price : {item.Price} ,Product StockQuantity : {item.StockQuantity}"); }
            
        }

    }
}
