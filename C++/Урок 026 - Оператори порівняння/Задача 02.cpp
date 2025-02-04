#include <iostream>

int main()
{
    std::cout << "Enter your age: ";
    int userAge;
    std::cin >> userAge;

    std::cout << "Enter your brother's age: ";
    int brotherAge;
    std::cin >> brotherAge;

    std::cout << "If you see 1 - your ages are different. If 0 - the same.\n";
    std::cout << (userAge != brotherAge) << std::endl;

    return 0;
}
