using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Project_7
{
    internal class Player : Entities
    {

        public int[] _Playerpos { get; set; }

        public void keypressed()
        {
            _Playerpos = new int[2];
            _Playerpos[0] = 15;
            _Playerpos[1] = 60;

            ConsoleKeyInfo _Player;
            _Player = Console.ReadKey();

            if (_Player.Key == ConsoleKey.W)
            {
                _Playerpos[0]++;
            }
            else if (_Player.Key == ConsoleKey.S)
            {
                _Playerpos[0]--;
            }
            if (_Player.Key == ConsoleKey.D)
            {
                _Playerpos[1]++;
            }
            else if (_Player.Key == ConsoleKey.A)
            {
                _Playerpos[1]--;
            }
        }


        private void Init()
        {
            Token = 'P';
            Hp = 20;
        }
    }
}
