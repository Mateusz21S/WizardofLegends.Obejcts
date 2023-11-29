using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardOfLegends.Objects.Weapons;

namespace WizardOfLegends.Objects.Enemies
{
    public class ZombieEnemies : IEnemies
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int MaxHealth => 75;

        private int _health;

        public ZombieEnemies(string name)
        {
            Name = name;
        }

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        private IPrinter _printer;
        public ZombieEnemies(string name, IPrinter printer)
        {
            Name = name;
            _printer = printer;
        }

        public ZombieEnemies(IPrinter printer)
        {
            _printer = printer;
        }

        public int MaxMana => 15;

        public int Mana { get; set; } = 5;
        public IWeapon Weapon { get; set; } = new FistWeapon();

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
            return 10;
        }

        public void PrintInfo()
        {
            if (_printer != null)
            {
                _printer.Print($"Zombie Enemy Information:");
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