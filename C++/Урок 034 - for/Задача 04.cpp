#include <iostream>

int main()
{
    // Input number:
    int userNumber;
    do
    {
        std::cout << "Enter a positive number: ";
        std::cin >> userNumber;
    } while (userNumber <= 0);

    int sum = 0;
    for (int number = 1; number <= userNumber; number++)
    {
        sum += number;
    }

    std::cout << "Sum = " << sum << std::endl;

    return 0;
}