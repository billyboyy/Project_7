using System.Security.Cryptography.X509Certificates;

namespace Project_7
{
    internal class Program
    {

        static void Main(string[] args)
        {
            foreach (ItemBase item in Inventory.Equipements)
            {
                if (item != null)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.PhysicalDmg);
                }
                else
                {
                    Console.WriteLine("Nothing");
                }
            }
            Console.WriteLine("\nItems in backpack:");
            foreach (ItemBase item in Inventory.Backpack)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
            }
        }
    }
}
