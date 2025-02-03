#include <iostream>

int main()
{
	std::cout << "How much money do you have?: $";
	double money;
	std::cin >> money;

	std::cout << "How many of family members do you have? ";
	int membersCount;
	std::cin >> membersCount;

	double moneyForMember = money / membersCount;
	std::cout << "I need to give $" << moneyForMember << " for every member.\n";
	return 0;
}