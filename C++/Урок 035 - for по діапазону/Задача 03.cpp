#include <iostream>

int main()
{
    int sum = 0;
    for (int number : {1, 2, 3, 4, 5, 6, 7, 8, 9, 10})
    {
        if (number % 2 == 0)
        {
            std::cout << number << " ";
        }
    }
    return 0;
}