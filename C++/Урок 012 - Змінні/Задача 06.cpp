#include <iostream>

int main()
{
	double temperatureC = 23.5;
	double temperatureF = (9.0 / 5.0) * temperatureC + 32.0;

	std::cout << temperatureC << "C = " << temperatureF << "F\n";

	return 0;
}