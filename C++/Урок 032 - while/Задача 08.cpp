#include <iostream>
#include <Windows.h>

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

    int sum = 0;
    while (firstNumber <= secondNumber)
    {
        sum += firstNumber;
        firstNumber++;
    }
    std::cout << "Sum = " << sum << std::endl;

    return 0;
}