#include <iostream>

int main()
{
	int fatherMoney = 71;
	std::cout << "Father had $" << fatherMoney << '\n';

	int moneyForEverySon = fatherMoney / 3;
	std::cout << "He gave $" << moneyForEverySon << " to every son.\n";

	const int NUMBER_OF_SONS = 3;
	fatherMoney -= moneyForEverySon * NUMBER_OF_SONS;
	std::cout << "Now he has $" << fatherMoney << '\n';

	return 0;
}