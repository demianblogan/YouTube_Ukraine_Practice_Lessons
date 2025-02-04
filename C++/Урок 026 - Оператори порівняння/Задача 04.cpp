#include <iostream>

int main()
{
	std::cout << "Enter the outside temperature (in C): ";
	double temperature;
	std::cin >> temperature;

	std::cout << "If you see 1 - your temperature is lower or equals 0.\\n";
	std::cout << "If you see 0 - your temperature is higher than 0.\\n";
	std::cout << (temperature <= 0) << std::endl;

	return 0;
}