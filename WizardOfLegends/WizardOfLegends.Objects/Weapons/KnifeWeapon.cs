namespace WizardOfLegends.Objects.Weapons;
public class KnifeWeapon : IWeapon
{
    public int Damage { get; } = 1;
    public string Name { get; }
    public int Durability { get; } = 120;

    public KnifeWeapon()
    {
        Name = "Knife";
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
        Console.WriteLine($"Knife has {Durability} durability points");
    }

}