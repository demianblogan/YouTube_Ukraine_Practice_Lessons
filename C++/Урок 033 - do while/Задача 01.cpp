#include <iostream>

int main()
{
    int number;

    do
    {
        std::cout << "Enter a number (0 to stop): ";
        std::cin >> number;

        if (number != 0)
        {
            std::cout << number << " is " << (number % 2 == 0 ? "even" : "odd") << "\n";
        }
    } while (number != 0);

    return 0;
}
