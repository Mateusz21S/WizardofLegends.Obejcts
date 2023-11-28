using WizardOfLegends.Objects.Magic.Spells;

namespace WizardOfLegends.Objects.Magic.SpellBooks;

public interface ISpellBook
{
    string Name { get; }
    int SpellCount { get; }

    List<ISpell> Spells { get; }

    void AddSpell(ISpell spell);

    bool HasSpell(string name);
    int CastSpell(string name);

    void PrintInfo();
    void RemoveSpell(ISpell spell);
    int CastSpell(string name, object rnd);

    int MaxRnd { get; set; }
    int MinRnd { get; set; }
    int SpellAddPower { get; set; }

}