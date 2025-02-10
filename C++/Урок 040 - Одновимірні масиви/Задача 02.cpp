#include <iostream>

int main()
{
	const unsigned int LETTERS_COUNT = 26;
	char alphabet[LETTERS_COUNT];

	char letter = 'A';
	for (unsigned int i = 0; i < LETTERS_COUNT; i++, letter++)
	{
		alphabet[i] = letter;
	}

	std::cout << "All letters from English alphabet: ";
	for (unsigned int i = 0; i < LETTERS_COUNT; i++)
	{
		std::cout << alphabet[i];
	}

	return 0;
}