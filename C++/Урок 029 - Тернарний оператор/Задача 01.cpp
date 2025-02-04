#include <iostream>

int main()
{
    std::cout << "Enter a number: ";
    int number;
    std::cin >> number;

    std::cout << "Your number " << (number > 0 ? "is" : "isn't") << " positive\n";

    return 0;
}
