using System;
using System.Collections.Generic;
using System.Text;

namespace SeedData.Modele
{
    public class Data
    { 
        public static List<Product> GetProduct()
        {
            List<Product> Products = new List<Product>
            {
                new Product { Name = "HP404"     ,Id = 1   ,Category ="Laptop"     , Price = 560,StockQuantity = 10},
                new Product { Name = "keyboard"  ,Id = 2   ,Category ="Accessories", Price = 120,StockQuantity = 5 },
                new Product { Name = "samsungA22",Id = 3   ,Category ="phone"      , Price = 180,StockQuantity = 11},
                new Product { Name = "Lenovo30"  ,Id = 4   ,Category ="Laptop"     , Price = 660,StockQuantity = 20},
                new Product { Name = "Mouse"     ,Id = 5   ,Category ="Accessories", Price = 94 ,StockQuantity = 7 },
                new Product { Name = "Honor200"  ,Id = 6   ,Category ="phone"      , Price = 270,StockQuantity = 9 },
                new Product { Name = "Dell20"    ,Id = 7   ,Category ="Laptop"     , Price = 725,StockQuantity = 12},
                new Product { Name = "Earbuds"   ,Id = 8   ,Category ="Accessories", Price = 115,StockQuantity = 21},
                new Product { Name = "samsungA12",Id = 9   ,Category ="phone"      , Price = 75 ,StockQuantity = 6 },
                new Product { Name = "Lenovo"    ,Id = 10  ,Category ="Laptop"     , Price = 722,StockQuantity = 23},
                new Product { Name = "charger"   ,Id = 11  ,Category ="Accessories", Price = 31 ,StockQuantity = 14},
                new Product { Name = "Honor600"  ,Id = 12  ,Category ="phone"      , Price = 420,StockQuantity = 0 },
                new Product { Name = "Hp90"      ,Id = 13  ,Category ="Laptop"     , Price = 534,StockQuantity = 0 },
                new Product { Name = "cover"     ,Id = 14  ,Category ="Accessories", Price = 20 ,StockQuantity = 0 },
                new Product { Name = "samsungA55",Id = 15  ,Category ="phone"      , Price = 333,StockQuantity = 0 },
            };
            return Products;
            
        }
        public static void Print(List<Product> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine($"Product Name : {item.Name} ,product Id : {item.Id} ,Product Category : {item.Category} ,Product Price : {item.Price} ,Product StockQuantity : {item.StockQuantity}");
            }
        }
    }
}
