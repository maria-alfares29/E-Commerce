using SeedData;
using SeedData.Modele;
using System.Net.Http.Headers;

namespace E_Commerce
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool IsRunning = true;
            while (IsRunning)
            {
                Console.WriteLine("1 Show Products");
                Console.WriteLine("2 Buy Products");
                Console.WriteLine("3 Restock Products");
                Console.WriteLine("4 Exit");
                Console.WriteLine("Enter Your choice");
                int Choice = int.Parse(Console.ReadLine()!);
                switch (Choice)
                {
                    case 1:
                        Data.Print(Data.GetProduct());
                        break;

                    case 2:
                        Console.WriteLine("Enter Product's Id :");
                        int Id = int.Parse(Console.ReadLine()!);
                        Console.WriteLine("Enter the Quantity you want to purchase :");
                        int Quantity = int.Parse(Console.ReadLine()!);
                        var p = new Product();
                        if (p.Buy(Quantity, Id, Data.GetProduct()))
                            Console.WriteLine("The operation is done");
                        else
                            Console.WriteLine("The required quantity is not available");
                        break;

                    case 3:
                        Console.WriteLine("Enter Product's Id :");
                        int id = int.Parse(Console.ReadLine()!);
                        Console.WriteLine("Enter the Quantity you want to add :");
                        int quantity = int.Parse(Console.ReadLine()!);
                        var p1 = new Product();
                        if (p1.Restock(quantity, id, Data.GetProduct()))
                            Console.WriteLine("The operation is done");
                        else
                            Console.WriteLine("The quantity must be positive");
                        break;

                    case 4:

                        break;

                    default:
                        Console.WriteLine("your choice is not available");
                    break;
                }
                if (Choice == 4)
                {
                    IsRunning = false;
                }
            }

            LProduct.Linq();
            

        }
    }
}
