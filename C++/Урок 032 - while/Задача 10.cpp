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
        deposit += INITIAL_DEPOSIT + deposit * INCREASE_FACTOR;
        year++;
    }

    std::cout << "You will get $" << deposit << " in " << years << " years.\n";

	return 0;
}