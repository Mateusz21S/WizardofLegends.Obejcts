﻿
namespace WizardOfLegends.Objects.Weapons;

public class FistWeapon : IWeapon
{
    public int Damage { get; } = 1;
    public string Name { get; }
    public int Durability { get; } = 100;

    public FistWeapon()
    {
        Name = "Fist";
    }

    public bool IsBroken()
    {
        return Durability <= 0;
    }

    public int Hit(int random)
    {
        return Damage + random;
    }

    public void PrintInfo()
    {
        printer($"Fist has {Durability} durability points");
    }

    private void printer(string v)
    {
        throw new NotImplementedException();
    }
}