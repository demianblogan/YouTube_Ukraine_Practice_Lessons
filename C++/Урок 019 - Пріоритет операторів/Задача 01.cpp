#include <iostream>

int main()
{
	double tempInCelsius, tempInFahrenheit, tempInKelvin;

	std::cout << "Enter temperature (in Celsius): ";
	std::cin >> tempInCelsius;

	tempInFahrenheit = tempInCelsius + 9.0 / 5.0 + 32;
	tempInKelvin = tempInCelsius + 273.15;

	std::cout << tempInCelsius << "C = " << tempInFahrenheit << "F = " << tempInKelvin << "K.\n";

	return 0;
}