using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardOfLegends.Objects.Spells;
using WizardOfLegends.Objects.Weapons;

namespace WizardOfLegends.Objects.Players
{
    public class WizardPlayer : IPlayer

    {
        public Guid Id { get; set => throw new NotImplementedException(); }
        public string Name { get; set => throw new NotImplementedException(); }

        public int MaxHealth => throw new NotImplementedException();

        public int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int MaxMana => 50;

        public int Mana { get; set; } = 20;
        public ISpeel Speel { get; set; } = new SimpleSpellBook();
        public ISpellBook SpellBook { get; set; }

        public int AddDamage(int damage)
        {
            throw new NotImplementedException();
        }

        public int MagicAttack()
        {
            throw new NotImplementedException();
        }

        public int PisicalAttack()
        {
            throw new NotImplementedException();
        }

    }
}

