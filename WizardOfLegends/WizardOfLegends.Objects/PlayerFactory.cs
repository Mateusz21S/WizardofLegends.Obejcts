using WizardOfLegends.Objects.Players;

namespace WizardOfLegends.Objects;

public static class PlayerFactory
{
    public static IPlayer BuildPlayer(PlayerType playerType, string name)
    {
        switch (playerType)
        {
            case PlayerType.Warrior:
                return new WarriorPlayer(name);
            case PlayerType.Wizard:
                return new WizardPlayer(name);
            case PlayerType.Assassin:
                return new AssassinPlayer(name);
            default:
                throw new ArgumentException("Invalid player type.", nameof(playerType));
        }
    }
}

public enum PlayerType
{
    Warrior,
    Wizard,
    Assassin
}
