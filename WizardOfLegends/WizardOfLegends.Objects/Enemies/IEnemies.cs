using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardOfLegends.Objects.Magic.SpellBooks;
using WizardOfLegends.Objects.Weapons;

namespace WizardOfLegends.Objects.Enemies
{
    public interface IEnemies
    {
        Guid Id { get; set; }
        string Name { get; set; }
        int MaxHealth { get; }
        int Health { get; set; }
        int MaxMana { get; }
        int Mana { get; set; }
        IWeapon Weapon { get; set; }

        /// <summary>
        ///     ta metoda odejmuje zdrowie graczowi
        /// </summary>
        /// <param name="damage"></param>
        /// <returns>zwraca pozostałą ilość życia</returns>
        public int AddDamage(int damage);

        /// <summary>
        ///     ta metoda zadaje obrażenia fizyczne
        /// </summary>
        /// <returns></returns>
        public int PhysicalAttack();

        /// <summary>
        /// To ma drukować informacje o graczu
        /// imie health mana
        /// </summary>
        public void PrintInfo();
    }
}
