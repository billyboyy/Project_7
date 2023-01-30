namespace Project_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameMap _map = new GameMap();
            Player player = new Player();

            _map.Init();
            player.Init();
            do
            {   
                _map.show(player._Playerpos);
                player.keypressed();
            } while(true);
        }
    }
}
