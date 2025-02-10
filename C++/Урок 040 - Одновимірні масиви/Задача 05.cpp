#include <iostream>

int main()
{
	const unsigned int LETTERS_COUNT = 26;
	char alphabet[LETTERS_COUNT];

	char letter = 'A';

	unsigned int i = 0;
	do
	{
		alphabet[i] = letter;
		i++;
		letter++;
	} while (i < LETTERS_COUNT);

	std::cout << "All letters from English alphabet: ";
	i = 0;
	do
	{
		std::cout << alphabet[i];
		i++;
	} while (i < LETTERS_COUNT);

	return 0;
}