using WizardOfLegends.Objects.Spells;
using WizardOfLegends.Objects.Weapons;

namespace WizardOfLegends.Objects.Players;

public interface IPlayer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int MaxHealth { get; }
    public int Health { get; set; }
    public int MaxMana { get; }
    public int Mana { get; set; }
    public IWeapon Weapon { get; set; }
    public ISpell Spell { get; set; }

    public ISpellBook SpellBook { get; set; }

    /// <summary>
    /// ta metoda odejmuje zdrowie graczowi
    /// </summary>
    /// <param name="damage"></param>
    /// <returns>zwraca pozostałą ilość życia</returns>
    public int AddDamage(int damage);

    /// <summary>
    /// ta metoda zadaje obrażenia fizyczne
    /// </summary>
    /// <returns></returns>
    public int PisicalAttack();

    /// <summary>
    /// ta metoda zadaje obrażenia magiczne
    /// </summary>
    /// <returns></returns>
    public int MagicAttack();




}
