using WizardOfLegends.Objects;


var printer = new ConsolePrinter();
var playerFactory = new PlayerFactory(printer);


Console.WriteLine("1. Create player"); 
Console.WriteLine("2. Print player info");
Console.WriteLine("3. Exit");

ConsoleKeyInfo keyInfo;

do
{
    keyInfo = Console.ReadKey(true);

    switch (keyInfo.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine("Enter player name: ");
            string playerName = Console.ReadLine();
            
            Console.WriteLine("Enter player type: ");
            foreach (var playerType in Enum.GetValues(typeof(PlayerType)))
            {
                Console.WriteLine($"{(int)playerType}. {playerType}");
            }

            int  selectedType = Convert.ToInt16(Console.ReadLine());
            playerFactory.BuildPlayer((PlayerType)selectedType, playerName);
            break;

        case ConsoleKey.D2:
            
            break;
        case ConsoleKey.D3:
            return;
    }

} while (keyInfo.Key != ConsoleKey.Escape);

printer.Print("Koniec programu");





//player1.PrintInfo();

//var player2 = PlayerFactory.BuildPlayer(PlayerType.Warrior, "Kuba");

//player2.PrintInfo();

//var player3 = PlayerFactory.BuildPlayer(PlayerType.Wizard, "Andrzej");