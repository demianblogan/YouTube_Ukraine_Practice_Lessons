#include <iostream>

int main()
{
    std::cout << "Enter deposit: $";
    double deposit;
    std::cin >> deposit;

    std::cout << "Enter amount of years: ";
    int years;
    std::cin >> years;

    const double INITIAL_DEPOSIT = deposit;
    const double INCREASE_FACTOR = 0.05;

    int year = 1;
    while (year <= years)
    {
        deposit += deposit + deposit * INCREASE_FACTOR;
        std::cout << "You will get $" << deposit << " in " << year << " years.\n";
        year++;
    }

    return 0;
}