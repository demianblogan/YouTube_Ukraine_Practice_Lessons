#include <iostream>

int main()
{
    const int START_NEW_GAME_MENU_ITEM = 1;
    const int LOAD_GAME_MENU_ITEM = 2;
    const int SETTINGS_MENU_ITEM = 3;
    const int CREDITS_MENU_ITEM = 4;
    const int EXIT_MENU_ITEM = 5;

    std::cout << START_NEW_GAME_MENU_ITEM << " - Start new game \n";
    std::cout << LOAD_GAME_MENU_ITEM << " - Load game \n";
    std::cout << SETTINGS_MENU_ITEM << " - Settings \n";
    std::cout << CREDITS_MENU_ITEM << " - Credits \n";
    std::cout << EXIT_MENU_ITEM << " - Exit \n";

    std::cout << "Enter menu item: ";
    int menuItem;
    std::cin >> menuItem;

    switch (menuItem)
    {
    case START_NEW_GAME_MENU_ITEM:
        std::cout << "New game is started\n";
        break;
    case LOAD_GAME_MENU_ITEM:
        std::cout << "Game is loading...\n";
        break;
    case SETTINGS_MENU_ITEM:
        std::cout << "Settings menu is open\n";
        break;
    case CREDITS_MENU_ITEM:
        std::cout << "Credits: Demian Blogan\n";
        break;
    case EXIT_MENU_ITEM:
        std::cout << "Bye bye!\n";
        break;
    default:
        std::cout << "Incorrect input\n";
        break;
    }

    return 0;
}
