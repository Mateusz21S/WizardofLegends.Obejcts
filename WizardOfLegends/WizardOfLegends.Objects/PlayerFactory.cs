using WizardOfLegends.Objects.Players;

namespace WizardOfLegends.Objects;

public class PlayerFactory
{
    private readonly IPrinter _printer;
    public PlayerFactory(IPrinter printer) {
        _printer = printer;
    }

    public  IPlayer BuildPlayer(PlayerType playerType, string name)
    {
        switch (playerType)
        {
            case PlayerType.Warrior:
                return new WarriorPlayer(name);
            case PlayerType.Wizard:
                return new WizardPlayer(name);
            case PlayerType.Assassin:
                return new AssassinPlayer(name, _printer);
            default:
                throw new ArgumentException("Invalid player type.", nameof(playerType));
        }
    }
}

public enum PlayerType
{
    Warrior =0 ,
    Wizard =10 ,
    Assassin =20
}
