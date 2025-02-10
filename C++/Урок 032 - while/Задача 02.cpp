#include <iostream>

int main()
{
    int number = 0;

    std::cout << "Enter a positive number: ";
    int userNumber;
    std::cin >> userNumber;

    if (userNumber <= 0)
    {
        std::cout << "You have entered the wrong number. Restart the application.\n";
    }
    else
    {
        std::cout << "All number from 0 to " << userNumber << ":\n";

        while (number <= userNumber)
        {
            std::cout << number << " ";
            number++;
        }
    }
    return 0;
}
