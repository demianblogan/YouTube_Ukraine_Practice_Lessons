#include <iostream>

int main()
{
    int movementDigit;
    int heroCoordX = 0, heroCoordY = 0;

    do
    {
        std::cout << "Hero coordinates: [" << heroCoordX << ", " << heroCoordY << "]\\n";
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
            std::cout << "Hero moved up\n";
            heroCoordY++;
            break;
        case 2:
            std::cout << "Hero moved right\n";
            heroCoordX++;
            break;
        case 3:
            std::cout << "Hero moved down\n";
            heroCoordY--;
            break;
        case 4:
            std::cout << "Hero moved left\n";
            heroCoordX--;
            break;
        }

    } while (movementDigit != 0);


    return 0;
}
