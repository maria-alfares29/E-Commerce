using System;
using System.Collections.Generic;
using System.Text;

namespace SeedData.Modele
{
    public class Customer:User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Product> PurchasedProduct = new List<Product>();

        public override string GetRole()
        {
            return "I am a customer";
        }
    }
}
