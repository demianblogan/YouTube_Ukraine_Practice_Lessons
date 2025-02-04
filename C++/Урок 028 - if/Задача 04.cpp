#include <iostream>

int main()
{
    std::cout << "Enter a number: ";
    int number;
    std::cin >> number;

    if (number % 2 == 0)
    {
        std::cout << "Your number is even\n";
    }
    else
    {
        std::cout << "Your number is odd\n";
    }

	return 0;
}