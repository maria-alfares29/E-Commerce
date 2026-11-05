using System;
using System.Collections.Generic;
using System.Text;

namespace SeedData.Modele
{
    public class Admin : User
    {
        public override string GetRole()
        {
            return "I am an admin";
        }
    }
}
