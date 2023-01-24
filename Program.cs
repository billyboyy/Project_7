namespace Project_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("White on blue.");
            Console.WriteLine("Another line.");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("###############################");
            Console.ResetColor();

            var sword = new Items("Sword")
                        .AddComponent(new Valuable { Cost = 1000 })
                        .AddComponent(new PhysicalDamage { Slashing = 10 });
            Console.WriteLine(sword.ToString());
        }
    }
}
