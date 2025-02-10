#include <iostream>

int main()
{
	// Input:
	std::cout << "Enter a number: ";
	int number;
	std::cin >> number;

	// Calculate digits:
	int digits = 1;
	int temp = number;
	if (temp != 0)
	{
		for (; temp / 10 != 0; temp /= 10)
		{
			digits++;
		}
	}

	// Calculate reversed number:
	int reversedNumber = 0;
	temp = number;
	bool isNegative = (temp < 0);
	if (isNegative)
	{
		// Get rid of minus sign
		temp = -temp;
	}

	if (temp != 0)
	{
		int tempDigits = digits;

		for (; temp != 0; temp /= 10)
		{
			int lastDigit = temp % 10;

			int power = std::pow(10, tempDigits - 1);
			reversedNumber += lastDigit * power;

			tempDigits--;
		}

		if (isNegative)
		{
			reversedNumber = -reversedNumber;
		}
	}

	// Output:
	std::cout << "Digits: " << digits << std::endl;
	std::cout << "Reversed: " << reversedNumber << std::endl;

	return 0;
}