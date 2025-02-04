#include <iostream>

int main()
{
    std::cout << "Enter a number: ";
    int number;
    std::cin >> number;

    if (number > 0)
    {
        std::cout << "Your number is positive\n";
    }
    else if (number == 0)
    {
        std::cout << "Your number is zero\n";
    }
    else
    {
        std::cout << "Your number is negative\n";
    }

	return 0;
}