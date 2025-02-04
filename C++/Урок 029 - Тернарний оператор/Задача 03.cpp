#include <iostream>

int main()
{
    const int DOOR_CODE = 123;

    std::cout << "Enter door code (3 digits): ";
    int userCode;
    std::cin >> userCode;

    std::cout << (userCode == DOOR_CODE ? "Door is open!" : "Incorrect code") << std::endl;

    return 0;
}
