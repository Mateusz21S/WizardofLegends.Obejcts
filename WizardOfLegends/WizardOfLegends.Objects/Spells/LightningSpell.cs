
namespace WizardOfLegends.Objects.Spells;
public class LightningSpell : ISpell
{
    public string Name { get; }
    public int Power { get; }
    public int ManaCost { get; }
    public object MagicDamage { get; set; }
    public int MaxDamage { get; set; }

    public LightningSpell()
    {
        Name = "Lightning";
        Power = 35;
        ManaCost = 30;
    }

    public int Hit(int random)
    {
        return Power + random * 2;
    }
}