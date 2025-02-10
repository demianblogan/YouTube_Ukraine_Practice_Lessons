#include <iostream>

int main()
{
    int computerNumber = 27;

    std::cout << "Guess computer's number. It guessed a number from 0 to 100: ";
    int userNumber;
    std::cin >> userNumber;

    int triesAmount = 1;

    while (userNumber != computerNumber)
    {
        std::cout << "You didn't guess. Try again: ";
        triesAmount++;
        std::cin >> userNumber;
    }

    std::cout << "You guessed! My congratulations! You used " << triesAmount << " tries.\n";

	return 0;
}