using System;

abstract class ItemComponent
{
	
}

class Valuable : ItemComponent
{
	public int Cost { get; set; }

    public override string ToString()
    {
        return "That item will cost you" + Cost + "g";
    }
}

class PhysicalDamage : ItemComponent
{
    public int Slashing { get; set; } = 0;
    public int Bashing { get; set; } = 1;
    public int Piercing { get; set; } = 2;

    public override string ToString()
    {
        return String.Format("It does {0}/{1}/{2} physical damage.", Slashing, Bashing, Piercing);
    }
}

class PhysicalDefense : ItemComponent
{
    public int Defense { get; set; }

    public override string ToString()
    {
        return String.Format("It have {0} defense", Defense);
    }
}

class HealingPot : ItemComponent
{
    public int Healpot { get; set; }

    public override string ToString()
    {
        return String.Format("It's heal you for {0}", Healpot);
    }
}