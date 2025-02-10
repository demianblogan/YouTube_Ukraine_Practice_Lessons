#include <iostream>

int main()
{
	const unsigned int TEMPERATURES_COUNT = 3;
	double temperatures[TEMPERATURES_COUNT];
	temperatures[0] = 17.3;
	temperatures[1] = 18.5;
	temperatures[2] = 17.9;

	for (unsigned int i = 0; i < TEMPERATURES_COUNT; i++)
	{
		std::cout << "Day #" << i + 1 << ": " << temperatures[i] << "C\n";
	}

	double sumTemperatures = 0;
	for (unsigned int i = 0; i < TEMPERATURES_COUNT; i++)
	{
		sumTemperatures += temperatures[i];
	}

	double averageTemperature = sumTemperatures / TEMPERATURES_COUNT;
	std::cout << "Average = " << averageTemperature << "C\n";

	return 0;
}