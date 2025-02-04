#include <iostream>

int main()
{
    std::cout << "Enter a number: ";
    int number;
    std::cin >> number;

    std::cout << "Your number is " << (number % 2 == 0 ? "even" : "odd") << std::endl;

    return 0;
}