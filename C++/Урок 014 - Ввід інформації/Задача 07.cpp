#include <iostream>

int main()
{
	std::cout << "Enter amount of chickens: ";
	int chickens;
	std::cin >> chickens;

	std::cout << "Enter amount of pigs: ";
	int pigs;
	std::cin >> pigs;

	std::cout << "Enter amount of cows: ";
	int cows;
	std::cin >> cows;

	int animals = chickens + pigs + cows;
	const int COW_LEGS = 4, PIG_LEGS = 4, CHICKEN_LEGS = 2;
	int allLegs = (chickens * CHICKEN_LEGS) + (pigs * PIG_LEGS) + (cows * COW_LEGS);

	std::cout << "You have " << animals << " animals.\n";
	std::cout << "They have " << allLegs << " legs.\n";

	return 0;
}