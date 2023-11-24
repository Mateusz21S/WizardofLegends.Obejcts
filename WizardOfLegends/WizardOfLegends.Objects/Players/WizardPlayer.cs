using WizardOfLegends.Objects.Spells;
using WizardOfLegends.Objects.Weapons;

namespace WizardOfLegends.Objects.Players
{
    public class WarriorPlayer : IPlayer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int MaxHealth => throw new NotImplementedException();

        public int Health
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public int MaxMana => 50;

        public int Mana { get; set; } = 5;
        public IWeapon Weapon { get; set; } = new SwordWeapon();
        public ISpellBook SpellBook { get; set; } = new SimpleSpellBook();

        public int AddDamage(int damage)
        {
            throw new NotImplementedException();
        }

        public int MagicAttack(string spellName)


        {
            throw new NotImplementedException();
        }

        public int PhysicalAttack()
        {
            throw new NotImplementedException();
        }
    }
}


