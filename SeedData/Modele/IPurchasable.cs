using System;
using System.Collections.Generic;
using System.Text;

namespace SeedData.Modele
{
    public interface IPurchasable
    {
        public bool Buy(int quantity,int id,List<Product> list);
        public bool Restock(int quantity,int id,List<Product> list);
    }
}
