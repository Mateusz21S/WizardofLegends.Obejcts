using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardOfLegends.Objects.Weapons
{
    public class BowWeapon : IWeapon
    {
        public int Damage { get; } = 25;
        public string Name { get; }
        public int Durability { get; } = 150;

        public BowWeapon()
        {
            Name = "Bow";
        }

        public bool IsBroken()
        {
            return Durability <= 0;
        }

        public int Hit(int random)
        {
            return Damage + random;
        }

        public void PrintInfo()
        {
            printer($"Pistol has {Durability} durability points");
        }

        private void printer(string v)
        {
            throw new NotImplementedException();
        }
    }
}