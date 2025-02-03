#include <iostream>

int main()
{
	std::cout << "Enter how much money you earned: $";
	double earnedMoney;
	std::cin >> earnedMoney;

	std::cout << "Enter how much money you spent: $";
	double spentMoney;
	std::cin >> spentMoney;

	double restMoney = earnedMoney - spentMoney;

	std::cout << "Your balance: $" << restMoney << '\n';

	return 0;
}