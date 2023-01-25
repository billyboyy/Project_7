namespace Project_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Quadrillator quadrillator= new Quadrillator();
            Console.WriteLine(player.Token);
            Console.WriteLine(quadrillator.Token);
        }
    }
}
