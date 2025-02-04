#include <iostream>

int main()
{
    const int LOWER_BOUND = 0;
    const int UPPER_BOUND = 99;

    std::cout << "Enter number in range [" << LOWER_BOUND << " ... " << UPPER_BOUND << "]: ";
    int number;
    std::cin >> number;

    if (number >= LOWER_BOUND && number <= UPPER_BOUND)
    {
        const int MIN_2_DIGITS_NUMBER = 10;
        if (number < MIN_2_DIGITS_NUMBER)
        {
            int digit = number;
            std::cout << "Your number has 1 digit\n";
            std::cout << "Digit = " << digit << std::endl;
        }
        else
        {
            int digit1 = number / 10;
            int digit2 = number % 10;
            std::cout << "Your number has 2 digits\n";
            std::cout << "First digit = " << digit1 << std::endl;
            std::cout << "Second digit = " << digit2 << std::endl;
        }
    }
    else
    {
        std::cout << "Your number isn't in the range\n";
    }

    return 0;
}