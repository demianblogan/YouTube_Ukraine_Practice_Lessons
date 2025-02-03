#include <iostream>

int main()
{
	std::cout << "How many pies did you you buy? ";
	int piesCount;
	std::cin >> piesCount;
	
	std::cout << "How many pies do you eat per day? ";
	int piesEatenPerDay;
	std::cin >> piesEatenPerDay;

	int daysNeed = piesCount / piesEatenPerDay; // how many days you need to eat by full portions;
	int restPiesCount = piesCount % piesEatenPerDay;

	std::cout << "You will eat " << piesEatenPerDay << " pies per day for " << daysNeed << " days.\n";
	std::cout << "The rest will be " << restPiesCount << '\n';

	return 0;
}