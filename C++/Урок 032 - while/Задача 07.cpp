#include <iostream>
#include <Windows.h>

int main()
{
    std::cout << "Guess computer's number. It guessed a number from 0 to 100: ";
    int userNumber;
    std::cin >> userNumber;

    int triesAmount = 1;
    int computerNumber = 27;

    while (userNumber != computerNumber)
    {
        std::cout << "You didn't guess.\n";
        std::cout << "Computer guessed " << (userNumber > computerNumber ? "smaller" : "bigger") << " number.\n";
        std::cout << "Try again: ";
        triesAmount++;
        std::cin >> userNumber;
    }

    std::cout << "You guessed! My congratulations! You used " << triesAmount << " try(ies).\n";

    return 0;
}