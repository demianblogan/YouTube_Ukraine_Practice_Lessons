class Program
{
    static void Main()
    {
        const int MENU_ITEM_SHOW_ARRAY = 1;
        const int MENU_ITEM_EDIT_ELEMENT = 2;
        const int MENU_ITEM_ADD_NEW_ELEMENT = 3;
        const int MENU_ITEM_REMOVE_ELEMENT = 4;
        const int MENU_ITEM_SORT_ARRAY = 5;
        const int MENU_ITEM_QUIT = 0;

        int menuItem;

        int[] array = [];

        do
        {
            System.Console.WriteLine($"{MENU_ITEM_SHOW_ARRAY} - Show the array");
            System.Console.WriteLine($"{MENU_ITEM_EDIT_ELEMENT} - Edit element");
            System.Console.WriteLine($"{MENU_ITEM_ADD_NEW_ELEMENT} - Add new element");
            System.Console.WriteLine($"{MENU_ITEM_REMOVE_ELEMENT} - Remove element");
            System.Console.WriteLine($"{MENU_ITEM_SORT_ARRAY} - Sort array");
            System.Console.WriteLine($"{MENU_ITEM_QUIT} - Quit");

            System.Console.Write("SELECT MENU ITEM: ");
            menuItem = System.Convert.ToInt32(System.Console.ReadLine());

            switch (menuItem)
            {
                case MENU_ITEM_SHOW_ARRAY:
                    if (array.Length == 0)
                    {
                        System.Console.WriteLine("Array is empty");
                    }
                    else
                    {
                        System.Console.Write("Array: ");
                        for (int i = 0; i < array.Length; i++)
                            System.Console.Write(array[i] + " ");
                        System.Console.WriteLine();
                    }
                    break;

                case MENU_ITEM_EDIT_ELEMENT:
                    if (array.Length == 0)
                    {
                        System.Console.WriteLine("Array is empty");
                    }
                    else
                    {
                        int elementIndex;
                        do
                        {
                            System.Console.Write($"Enter index of element you want to edit (from 0 to {array.Length - 1}): ");
                            elementIndex = System.Convert.ToInt32(System.Console.ReadLine());

                        } while (elementIndex < 0 || elementIndex >= array.Length);

                        System.Console.Write("Enter new value of the element: ");
                        array[elementIndex] = System.Convert.ToInt32(System.Console.ReadLine());

                        System.Console.WriteLine("ELEMENT WAS EDITED");
                    }
                    break;

                case MENU_ITEM_ADD_NEW_ELEMENT:
                    {
                        System.Console.Write("Enter the value of new element: ");
                        int newElement = System.Convert.ToInt32(System.Console.ReadLine());

                        if (array.Length == 0)
                        {
                            array = [newElement];
                        }
                        else
                        {
                            int[] newArray = new int[array.Length + 1];
                            for (int i = 0; i < newArray.Length - 1; i++)
                                newArray[i] = array[i];
                            newArray[newArray.Length - 1] = newElement;

                            array = newArray;
                        }

                        System.Console.WriteLine("ELEMENT WAS ADDED");
                    }
                    break;

                case MENU_ITEM_REMOVE_ELEMENT:
                    if (array.Length == 0)
                    {
                        System.Console.WriteLine("Array is empty");
                    }
                    else
                    {
                        if (array.Length == 1)
                        {
                            array = [];
                        }
                        else
                        {
                            int elementIndex;
                            do
                            {
                                System.Console.Write($"Enter index of element you want to remove (from 0 to {array.Length - 1}): ");
                                elementIndex = System.Convert.ToInt32(System.Console.ReadLine());

                            } while (elementIndex < 0 || elementIndex >= array.Length);

                            int[] newArray = new int[array.Length - 1];
                            for (int i = 0, j = 0; i < newArray.Length; i++, j++)
                            {
                                if (j == elementIndex)
                                {
                                    i--;
                                    continue;
                                }

                                newArray[i] = array[j];
                            }

                            array = newArray;
                        }

                        System.Console.WriteLine("ELEMENT WAS REMOVED");
                    }
                    break;

                case MENU_ITEM_SORT_ARRAY:
                    if (array.Length > 1)
                    {
                        for (int i = 0; i < array.Length - 1; i++)
                        {
                            for (int j = i + 1; j < array.Length; j++)
                            {
                                if (array[i] > array[j])
                                {
                                    int temp = array[i];
                                    array[i] = array[j];
                                    array[j] = temp;
                                }
                            }
                        }

                        System.Console.WriteLine("ARRAY WAS SORTED");
                    }
                    else
                    {
                        System.Console.WriteLine("Array doesn't have enough elements to be sorted");
                    }
                    break;

                case MENU_ITEM_QUIT:
                    System.Console.WriteLine("Goodbye");
                    break;

                default:
                    System.Console.WriteLine("Incorrect value");
                    break;
            }

        }
        while (menuItem != MENU_ITEM_QUIT);
    }
}