#include <iostream>

int main()
{
    std::cout << "Enter two numbers (smaller and bigger): ";
    int firstNumber, secondNumber;
    std::cin >> firstNumber >> secondNumber;

    if (firstNumber > secondNumber)
    {
        int temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;
    }

    std::cout << "All numbers from " << firstNumber << " to " << secondNumber << ":\n";
    while (firstNumber <= secondNumber)
    {
        std::cout << firstNumber << " ";
        firstNumber++;
    }


	return 0;
}