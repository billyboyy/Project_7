using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public abstract class Entities
    {
        //Entities variables part
        public float Hp { get; set; }
        public float Armor { get; set; }
        public bool IsAttack { get; set; }
        public bool IsPeaceful { get; set; }
        public char Token { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
    }

}
