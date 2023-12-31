﻿
namespace WizardOfLegends.Objects.Weapons;

public class WarHammerWeapon : IWeapon
{
    public int Damage { get; } = 20;

    public string Name { get; }
    public int Durability { get; private set; } = 100;

    public bool IsBroken()
    {
        return Durability <= 0;
    }

    public WarHammerWeapon()
    {
        Name = "War Hammer";
    }
    public int Hit(int random)
    {
        if (IsBroken()) return 0;

        Durability -= 1;
        return Damage + random * 2;
    }

    public void PrintInfo()
    {
        printer($"War Hammer has {Durability} durability points");
        printer(IsBroken() ? "War Hammer is broken" : "War Hammer is not broken");
    }

    private void printer(string v)
    {
        throw new NotImplementedException();
    }
}