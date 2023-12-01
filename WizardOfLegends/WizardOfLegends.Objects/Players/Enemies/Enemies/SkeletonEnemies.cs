using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardOfLegends.Objects.Weapons;
using WizardOfLegends.Objects.Players;
using WizardOfLegends.Objects.Magic.SpellBooks;

namespace WizardOfLegends.Objects.Players.Enemies.Enemies
{
    public class SkeletonEnemies : IPlayer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int MaxHealth => 35;

        private int _health;

        public SkeletonEnemies(string name)
        {
            Name = name;
        }

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        private IPrinter _printer;
        public SkeletonEnemies(string name, IPrinter printer)
        {
            Name = name;
            _printer = printer;
        }

        public SkeletonEnemies(IPrinter printer)
        {
            _printer = printer;
        }

        public int MaxMana => 40;

        public int Mana { get; set; } = 5;
        public IWeapon Weapon { get; set; } = new BowWeapon();
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

        public int PhysicalAttack()
        {
            int damage = CalculatePhysicalDamage();

            return damage;
        }

        private int CalculatePhysicalDamage()
        {
            return 20;
        }

        public void PrintInfo()
        {
            if (_printer != null)
            {
                _printer.Print($"Skeleton Enemy Information:");
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

        public int MagicAttack(string spellName)
        {
            throw new NotImplementedException();
        }
    }
}
