#include <iostream>

int main()
{
	int movementDigit;
	int heroCoordX = 10, heroCoordY = 3;

	// ------ World locations coordinates ------
	int storageLeftX = 1, storageRightX = 2;
	int storageLowerY = 1, storageUpperY = 2;

	int schoolLeftX = 4, schoolRightX = 6;
	int schoolLowerY = 6, schoolUpperY = 8;

	int churchLeftX = 16, churchRightX = 21;
	int churchLowerY = 4, churchUpperY = 5;
	// -----------------------------------------

	do
	{
		// Show hero coordinates info:
		std::cout << "Hero coordinates: [" << heroCoordX << ", " << heroCoordY << "]\\n";
		if (heroCoordX >= storageLeftX && heroCoordX <= storageRightX &&
			heroCoordY >= storageLowerY && heroCoordY <= storageUpperY)
		{
			std::cout << "Hero is in the storage\\n";
		}
		else if (heroCoordX >= schoolLeftX && heroCoordX <= schoolRightX &&
			heroCoordY >= schoolLowerY && heroCoordY <= schoolUpperY)
		{
			std::cout << "Hero is in the school\\n";
		}
		else if (heroCoordX >= churchLeftX && heroCoordX <= churchRightX &&
			heroCoordY >= churchLowerY && heroCoordY <= churchUpperY)
		{
			std::cout << "Hero is in the church\\n";
		}

		// Show menu:
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