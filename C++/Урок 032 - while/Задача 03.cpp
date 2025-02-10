#include <iostream>

int main()
{
    std::cout << "Enter a positive number: ";
    int userNumber;
    std::cin >> userNumber;

    while (userNumber <= 0)
    {
        std::cout << "You have entered the wrong number. Try again.\n";
        std::cin >> userNumber;
    }

    std::cout << "All numbers from 0 to " << userNumber << ":\n";

    int number = 0;
    while (number <= userNumber)
    {
        std::cout << number << " ";
        number++;
    }

    return 0;
}
