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
        std::cout << "In " << year << " year(s) deposit will be:\n";
        std::cout << deposit << " + (" << deposit << " * " << INCREASE_FACTOR << ")";

        deposit += deposit + deposit * INCREASE_FACTOR;
        std::cout << " = $" << deposit << "\n\n";

        year++;
    }
    
    std::cout << "The final deposit will be $" << deposit << std::endl;

    return 0;
}