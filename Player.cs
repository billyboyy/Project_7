using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Project_7
{
    internal class Player : Entities
    {
        public Player() {
            Init();
        }

        private void Init()
        {
            Token = 'P';
            Hp = 20;
            Armor = 20;
            PosX = 20;
            PosY = 20;
        }
    }
}
