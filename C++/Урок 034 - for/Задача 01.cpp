#include <iostream>

int main()
{
    const int MIN_NUMBER = 0;
    const int MAX_NUMBER = 100;

    for (int number = MIN_NUMBER; number <= MAX_NUMBER; number++)
    {
        std::cout << number << " ";
    }

    std::cout << std::endl;

    return 0;
}