namespace WizardOfLegends.Objects.Spells;
public class MagicArrowSpell : ISpell
{
    public string Name { get; }
    public int Power { get; }
    public int ManaCost { get; }
    public int MagicDamage { get; set; }
    public int MaxDamage { get; set; }

    public MagicArrowSpell()
    {
        Name = "Magic Arrow";
        Power = 20;
        ManaCost = 25;
    }

    public int Hit(int random)
    {
        return Power + random * 2;
    }

    public void PrintInfo()
    {

    }
}