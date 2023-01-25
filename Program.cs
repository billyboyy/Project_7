namespace Project_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameMap _map = new GameMap();
            Player player = new Player();
            Quadrillator quadrillator = new Quadrillator();

            _map.Init();
            do
            {
                //player.keypressed();
                _map.show();
            } while (true);

        }
    }
}
