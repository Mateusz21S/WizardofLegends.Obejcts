
namespace WizardOfLegends.Objects.Weapons;

public class SwordWeapon : IWeapon
{
    public int Damage { get; } = 10;

    public string Name { get; }
    public int Durability { get; private set; } = 100;

    public bool IsBroken()
    {
        return Durability <= 0;
    }
    public SwordWeapon()
    {
        Name = "Sword";
    }

    public void PrintInfo()
    {
        printer($"Sword has {Durability} durability points");
        printer(IsBroken() ? "Sword is broken" : "Sword is not broken");
    }

    private void printer(string v)
    {
        throw new NotImplementedException();
    }

    public int Hit(int random)
    {
        if (IsBroken()) return 0;

        Durability -= 1;
        return Damage + random * 2;
    }
}