#include <iostream>

int main()
{
    const int AMOUNT_OF_NUMBERS = 20;

    for (int i = 0, number = 2; i < AMOUNT_OF_NUMBERS; i++)
    {
        std::cout << number << " ";
        number *= 2;
    }

    return 0;
}