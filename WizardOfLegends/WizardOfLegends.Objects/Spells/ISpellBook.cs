namespace WizardOfLegends.Objects.Spells;

public interface ISpellBook
{
    string Name { get; }
    int SpellCount { get; }

    List<ISpell> Spells { get; }

    void AddSpell(ISpell spell);

    bool HasSpell(string name);
    int CastSpell(string name, int rnd);

    int CastSpell(int rnd);

    void PrintInfo();
    void RemoveSpell(ISpell spell);
    int CastSpell(string name, object rnd);
}