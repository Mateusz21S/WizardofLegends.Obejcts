using WizardOfLegends.Objects.Spells;
using WizardOfLegends.Objects.Weapons;

namespace WizardOfLegends.Objects.Players;

public interface IPlayer
{
    Guid Id { get; set; }
    string Name { get; set; }
    int MaxHealth { get; }
    int Health { get; set; }
    int MaxMana { get; }
    int Mana { get; set; }
    IWeapon Weapon { get; set; }
    public ISpellBook SpellBook { get; set; }

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
    ///     ta metoda zadaje obrażenia magiczne
    /// </summary>
    /// <returns></returns>
    public int MagicAttack(string spellName);
}