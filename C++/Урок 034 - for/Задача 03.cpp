#include <iostream>

int main()
{
    const int AMOUNT_OF_NUMBERS = 10;
    int number = 2;

    for (int i = 0; i < AMOUNT_OF_NUMBERS; i++)
    {
        std::cout << number << " ";
        number *= number;
    }

    return 0;
}