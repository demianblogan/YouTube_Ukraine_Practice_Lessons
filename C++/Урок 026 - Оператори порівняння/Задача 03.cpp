#include <iostream>

int main()
{
	std::cout << "Enter the outside temperature (in C): ";
	double temperature;
	std::cin >> temperature;

	std::cout << "If you see 1 - your temperature is higher than 20.5.\n";
	std::cout << "If you see 0 - your temperature equals or lower than 20.5.\n";
	std::cout << (temperature > 20.5) << std::endl;

	return 0;
}