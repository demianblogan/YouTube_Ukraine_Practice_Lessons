#include <iostream>

int main()
{
	double tempInCelsius, tempInFahrenheit, tempInKelvin;

	std::cout << "Enter temperature (in Fahrenheit): ";
	std::cin >> tempInFahrenheit;

	tempInCelsius = (tempInFahrenheit - 32.0) / (9.0 / 5.0);
	tempInKelvin = (tempInFahrenheit + 459.67) * (5.0 / 9.0);

	std::cout << tempInFahrenheit << "F = " << tempInCelsius << "C = " << tempInKelvin << "K.\n";

	return 0;
}