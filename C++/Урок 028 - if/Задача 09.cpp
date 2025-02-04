#include <iostream>

int main()
{
	const int BEDROOM_NUMBER = 1;
	const int BATHROOM_NUMBER = 2;
	const int GUESTROOM_NUMBER = 3;
	const int KITCHEN_NUMBER = 4;

	std::cout << "BEDROOM    - " << BEDROOM_NUMBER << std::endl;
	std::cout << "BATHROOM   - " << BATHROOM_NUMBER << std::endl;
	std::cout << "GUESTROOM  - " << GUESTROOM_NUMBER << std::endl;
	std::cout << "KITCHEN    - " << KITCHEN_NUMBER << std::endl;

	std::cout << "In what room do you want to switch the light on?: ";
	int roomNumber;
	std::cin >> roomNumber;

	if (roomNumber == BEDROOM_NUMBER)
	{
		std::cout << "Bedroom is lighting now\n";
	}
	else if (roomNumber == BATHROOM_NUMBER)
	{
		std::cout << "Bathroom is lighting now\n";
	}
	else if (roomNumber == GUESTROOM_NUMBER)
	{
		std::cout << "Guestroom is lighting now\n";
	}
	else if (roomNumber == KITCHEN_NUMBER)
	{
		std::cout << "Kitchen is lighting now\n";
	}
	else
	{
		std::cout << "Incorrect number\n";
	}

	return 0;
}