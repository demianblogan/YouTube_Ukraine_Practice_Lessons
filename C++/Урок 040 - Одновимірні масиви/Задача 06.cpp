#include <iostream>

int main()
{
	const unsigned int SIZE = 30;
	int phibonacciNumbers[SIZE] = { 0, 1 };

	for (unsigned int i = 2; i < SIZE; i++)
	{
		phibonacciNumbers[i] = phibonacciNumbers[i - 1] + phibonacciNumbers[i - 2];
	}

	for (unsigned int i = 0; i < SIZE; i++)
	{
		std::cout << phibonacciNumbers[i] << std::endl;
	}

	return 0;
}