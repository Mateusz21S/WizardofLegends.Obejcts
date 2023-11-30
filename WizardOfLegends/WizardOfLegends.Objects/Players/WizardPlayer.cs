using WizardOfLegends.Objects.Magic.SpellBooks;
using WizardOfLegends.Objects.Spells.SpellBooks;
using WizardOfLegends.Objects.Weapons;

namespace WizardOfLegends.Objects.Players
{
    public class WizardPlayer : IPlayer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int MaxHealth => 100;

        private int _health;

        public WizardPlayer(string name)
        {
            Name = name;
        }

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        private IPrinter _printer;
        public WizardPlayer(string name, IPrinter printer)
        {
            Name = name;
            _printer = printer;
        }

        public WizardPlayer(IPrinter printer)
        {
            _printer = printer;
        }

        public int MaxMana => 20;

        public int Mana { get; set; } = 5;
        public IWeapon Weapon { get; set; } = new FistWeapon();
        public ISpellBook SpellBook { get; set; } 

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
            if (_printer != null)
            {
                _printer.Print($"Wizard Player Information:");
                _printer.Print($"ID: {Id}");
                _printer.Print($"Name: {Name}");
                _printer.Print($"Health: {_health}/{MaxHealth}");
                _printer.Print($"Mana: {Mana}/{MaxMana}");

                if (Weapon != null)
                {
                    _printer.Print($"Weapon: {Weapon.GetType().Name}");
                }
            }
            else
            {
                Console.WriteLine("Printer is not initialized. Cannot print information.");
            }
        }

    }
}