class Program
{
    static void Main()
    {
        int encryptionKey = 5;
        int[,] message =
        {
            { 'I' + encryptionKey, 't' + encryptionKey, ' ' + encryptionKey },
            { 'i' + encryptionKey, 's' + encryptionKey, ' ' + encryptionKey },
            { 'k' + encryptionKey, 'e' + encryptionKey, 'y' + encryptionKey }
        };

        while (true)
        {
            System.Console.Write("This is the encrypted message: ");
            for (int i = 0; i < message.GetLength(0); i++)
                for (int j = 0; j < message.GetLength(1); j++)
                    System.Console.Write((char)message[i, j]);
            System.Console.WriteLine();

            System.Console.WriteLine("To decrypt it, you need to enter key: ");
            int userNumber = System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Here is what you got: ");
            for (int i = 0; i < message.GetLength(0); i++)
                for (int j = 0; j < message.GetLength(1); j++)
                    System.Console.Write((char)(message[i, j] - userNumber));
            System.Console.WriteLine();

            if (userNumber != encryptionKey)
            {
                System.Console.WriteLine("It's a wrong key. Try again.\n");
            }
            else
            {
                System.Console.WriteLine("You decrypted the message! Congratulations!");
                break;
            }
        }
    }
}