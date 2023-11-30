using WizardOfLegends.Objects;


var printer = new ConsolePrinter();

Console.WriteLine("1. Create player"); //potem pyta sie o imie i typ postaci
Console.WriteLine("2. Print player info");
Console.WriteLine("3. Exit");

ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

while (keyInfo.Key != ConsoleKey.Escape)
{
     switch (keyInfo.Key)
    {
        case ConsoleKey.D1:
            printer.Print("wcisłeś 1");
            break;
        case ConsoleKey.D2:
            printer.Print("wcisłeś 2");
            break;
        case ConsoleKey.D3:
            return;
   }

    keyInfo = Console.ReadKey(true);
}   

printer.Print("Koniec programu");





//player1.PrintInfo();

//var player2 = PlayerFactory.BuildPlayer(PlayerType.Warrior, "Kuba");

//player2.PrintInfo();

//var player3 = PlayerFactory.BuildPlayer(PlayerType.Wizard, "Andrzej");