#include <iostream>

int main()
{
    const int DOOR_CODE = 123;

    std::cout << "Enter door code (3 digits): ";
    int userCode;
    std::cin >> userCode;

    if (userCode == DOOR_CODE)
    {
        std::cout << "Door is open!\n";
    }
    else
    {
        std::cout << "Incorrect code\n";
    }

	return 0;
}