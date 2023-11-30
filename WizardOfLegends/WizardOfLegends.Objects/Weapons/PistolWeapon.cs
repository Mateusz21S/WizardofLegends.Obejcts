
namespace WizardOfLegends.Objects.Weapons;
public class PistolWeapon : IWeapon
{
    public int Damage { get; } = 25;
    public string Name { get; }
    public int Durability { get; } = 120;

    public PistolWeapon()
    {
        Name = "Pistol";
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
        printer($"Pistol has {Durability} durability points");
    }

    private void printer(string v)
    {
        throw new NotImplementedException();
    }
}