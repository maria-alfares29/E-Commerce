using System;
using System.Collections.Generic;
using System.Text;

namespace SeedData.Modele
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract string GetRole();

    }
}
