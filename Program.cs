

using Tic_Tack_Toe_version_1;

int GetGameType()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("TicTacToe");
    Console.WriteLine("Please select a game mode");
    Console.WriteLine("1: 1 Player ");
    Console.WriteLine("2: 2 Player Hotseat");
    int gameType = Convert.ToInt32(Console.ReadLine());
    if (gameType != 1 && gameType != 2)
    {
        Console.Clear();
        Console.WriteLine("You have selected an invalid game type. The game will now start in 1 Player mode");
        Console.WriteLine("Press anykey to start");
        Console.ReadKey();
        return 1;
    }
    if (gameType == 1)
    {
        Console.Clear();
        Console.WriteLine("You have selected the 1 Player game mode");
        Console.ReadKey();
    }

    if (gameType == 2)
    {
        Console.Clear();
        Console.WriteLine("You have selected the 2 Player hotseat game mode");
        Console.WriteLine("Press any key to start");
        Console.ReadKey();
    }
    return gameType;
}

if (GetGameType() == 1)
{
    char[] gameBoard = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    char playerID = 'X';
    Random random = new Random();
    int computerChoice = random.Next(1, 9);
    int turnCount = 1;
    int choice;
    do

    {

        if (turnCount % 2 == 0)
        {
            playerID = 'O';
        }
        else
        {
            playerID = 'X';
        }
        var board = new Board();
        board.GetGameBoard(gameBoard, playerID);

        if (playerID == 'O')
        {
            do
            {
                choice = computerChoice;
                if (gameBoard[choice] == 'X' || gameBoard[choice] == 'O')
                {
                    choice = random.Next(1, 9);
                }

            } while (gameBoard[choice] == 'X' || gameBoard[choice] == 'O');
        }
        else choice = Convert.ToInt32(Console.ReadLine());


        if (gameBoard[choice] == 'X' || gameBoard[choice] == 'O')
        {
            do
            {
                Console.WriteLine("You can't go there. It is already " + gameBoard[choice]);
                Console.WriteLine("Try again buddy, this time no funny business ");
                choice = Convert.ToInt32(Console.ReadLine());

            } while (gameBoard[choice] == 'X' || gameBoard[choice] == 'O');
        }
        else
        {
            gameBoard[choice] = playerID;
            turnCount++;

            if (gameBoard[1] == 'X' && gameBoard[2] == 'X' && gameBoard[3] == 'X')
            {

                Console.WriteLine("Player 1 Wins Horizontally across the top! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[1] == 'O' && gameBoard[2] == 'O' && gameBoard[3] == 'O')
            {
                Console.WriteLine("Player 2 Wins Horizontally across the top! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;

            }
            if (gameBoard[4] == 'X' && gameBoard[5] == 'X' && gameBoard[6] == 'X')
            {

                Console.WriteLine("Player 1 Wins Horizontally through the middle! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[4] == 'O' && gameBoard[5] == 'O' && gameBoard[6] == 'O')
            {
                Console.WriteLine("Player 2 Wins Horizontally through the middle! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[7] == 'X' && gameBoard[8] == 'X' && gameBoard[9] == 'X')
            {

                Console.WriteLine("Player 1 Wins Horizontally across the bottom! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[7] == 'O' && gameBoard[8] == 'O' && gameBoard[9] == 'O')
            {
                Console.WriteLine("Player 2 Wins Horizontally across the bottom! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[1] == 'X' && gameBoard[4] == 'X' && gameBoard[7] == 'X')
            {

                Console.WriteLine("Player 1 Wins Vertically down the left side! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[1] == 'O' && gameBoard[4] == 'O' && gameBoard[7] == 'O')
            {
                Console.WriteLine("Player 2 Wins Vertically down the left side! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[2] == 'X' && gameBoard[5] == 'X' && gameBoard[8] == 'X')
            {

                Console.WriteLine("Player 1 Wins Vertically straight down the middle! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[2] == 'O' && gameBoard[5] == 'O' && gameBoard[8] == 'O')
            {
                Console.WriteLine("Player 2 Wins Vertically down the middle! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[3] == 'X' && gameBoard[6] == 'X' && gameBoard[9] == 'X')
            {

                Console.WriteLine("Player 1 Wins Vertically straight down the right side! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[3] == 'O' && gameBoard[6] == 'O' && gameBoard[9] == 'O')
            {
                Console.WriteLine("Player 2 Wins Vertically down the right side! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[1] == 'X' && gameBoard[5] == 'X' && gameBoard[9] == 'X')
            {
                Console.WriteLine("Player 1 Wins Diagonally!");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[1] == 'O' && gameBoard[5] == 'O' && gameBoard[9] == 'O')
            {
                Console.WriteLine("Player 2 Wins Diagonally!");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[3] == 'X' && gameBoard[5] == 'X' && gameBoard[7] == 'X')
            {
                Console.WriteLine("Player 1 Wins Diagonally!");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[3] == 'O' && gameBoard[5] == 'O' && gameBoard[7] == 'O')
            {
                Console.WriteLine("Player 2 Wins Diagonally!");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
        }
    } while (true);
}




if (GetGameType() == 2)
{



    char[] gameBoard = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    char playerID = 'X';
    int turnCount = 1;
    do

    {

        if (turnCount % 2 == 0)
        {
            playerID = 'O';
        }
        else
        {
            playerID = 'X';
        }
        Console.Clear();
        Console.WriteLine("Player 1 X's    ||    Player 2 O's ");
        Console.WriteLine(" ");
        Console.WriteLine(" It is " + playerID + "'s turn");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", gameBoard[1], gameBoard[2], gameBoard[3]);
        Console.WriteLine("___________________ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", gameBoard[4], gameBoard[5], gameBoard[6]);
        Console.WriteLine("____________________");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", gameBoard[7], gameBoard[8], gameBoard[9]);
        Console.WriteLine("     |     |      ");
        Console.WriteLine(" Where do you want to go? ");

        int choice = Convert.ToInt32(Console.ReadLine());
        if (gameBoard[choice] == 'X' || gameBoard[choice] == 'O')
        {
            do
            {
                Console.WriteLine("You can't go there. It is already " + gameBoard[choice]);
                Console.WriteLine("Try again buddy, this time no funny business ");
                choice = Convert.ToInt32(Console.ReadLine());

            } while (gameBoard[choice] == 'X' || gameBoard[choice] == 'O');
        }
        else
        {
            gameBoard[choice] = playerID;
            turnCount++;

            if (gameBoard[1] == 'X' && gameBoard[2] == 'X' && gameBoard[3] == 'X')
            {

                Console.WriteLine("Player 1 Wins Horizontally across the top! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[1] == 'O' && gameBoard[2] == 'O' && gameBoard[3] == 'O')
            {
                Console.WriteLine("Player 2 Wins Horizontally across the top! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;

            }
            if (gameBoard[4] == 'X' && gameBoard[5] == 'X' && gameBoard[6] == 'X')
            {

                Console.WriteLine("Player 1 Wins Horizontally through the middle! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[4] == 'O' && gameBoard[5] == 'O' && gameBoard[6] == 'O')
            {
                Console.WriteLine("Player 2 Wins Horizontally through the middle! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[7] == 'X' && gameBoard[8] == 'X' && gameBoard[9] == 'X')
            {

                Console.WriteLine("Player 1 Wins Horizontally across the bottom! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[7] == 'O' && gameBoard[8] == 'O' && gameBoard[9] == 'O')
            {
                Console.WriteLine("Player 2 Wins Horizontally across the bottom! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[1] == 'X' && gameBoard[4] == 'X' && gameBoard[7] == 'X')
            {

                Console.WriteLine("Player 1 Wins Vertically down the left side! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[1] == 'O' && gameBoard[4] == 'O' && gameBoard[7] == 'O')
            {
                Console.WriteLine("Player 2 Wins Vertically down the left side! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[2] == 'X' && gameBoard[5] == 'X' && gameBoard[8] == 'X')
            {

                Console.WriteLine("Player 1 Wins Vertically straight down the middle! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[2] == 'O' && gameBoard[5] == 'O' && gameBoard[8] == 'O')
            {
                Console.WriteLine("Player 2 Wins Vertically down the middle! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[3] == 'X' && gameBoard[6] == 'X' && gameBoard[9] == 'X')
            {

                Console.WriteLine("Player 1 Wins Vertically straight down the right side! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[3] == 'O' && gameBoard[6] == 'O' && gameBoard[9] == 'O')
            {
                Console.WriteLine("Player 2 Wins Vertically down the right side! ");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[1] == 'X' && gameBoard[5] == 'X' && gameBoard[9] == 'X')
            {
                Console.WriteLine("Player 1 Wins Diagonally!");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[1] == 'O' && gameBoard[5] == 'O' && gameBoard[9] == 'O')
            {
                Console.WriteLine("Player 2 Wins Diagonally!");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[3] == 'X' && gameBoard[5] == 'X' && gameBoard[7] == 'X')
            {
                Console.WriteLine("Player 1 Wins Diagonally!");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
            if (gameBoard[3] == 'O' && gameBoard[5] == 'O' && gameBoard[7] == 'O')
            {
                Console.WriteLine("Player 2 Wins Diagonally!");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                break;
            }
        }
    } while (true);
}

