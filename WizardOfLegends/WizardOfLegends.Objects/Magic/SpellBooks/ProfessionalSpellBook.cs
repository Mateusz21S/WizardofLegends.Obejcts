using WizardOfLegends.Objects.Magic.Spells;

namespace WizardOfLegends.Objects.Magic.SpellBooks;
public class ProfessionalSpellBook : ISpellBook
{
    public string Name { get; } = "Professional Spell Book";
    public int SpellCount { get; private set; } = 4;
    public List<ISpell> Spells { get; }


    public int MaxRnd { get; set; } = 8;
    public int MinRnd { get; set; } = 0;
    public int SpellAddPower { get; set; } = 2;

    private IPrinter _printer;

    public ProfessionalSpellBook(IPrinter printer)
    {
        Spells = new List<ISpell>();
        _printer = printer;
    }

    public void AddSpell(ISpell spell)
    {
        if (Spells.Count >= SpellCount)
        {
            printer($"Cannot add more spells to {Name}. Maximum spell count ({SpellCount}) reached.");
            return;
        }

        Spells.Add(spell);
        printer($"{spell.Name} added to {Name} spell book.");
    }

    public bool HasSpell(string name)
    {
        return Spells.Exists(spell => spell.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void RemoveSpell(ISpell spell)
    {
        Spells.Remove(spell);
    }

    public int CastSpell(string name)
    {
        ISpell spell = Spells.Find(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (spell != null)
        {
            var random = new Random().Next(MinRnd, MaxRnd);

            int MagicDamage = spell.Power + random * SpellAddPower;

            printer($"Casting spell: {spell.Name}, MagicDamage: {MagicDamage}");
            return MagicDamage;
        }


        printer($"Spell '{name}' not found in {Name} spell book.");
        return 0;
    }

    public void PrintInfo()
    {
        printer($"Spell Book: {Name}, Spell Count: {Spells.Count}");
        foreach (var spell in Spells)
        {
            Console.WriteLine($" - {spell.Name}");
        }
    }

    private void printer(string v)
    {
        throw new NotImplementedException();
    }

    public int CastSpell(string name, object rnd)
    {
        throw new NotImplementedException();
    }


}
