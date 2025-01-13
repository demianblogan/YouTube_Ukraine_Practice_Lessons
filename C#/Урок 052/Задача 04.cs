class Program
{
    static void Main()
    {
        ShowMessage("Enter size of the array: ");
        int size = EnterSize();

        ShowMessage("Enter values of all elements of the array:\n");
        int[] arr = new int[size];
        EnterElements(arr);

        ShowMessage("Your array: ");
        Show(arr);

        ShowMessage($"Sum of all elements = {Sum(arr)}\n");
        ShowMessage($"Average = {Average(arr)}\n");

        Sort(arr);
        ShowMessage("Your array (sorted in ascending order): ");
        Show(arr);

        Sort(arr, false);
        ShowMessage("Your array (sorted in descending order): ");
        Show(arr);
    }

    #region Tools
    static void ShowMessage(string text) => System.Console.Write(text);
    static string EnterString() => System.Console.ReadLine();
    static int EnterInt() => System.Convert.ToInt32(EnterString());

    static int EnterSize()
    {
        int size;
        do
        {
            size = EnterInt();
            if (size <= 0)
                ShowMessage("Size can be only a positive number. Try again.\n");
        } while (size <= 0);

        return size;
    }

    static void EnterElements(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            ShowMessage($"arr[{i}]: ");
            arr[i] = EnterInt();
        }
    }

    static void Show(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            ShowMessage($"{arr[i]} ");
        ShowMessage("\n");
    }
    #endregion

    static int Sum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];
        return sum;
    }

    static double Average(int[] arr) => (double)Sum(arr) / arr.Length;

    static void Sort(int[] arr, bool isAscendingOrder = true)
    {
        if (isAscendingOrder)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}