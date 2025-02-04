#include <iostream>

int main()
{
	const char DOOR_CODE_DIGIT_1 = '1';
	const char DOOR_CODE_DIGIT_2 = '2';
	const char DOOR_CODE_DIGIT_3 = '3';

	std::cout << "Enter door code (3 digits): ";
	char userCodeDigit1, userCodeDigit2, userCodeDigit3;
	std::cin >> userCodeDigit1 >> userCodeDigit2 >> userCodeDigit3;

	if (userCodeDigit1 == DOOR_CODE_DIGIT_1 &&
		userCodeDigit2 == DOOR_CODE_DIGIT_2 &&
		userCodeDigit3 == DOOR_CODE_DIGIT_3)
	{
		std::cout << "Door is open!\n";
	}
	else
	{
		std::cout << "Incorrect code\n";
	}

	return 0;
}