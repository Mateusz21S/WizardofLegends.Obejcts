
namespace WizardOfLegends.Objects.Spells;

public class FireBallSpell : ISpell
{
    public string Name { get; }
    public int Power { get; }
    public int ManaCost { get; }
    public int MagicDamage { get; set; } = 10;
    public int MaxDamage { get; set; }

    public FireBallSpell()
    {
        Name = "FireBall Base";
        Power = 10;
        ManaCost = 10;
    }

    public int Hit(int random)
    {
        return Power + random * 2;
    }
}