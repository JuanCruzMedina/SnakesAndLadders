//____    ____                    .__.    ________
//\   \ /    /____ ___  ___  ____ |  |   /  _____/_______   ___  .__ __ ______
// \   Y    //  _ \\  \/  /_/ __ \|  |  /   \ ___ \_  __ \ / _ \ |  |  \\____ \ 
//  \      /(  <_> )>    < \  ___/|  |__\    \_\  \|  | \/( |_| )|  |  /|  |/ /
//   \___ /  \____//__/\__\ \___/ |____/ \________/|__|    \___/ |____/ |  __/ 
//                                                                      |__|

using SnakesAndLadders.Menu;
using SnakesAndLadders.Models;


BoardGameModel snakesAndLadders;
PlayerModel player;

#region Menu

void ShowStartMenu()
{
    var options = new List<Option>()
        {
            new Option("¡Iniciar el juego!",() => ShowPlayerMenu())
        };
    Menu menu = new(options, "¡Bienvenido a Serpientes y Escaleras!");
    menu.Run();
}

void ShowPlayerMenu()
{
    snakesAndLadders = new BoardGameModel(new DiceModel(), endPosition:10);
    player = new PlayerModel(snakesAndLadders);

    var options = new List<Option>()
        {
            new Option("Ver la posición de la ficha",() =>ShowTokenPosition()),
            new Option("Rodar el dado",() => RollTheDie()),
            new Option("Mover la ficha",() => MoveTheToken())
        };
    Menu menu = new(options, $"¡Estas jugando Serpientes y Escaleras! \n\t En un tablero con {snakesAndLadders.GetEndPosition()} casilleros.");
    menu.Run();
}

void ShowWinnersMenu()
{
    var options = new List<Option>()
        {
            new Option("¡Jugar de nuevo!",() =>ShowPlayerMenu()),
        };
    Menu menu = new(options, "Menú de ganadores B)");
    menu.Run();
}

#endregion

#region Player Actions

void ShowTokenPosition()
{
    Console.WriteLine();
    Console.WriteLine($"La ficha se encuentra en la posición {player.GetTokenPosition()}.");
    Console.WriteLine();
}

void RollTheDie()
{
    Console.WriteLine();
    player.RollTheDie();
    Console.WriteLine("¡Lanzaste el dado!"+ Environment.NewLine);
    Thread.Sleep(500);
    Console.WriteLine("Esta rodando..." + Environment.NewLine);
    Thread.Sleep(500);
    Console.WriteLine("Solo un poco mas..." + Environment.NewLine);
    Thread.Sleep(500);
    Console.WriteLine("..." + Environment.NewLine);
    Thread.Sleep(500);
    Console.WriteLine($"Sacaste un {player.GetSpacesToMove()}");
    Console.WriteLine();
}

void MoveTheToken()
{
    if (player.GetSpacesToMove() == 0)
    {
        Console.WriteLine();
        Console.WriteLine("Debes lanzar los dados primero!");
        Console.WriteLine();
        return;
    }
    if (player.GetSpacesToMove() + player.GetTokenPosition() > snakesAndLadders.GetEndPosition())
    {
        Console.WriteLine();
        Console.WriteLine("¡Te pasaste!");
        Console.WriteLine("Tal vez la proxima vez...");
        Console.WriteLine();
        return;
    }

    Console.WriteLine();
    Console.WriteLine("¡Moviendo la ficha!" + Environment.NewLine);
    Thread.Sleep(500);

    for (int i = 1; i < player.GetSpacesToMove() + 1; ++i)
    { 
        Console.Write($"...{i}");
        Thread.Sleep(500);
    }
    Console.WriteLine();
    Console.WriteLine("¡Listo!");
    Console.WriteLine();
    player.Move();
    ShowTokenPosition();
    if (player.Won())
    {
        Console.WriteLine();
        Console.WriteLine("¡Felicitaciones ganaste!");
        Console.WriteLine("Realmente te lo merecias...");
        Thread.Sleep(4000);
        ShowWinnersMenu();
    }
}

#endregion


ShowStartMenu();
