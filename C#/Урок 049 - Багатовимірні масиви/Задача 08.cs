class Program
{
    static void Main()
    {
        char[,] table =
        {
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' }
        };

        bool hasPlayer1Won = false, hasPlayer2Won = false;
        int indexIForInsertion, indexJForInsertion;

        while (true)
        {
            // Show the table:
            System.Console.WriteLine("-- TABLE --");
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    System.Console.Write($" {table[i, j]} ");

                    // Draw vertical lines if it's not last column in the row:
                    if (j < table.GetLength(1) - 1)
                        System.Console.Write("|");
                }

                // Draw horizontal lines if it's not last row:
                if (i < table.GetLength(0) - 1)
                    System.Console.WriteLine("\n---+---+---");
                else
                    System.Console.WriteLine();
            }

            // Get a character from player #1 (one's symbol is O):
            System.Console.WriteLine("Player #1, it's your turn. Enter indexes to insert your symbol.");

            while (true)
            {
                System.Console.Write("Enter an index of row (from 0 to 2): ");
                indexIForInsertion = System.Convert.ToInt32(System.Console.ReadLine());

                System.Console.Write("Enter an index of column (from 0 to 2): ");
                indexJForInsertion = System.Convert.ToInt32(System.Console.ReadLine());

                if (indexIForInsertion < 0 || indexIForInsertion > 2)
                {
                    System.Console.WriteLine("Your row's index are beyond the bounds. Try again");
                    continue;
                }
                else if (indexJForInsertion < 0 || indexJForInsertion > 2)
                {
                    System.Console.WriteLine("Your column's index are beyond the bounds. Try again");
                    continue;
                }

                if (table[indexIForInsertion, indexJForInsertion] != ' ')
                {
                    System.Console.WriteLine("This cell is occupied. Try another");
                    continue;
                }

                break;
            }

            table[indexIForInsertion, indexJForInsertion] = 'O';

            // --- Check if someone win:
            // ------ Check if player #1 win:
            if ((table[0, 0] == 'O' && table[0, 1] == 'O' && table[0, 2] == 'O') || // row #1
                (table[1, 0] == 'O' && table[1, 1] == 'O' && table[1, 2] == 'O') || // row #2
                (table[2, 0] == 'O' && table[2, 1] == 'O' && table[2, 2] == 'O') || // row #3
                (table[0, 0] == 'O' && table[1, 0] == 'O' && table[2, 0] == 'O') || // column #1
                (table[0, 1] == 'O' && table[1, 1] == 'O' && table[2, 1] == 'O') || // column #2
                (table[0, 2] == 'O' && table[1, 2] == 'O' && table[2, 2] == 'O') || // column #3
                (table[0, 0] == 'O' && table[1, 1] == 'O' && table[2, 2] == 'O') || // Diagonal #1
                (table[0, 2] == 'O' && table[1, 1] == 'O' && table[2, 0] == 'O'))   // Diagonal #2
            {
                hasPlayer1Won = true;
                break; // Stop the game
            }
            // ------ Check if player #2 win:
            else if ((table[0, 0] == 'X' && table[0, 1] == 'X' && table[0, 2] == 'X') || // row #1
                (table[1, 0] == 'X' && table[1, 1] == 'X' && table[1, 2] == 'X') ||      // row #2
                (table[2, 0] == 'X' && table[2, 1] == 'X' && table[2, 2] == 'X') ||      // row #3
                (table[0, 0] == 'X' && table[1, 0] == 'X' && table[2, 0] == 'X') ||      // column #1
                (table[0, 1] == 'X' && table[1, 1] == 'X' && table[2, 1] == 'X') ||      // column #2
                (table[0, 2] == 'X' && table[1, 2] == 'X' && table[2, 2] == 'X') ||      // column #3
                (table[0, 0] == 'X' && table[1, 1] == 'X' && table[2, 2] == 'X') ||      // Diagonal #1
                (table[0, 2] == 'X' && table[1, 1] == 'X' && table[2, 0] == 'X'))        // Diagonal #2
            {
                hasPlayer2Won = true;
                break; // Stop the game
            }
            // ------ Check if table is fully occupied:
            else
            {
                bool isTableFullyOccupied = true;
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        if (table[i, j] == ' ')
                        {
                            isTableFullyOccupied = false;
                            break;
                        }
                    }
                }

                if (isTableFullyOccupied)
                    break;
            }

            // Цей рядок необов'язковий. Просто завдяки ньому грати значно приємніше, так як ця команда
            // очищає консоль від тексту. В одному з майбутніх уроків я розповім про цю команду.
            System.Console.Clear();

            // Show the table:
            System.Console.WriteLine("-- TABLE --");
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    System.Console.Write($" {table[i, j]} ");

                    // Draw vertical lines if it's not last column in the row:
                    if (j < table.GetLength(1) - 1)
                        System.Console.Write("|");
                }

                // Draw horizontal lines if it's not last row:
                if (i < table.GetLength(0) - 1)
                    System.Console.WriteLine("\n---+---+---");
                else
                    System.Console.WriteLine();
            }

            // Get a character from player #2 (one's character is X):
            System.Console.WriteLine("Player #2, it's your turn. Enter indexes to insert your symbol.");

            while (true)
            {
                System.Console.Write("Enter an index of row (from 0 to 2): ");
                indexIForInsertion = System.Convert.ToInt32(System.Console.ReadLine());

                System.Console.Write("Enter an index of column (from 0 to 2): ");
                indexJForInsertion = System.Convert.ToInt32(System.Console.ReadLine());

                if (indexIForInsertion < 0 || indexIForInsertion > 2)
                {
                    System.Console.WriteLine("Your row's index are beyond the bounds. Try again");
                    continue;
                }
                else if (indexJForInsertion < 0 || indexJForInsertion > 2)
                {
                    System.Console.WriteLine("Your column's index are beyond the bounds. Try again");
                    continue;
                }

                if (table[indexIForInsertion, indexJForInsertion] != ' ')
                {
                    System.Console.WriteLine("This cell is occupied. Try another");
                    continue;
                }

                break;
            }

            table[indexIForInsertion, indexJForInsertion] = 'X';

            // --- Check if someone win:
            // ------ Check if player #1 win:
            if ((table[0, 0] == 'O' && table[0, 1] == 'O' && table[0, 2] == 'O') || // row #1
                (table[1, 0] == 'O' && table[1, 1] == 'O' && table[1, 2] == 'O') || // row #2
                (table[2, 0] == 'O' && table[2, 1] == 'O' && table[2, 2] == 'O') || // row #3
                (table[0, 0] == 'O' && table[1, 0] == 'O' && table[2, 0] == 'O') || // column #1
                (table[0, 1] == 'O' && table[1, 1] == 'O' && table[2, 1] == 'O') || // column #2
                (table[0, 2] == 'O' && table[1, 2] == 'O' && table[2, 2] == 'O') || // column #3
                (table[0, 0] == 'O' && table[1, 1] == 'O' && table[2, 2] == 'O') || // Diagonal #1
                (table[0, 2] == 'O' && table[1, 1] == 'O' && table[2, 0] == 'O'))   // Diagonal #2
            {
                hasPlayer1Won = true;
                break; // Stop the game
            }
            // ------ Check if player #2 win:
            else if ((table[0, 0] == 'X' && table[0, 1] == 'X' && table[0, 2] == 'X') || // row #1
                (table[1, 0] == 'X' && table[1, 1] == 'X' && table[1, 2] == 'X') ||      // row #2
                (table[2, 0] == 'X' && table[2, 1] == 'X' && table[2, 2] == 'X') ||      // row #3
                (table[0, 0] == 'X' && table[1, 0] == 'X' && table[2, 0] == 'X') ||      // column #1
                (table[0, 1] == 'X' && table[1, 1] == 'X' && table[2, 1] == 'X') ||      // column #2
                (table[0, 2] == 'X' && table[1, 2] == 'X' && table[2, 2] == 'X') ||      // column #3
                (table[0, 0] == 'X' && table[1, 1] == 'X' && table[2, 2] == 'X') ||      // Diagonal #1
                (table[0, 2] == 'X' && table[1, 1] == 'X' && table[2, 0] == 'X'))        // Diagonal #2
            {
                hasPlayer2Won = true;
                break; // Stop the game
            }
            // ------ Check if table is fully occupied:
            else
            {
                bool isTableFullyOccupied = true;
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        if (table[i, j] == ' ')
                        {
                            isTableFullyOccupied = false;
                            break;
                        }
                    }
                }

                if (isTableFullyOccupied)
                    break;
            }

            // Цей рядок необов'язковий. Просто завдяки ньому грати значно приємніше, так як ця команда
            // очищає консоль від тексту. В одному з майбутніх уроків я розповім про цю команду.
            System.Console.Clear();
        }

        // Цей рядок необов'язковий. Просто завдяки ньому грати значно приємніше, так як ця команда
        // очищає консоль від тексту. В одному з майбутніх уроків я розповім про цю команду.
        System.Console.Clear();

        // Show the table:
        System.Console.WriteLine("-- TABLE --");
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                System.Console.Write($" {table[i, j]} ");

                // Draw vertical lines if it's not last column in the row:
                if (j < table.GetLength(1) - 1)
                    System.Console.Write("|");
            }

            // Draw horizontal lines if it's not last row:
            if (i < table.GetLength(0) - 1)
                System.Console.WriteLine("\n---+---+---");
            else
                System.Console.WriteLine();
        }

        if (hasPlayer1Won)
            System.Console.WriteLine("GAME RESULT: Player #1 win!");
        else if (hasPlayer2Won)
            System.Console.WriteLine("GAME RESULT: Player #2 win!");
        else
            System.Console.WriteLine("GAME RESULT: Draw");

    }
}