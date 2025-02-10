#include <iostream>

int main()
{
	const unsigned int SIZE = 5;
	int numbers[SIZE] = { 5, 10, 15, 20, 25 };

	std::cout << "Numbers: ";
	for (unsigned int i = 0; i < SIZE; i++)
	{
		std::cout << numbers[i] << " ";
	}
	std::cout << std::endl;

	int sum = 0;
	for (unsigned int i = 0; i < SIZE; i++)
	{
		sum += numbers[i];
	}

	std::cout << "Sum = " << sum << std::endl;

	return 0;
}