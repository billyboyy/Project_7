using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class Items
    {
        public static readonly ImmutableDictionary<MedicalItem, Consumables> Medicals = new Dictionary<MedicalItem, Consumables>
        {
            {
                MedicalItem.Potion,
                new()
                {
                    Name = "Potion",
                    Healing = 15,
                    Value = 75,
                    Description = "Simple bandage to dress minor injuries."
                }
            }
        
        }.ToImmutableDictionary();

        public static readonly ImmutableDictionary<Weapon, Weapons> Weapons = new Dictionary<Weapon, Weapons>
        {
            {
                Weapon.LongSword,
                new()
                {
                    Name = "Long Sword",
                    PhysicalDmg = 5,
                    Crit = 5,
                    Value= 5,
                    Description = "A long sword. Perfect for warriors."
                }
            }
        }.ToImmutableDictionary();

        public static readonly ImmutableDictionary<Armor, Armors> Armors = new Dictionary<Armor, Armors>
        {
            {
                Armor.Chestplate,
                new()
                {
                    Name = "Chestplate",
                    PhysicalDef = 2,
                    Value = 2,
                    Description = "A chestplate to protect you from deadly injuries."
                }
            }
        }.ToImmutableDictionary();

        public static Consumables Get(MedicalItem key) => Medicals[key];
        public static Weapons Get(Weapon key) => Weapons[key];
        public static Armors Get(Armor key) => Armors[key];
    }
    public class Weapons : ItemBase
    {
        public float PhysicalDmg { get; set; }
        public float Crit { get; set; }
    }

    public class Armors : ItemBase
    {
        public float PhysicalDef { get; set; }
    }

    public class Consumables : ItemBase
    {
        public float Healing { get; set; }
    }

    public enum MedicalItem { Potion }
    public enum Weapon { LongSword }
    public enum Armor { Chestplate }

};

