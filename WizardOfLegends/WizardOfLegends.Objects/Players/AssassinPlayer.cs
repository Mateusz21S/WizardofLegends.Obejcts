using WizardOfLegends.Objects.Spells;
using WizardOfLegends.Objects.Weapons;

namespace WizardOfLegends.Objects.Players{ 

   public class AssassinPlayer : IPlayer
   {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int MaxHealth => throw new NotImplementedException();

        public int Health
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public int MaxMana => 30;

        public int Mana { get; set; } = 5;
        public IWeapon Weapon { get; set; } = new KnifeWeapon();
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
    }
}



