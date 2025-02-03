#include <iostream>

int main()
{
	std::cout << "Enter your balance: $";
	double userBalance;
	std::cin >> userBalance;

	std::cout << "Enter your friend's balance: $";
	double friendBalance;
	std::cin >> friendBalance;

	double difference = friendBalance - userBalance;
	std::cout << "The difference = $" << difference << '\n';

	return 0;
}