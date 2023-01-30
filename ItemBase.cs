using System;

namespace Project_7
{
    public abstract class ItemBase
    {
        public string Name { get; set; } = "no Name";
        public string Description { get; set; } = "no Description";
        public float Value { get; set; }
        public float PhysicalDmg { get; set; }
        public float Crit { get; set; }
        public float PhysicalDef { get; set; }
        public float Healing { get; set; }
    }
}