using System;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static char currentPlayer = 'X';

    static void Main(string[] args)
    {
        int turn = 0;
        bool gameWon = false;

        while (!gameWon && turn < 9)
        {
            PrintBoard();
            int choice = GetPlayerInput();
            MakeMove(choice);
            gameWon = CheckForWin();
            if (!gameWon)
            {
                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }
            turn++;
        }

        PrintBoard();

        if (gameWon)
        {
            Console.WriteLine("Spelare " + currentPlayer + " vann!");
        }
        else
        {
            Console.WriteLine("Oavgjort!");
        }
    }

    static void PrintBoard()
    {
        Console.Clear();
        Console.WriteLine(" " + board[6] + " | " + board[7] + " | " + board[8]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" " + board[3] + " | " + board[4] + " | " + board[5]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" " + board[0] + " | " + board[1] + " | " + board[2]);
    }

    static int GetPlayerInput()
    {
        int choice;
        Console.WriteLine("\nSpelare " + currentPlayer + ", välj en ruta (1-9):");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O')
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Ogiltigt val, försök igen:");
            }
        }
    }

    static void MakeMove(int choice)
    {
        board[choice - 1] = currentPlayer;
    }

    static bool CheckForWin()
    {
        // Kontrollera alla vinstkombinationer
        int[,] winCombos = {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Horisontellt
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Vertikalt
            { 0, 4, 8 }, { 2, 4, 6 }              // Diagonalt
        };

        for (int i = 0; i < winCombos.GetLength(0); i++)
        {
            if (board[winCombos[i, 0]] == currentPlayer &&
                board[winCombos[i, 1]] == currentPlayer &&
                board[winCombos[i, 2]] == currentPlayer)
            {
                return true;
            }
        }

        return false;
    }
}
