using System;
using System.Collections.Generic;
using System.Text;

namespace SeedData.Modele
{
    public class Product:IPurchasable
    {
        public int Id { get; set; }
        private string _name;
        public string Name 
        {
            get
            {
                return _name;
            }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value;
                else
                    Console.WriteLine(" The Name must not be empty");
            }
        }
        public string Category { get; set; }
        private decimal _price;
        public decimal Price {
            get
            {
                return _price;
            }
            set 
            {
                if (value > 0)
                    _price = value;
                else
                    Console.WriteLine(" The Price must be greater than zero");
            }
        }
        private int _stockquantity;
        public int StockQuantity 
        {
            get
            {
                return _stockquantity;
            }
            set 
            {
                if (value >= 0)
                    _stockquantity = value;
                else
                    Console.WriteLine(" The StockQuantity must be positive");
            }
        }
        public override string ToString()
        {
            return $"product Name : {Name}" +
                $"Product Id : {Id} "  + 
                $"Product StockQuantity : {StockQuantity} "  +
                $"Product Category :{Category}"  +
                $"Product Price :{Price} ";
        }

        public bool Buy(int quantity,int id,List<Product>list)
        {
            bool CanBuy=true;
            foreach (var item in list)
            {   if (item.Id == id)
                {
                    if (item.StockQuantity >= quantity)
                    {
                        CanBuy = true;
                        item.StockQuantity -= quantity;
                    }
                    else
                        CanBuy = false;
                }
                
            }
            return CanBuy;
        }

        public bool Restock(int quantity,int id,List<Product>list)
        {
            bool CanRestock = false;
            foreach (var item in list)
            {
                if (item.Id == id) 
                { 
                if (quantity > 0)
                {
                    CanRestock = true;
                    item.StockQuantity += quantity;
                }
                    else
                        CanRestock = false;
                }
                
            }
           
            return CanRestock;
            
        }
    }
}
