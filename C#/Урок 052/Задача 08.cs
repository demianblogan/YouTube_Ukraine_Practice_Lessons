class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3 };
        int number = 10;
        string str = "Demian";

        Show(arr);
        Show(number);
        Show(str);
    }

    static void Show(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            ShowMessage($"{arr[i]} ");
        ShowMessage("\n");
    }

    static void Show(int number) => System.Console.WriteLine(number);
    static void Show(string str) => System.Console.WriteLine(str);

    #region Output
    static void ShowMessage(string message) => System.Console.Write(message);
    #endregion
}