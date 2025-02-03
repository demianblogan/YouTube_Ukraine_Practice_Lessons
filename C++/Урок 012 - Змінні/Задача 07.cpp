#include <iostream>

int main()
{
	double temperatureF = 51.0;
	double temperatureC = (5.0 / 9.0) * (temperatureF - 32.0);

	std::cout << temperatureC << "C = " << temperatureF << "F\n";

	return 0;
}