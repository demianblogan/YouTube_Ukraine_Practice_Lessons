#include <iostream>

int main()
{
    int number;
    int positiveNumbers = 0, negativeNumbers = 0;

    do
    {
        std::cout << "Enter a number (0 to stop): ";
        std::cin >> number;

        if (number > 0)
        {
            positiveNumbers++;
        }
        else if (number < 0)
        {
            negativeNumbers++;
        }
    } while (number != 0);

    std::cout << "Positive numbers = " << positiveNumbers << std::endl;
    std::cout << "Negative numbers = " << negativeNumbers << std::endl;

    return 0;
}
