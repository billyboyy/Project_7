﻿using Project_7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_7
{
    public class Inventory
    {
        public static List<ItemBase> Equipements = new List<ItemBase>()
        {
            Items.Get(Armor.Chestplate),
            Items.Get(Weapon.LongSword),
        };

        public static List<ItemBase> Backpack = new List<ItemBase>()
        {
            Items.Get(MedicalItem.Potion),
        };


    }
}