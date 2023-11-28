namespace WizardOfLegends.Objects.Spells;
public class ExpertSpellBook : ISpellBook
{
    public class ExpertSpellBook : ISpellBook
    {
        public string Name { get; } = "Expert Spell Book";
        public int SpellCount { get; private set; } = 8;
        public List<ISpell> Spells { get; }

        public ExpertSpellBook()
        {
            Spells = new List<ISpell>();
        }

        public void AddSpell(ISpell spell)
        {
            if (Spells.Count >= SpellCount)
            {
                Console.WriteLine($"Cannot add more spells to {Name}. Maximum spell count ({SpellCount}) reached.");
                return;
            }

            Spells.Add(spell);
            Console.WriteLine($"{spell.Name} added to {Name} spell book.");
        }

        public bool HasSpell(string name)
        {
            return Spells.Exists(spell => spell.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public int CastSpell(string name, int rnd)
        {
            ISpell spell = Spells.Find(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (spell != null)
            {
                int MagicDamage = rnd; 
                Console.WriteLine($"Casting spell: {spell.Name}, MagicDamage: {MagicDamage}");
                return MagicDamage;
            }
            else
            {
                Console.WriteLine($"Spell '{name}' not found in {Name} spell book.");
                return 0; 
            }
        }

        public void RemoveSpell(ISpell spell)
        {
            Spells.Remove(spell);
        }

        public int CastSpell(int rnd)
        {
            throw new NotImplementedException();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Spell Book: {Name}, Spell Count: {Spells.Count}");
            foreach (var spell in Spells)
            {
                Console.WriteLine($" - {spell.Name}");
            }
        }

        public int CastSpell(string name, object rnd)
        {
            throw new NotImplementedException();
        }
    }
}