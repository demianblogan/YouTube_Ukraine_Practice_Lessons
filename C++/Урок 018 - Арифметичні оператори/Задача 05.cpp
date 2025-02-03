#include <iostream>

int main()
{
	double temp1 = -15, temp2 = -17, temp3, temp4; // degrees in C.

	std::cout << "Enter the temperature of day #3 (in C): ";
	std::cin >> temp3;

	std::cout << "Enter the temperature of day #4 (in C):";
	std::cin >> temp4;

	double tempSum = temp1 + temp2 + temp3 + temp4;
	int tempCount = 4;
	double tempAverage = tempSum / tempCount;

	std::cout << "Average temperature = " << tempAverage << "C.\n";

	return 0;
}