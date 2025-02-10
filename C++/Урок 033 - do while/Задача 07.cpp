#include <iostream>
#include <Windows.h>

int main()
{
    // in next "do while" loops there will be big expressions.
    // To read that code easily, I will put the expressions into this variable.
    bool loopSuccess; 

    std::cout << "Enter first number: ";
    int number1;
    std::cin >> number1;

    int number2;
    do
    {
        std::cout << "Enter second number (it must be greater than the previous): ";
        std::cin >> number2;

        loopSuccess = number2 > number1;
        if (!loopSuccess)
        {
            std::cout << "The second number isn't greater than the first. Try again.\\n";
        }
    } while (!loopSuccess);

    int number3, number4;

    do
    {
        std::cout << "Enter next two numbers (they must be between the previous two";
        std::cout << " and the first must be greater than the second): ";
        std::cin >> number3 >> number4;

        bool subExpression1Success = (number3 <= number4);
        bool subExpression2Success = (number3 >= number1 && number3 <= number2);
        bool subExpression3Success = (number4 >= number1 && number4 <= number2);
        loopSuccess = subExpression1Success && subExpression2Success && subExpression3Success;

        if (!loopSuccess)
        {
            if (!subExpression1Success)
            {
                std::cout << "The second number isn't greater than the first.\n";
            }
            if (!subExpression2Success)
            {
                std::cout << "First number isn't in the range.\n";
            }
            if (!subExpression3Success)
            {
                std::cout << "Second number isn't in the range.\n";
            }
        }
    } while (!loopSuccess);

    std::cout << "Here is all numbers in the range [" << number1 << " ... " << number3 << "] and ";
    std::cout << "[" << number4 << " ... " << number2 << "]:\n";

    // Output first range:
    int number = number1;
    do
    {
        std::cout << number << " ";
        number++;
    } while (number <= number3);

    // Output second range:
    number = number4;
    do
    {
        std::cout << number << " ";
        number++;
    } while (number <= number2);

    return 0;
}