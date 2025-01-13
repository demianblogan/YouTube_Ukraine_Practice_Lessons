class Program
{
    enum Direction
    {
        Up,
        Right,
        Down,
        Left,
        None
    }

    static void Main()
    {
        char[,] field = new char[5, 5];

        for (int i = 0; i < field.GetLength(0); i++)
            for (int j = 0; j < field.GetLength(1); j++)
                field[i, j] = ' ';

        int playerX = field.GetLength(1) / 2;
        int playerY = field.GetLength(0) / 2;

        Direction playerDirection = Direction.None;

        while (true)
        {
            // Place player on the field:
            field[playerY, playerX] = 'P';

            // Draw upper horizontal line:
            for (int j = 0; j < field.GetLength(1) + 2; j++)
                System.Console.Write("*");
            System.Console.WriteLine();

            // Draw left vertical line, inner space, and right vertical line:
            for (int i = 0; i < field.GetLength(0); i++)
            {
                System.Console.Write("*");
                for (int j = 0; j < field.GetLength(1); j++)
                    System.Console.Write(field[i, j]);
                System.Console.WriteLine("*");
            }

            // Draw lower horizontal line:
            for (int j = 0; j < field.GetLength(1) + 2; j++)
                System.Console.Write("*");
            System.Console.WriteLine();

            // Ask user for direction:
            char directionChar;
            do
            {
                System.Console.Write("Enter direction (w - up, d - right, s - down, a - left): ");
                directionChar = System.Convert.ToChar(System.Console.ReadLine());
            } while (directionChar != 'w' && directionChar != 'd' && directionChar != 's' && directionChar != 'a');

            // Analize user input:
            switch (directionChar)
            {
                case 'w':
                    playerDirection = Direction.Up;
                    break;
                case 'd':
                    playerDirection = Direction.Right;
                    break;
                case 's':
                    playerDirection = Direction.Down;
                    break;
                case 'a':
                    playerDirection = Direction.Left;
                    break;
            }

            // Set proper player's direction:
            switch (playerDirection)
            {
                case Direction.Up:
                    if (playerY > 0)
                    {
                        field[playerY, playerX] = ' '; // empty previous place.
                        playerY--;
                    }
                    break;

                case Direction.Right:
                    if (playerX < field.GetLength(1) - 1)
                    {
                        field[playerY, playerX] = ' '; // empty previous place.
                        playerX++;
                    }
                    break;

                case Direction.Down:
                    if (playerY < field.GetLength(0) - 1)
                    {
                        field[playerY, playerX] = ' '; // empty previous place.
                        playerY++;
                    }
                    break;

                case Direction.Left:
                    if (playerX > 0)
                    {
                        field[playerY, playerX] = ' '; // empty previous place.
                        playerX--;
                    }
                    break;

                case Direction.None:
                    break;
            }

            // Цей рядок необов'язковий. Просто завдяки ньому грати значно приємніше, так як ця команда
            // очищає консоль від тексту. В одному з майбутніх уроків я розповім про цю команду.
            System.Console.Clear();
        }
    }
}