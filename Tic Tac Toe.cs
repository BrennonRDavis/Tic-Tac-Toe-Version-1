using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tack_Toe_version_1
{
    public class Board
    {
        
       public void GetGameBoard(char[] gameBoard, char playerID)
        {

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

        }
    }
}
    

