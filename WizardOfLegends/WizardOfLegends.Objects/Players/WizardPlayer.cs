using WizardOfLegends.Objects.Spells;
using WizardOfLegends.Objects.Weapons;

namespace WizardOfLegends.Objects.Players
{
    public class WarriorPlayer : IPlayer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int MaxHealth => 100;

        private int _health;

        public WarriorPlayer(string name)
        {
            Name = name;
        }

        public WarriorPlayer()
        {
        }

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public int MaxMana => 50;

        public int Mana { get; set; } = 5;
        public IWeapon Weapon { get; set; } = new SwordWeapon();
        public ISpellBook SpellBook { get; set; } = new SimpleSpellBook();

        public int AddDamage(int damage)
        {
            if (damage < 0)
            {
                throw new ArgumentException("Damage value cannot be negative.", nameof(damage));
            }

            Health -= damage;

            if (Health < 0)
            {
                Health = 0;
            }

            return Health;
        }
        public int MagicAttack(string spellName)
        {
            int damage = CalculateMagicDamage(spellName);

            if (damage > Mana)
            {
                throw new InvalidOperationException("Not enough mana to perform the magic attack.");
            }

            Mana -= damage;

            return damage;
        }

        private int CalculateMagicDamage(string spellName)
        {
            return 10;
        }

        public int PhysicalAttack()
        {
            int damage = CalculatePhysicalDamage();

            return damage;
        }

        private int CalculatePhysicalDamage()
        {
            return 15;
        }

        public void PrintInfo()
        {
            
        }
    }
}


