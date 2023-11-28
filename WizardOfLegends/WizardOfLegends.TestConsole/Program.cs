using WizardOfLegends.Objects;

var player1 = PlayerFactory.BuildPlayer(PlayerType.Assassin, "Kazik1");

player1.PrintInfo();

var player2 = PlayerFactory.BuildPlayer(PlayerType.Warrior, "Kuba");

player2.PrintInfo();

var player3 = PlayerFactory.BuildPlayer(PlayerType.Wizard, "Andrzej");