using System;

namespace Project_7
{
    internal class Player : Entities
    {
        public Player()
        {
            Init();
        }

        private void Init()
        {
            Token = 'P';
            Hp = 20;
        }
    }
}
