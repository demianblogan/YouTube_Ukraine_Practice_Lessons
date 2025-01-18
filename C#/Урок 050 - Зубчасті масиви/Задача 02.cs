class Program
{
    static void Main()
    {
        bool[][] seats =
        {
            // true - seat is free, false - seat is occupied:
            [true, true, true, true],
            [true, true, true, true, true],
            [true, true, true, true, true, true]
        };

        bool userWantsToQuit = false;

        do
        {
            // Show all seats
            System.Console.WriteLine("----- Theater seats -----");
            System.Console.WriteLine("(F - free, O - Occupied)\n");

            for (int row = 0; row < seats.Length; row++)
            {
                for (int col = 0; col < seats[row].Length; col++)
                {
                    bool seatIsFree = seats[row][col] == true;
                    System.Console.Write(seatIsFree ? "F" : "O");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();

            // Ask user if one wants a seat:
            System.Console.Write("Do you want to buy a seat? (Y - yes, N - no): ");
            char answer = System.Convert.ToChar(System.Console.ReadLine());
            if (answer == 'Y' || answer == 'y')
            {
                System.Console.Write("Ok. What row and column numbers have your seat?: ");
                int userSeatRowNumber = System.Convert.ToInt32(System.Console.ReadLine());
                int userSeatColumnNumber = System.Convert.ToInt32(System.Console.ReadLine());

                // Check if user enters numbers which are out of array's bounds:
                if (userSeatRowNumber < 0 || userSeatRowNumber >= seats.Length ||
                    userSeatColumnNumber < 0 || userSeatColumnNumber >= seats[userSeatRowNumber].Length)
                {
                    System.Console.WriteLine("We don't have seats with these numbers. Try again\n");
                }
                else
                {
                    bool seatIsFree = seats[userSeatRowNumber][userSeatColumnNumber] == true;
                    if (seatIsFree)
                    {
                        seats[userSeatRowNumber][userSeatColumnNumber] = false;
                        System.Console.WriteLine("This seat is free, so it's yours now\n");
                    }
                    else
                    {
                        System.Console.WriteLine("This seat is occupied\n");
                    }
                }
            }
            else if (answer == 'N' || answer == 'n')
            {
                System.Console.WriteLine("Goodbye then!");
                userWantsToQuit = true;
            }
            else
            {
                System.Console.WriteLine("Incorrect character. Try again.\n");
            }
        }
        while (!userWantsToQuit);
    }
}