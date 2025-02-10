#include <iostream>

int main()
{
	const unsigned int SIZE = 5;
	int array1[SIZE] = { 1, 2, 3, 4, 5 };
	int array2[SIZE] = { 10, 20, 30, 40, 50 };
	int array3[SIZE] = {};

	for (unsigned int i = 0; i < SIZE; i++)
	{
		array3[i] = array1[i] + array2[i];
	}

	std::cout << "Arr1 | Arr2 | Arr3\n";
	for (unsigned int i = 0; i < SIZE; i++)
	{
		std::cout << array1[i] << "\t" << array2[i] << "\t" << array3[i] << std::endl;
	}

	return 0;
}