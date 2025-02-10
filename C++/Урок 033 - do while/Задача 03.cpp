#include <iostream>

int main()
{
    int movementDigit;

    do
    {
        std::cout << "1 - Go up \\n";
        std::cout << "2 - Go right \\n";
        std::cout << "3 - Go down \\n";
        std::cout << "4 - Go left \\n";
        std::cout << "0 - Stop \\n";

        std::cout << "Select item: ";
        std::cin >> movementDigit;

        std::cout << std::endl;

        switch (movementDigit)
        {
        case 1:
            std::cout << "Hero moved up \n";
            break;
        case 2:
            std::cout << "Hero moved right \n";
            break;
        case 3:
            std::cout << "Hero moved down \n";
            break;
        case 4:
            std::cout << "Hero moved left \n";
            break;
        }

    } while (movementDigit != 0);

    return 0;
}
