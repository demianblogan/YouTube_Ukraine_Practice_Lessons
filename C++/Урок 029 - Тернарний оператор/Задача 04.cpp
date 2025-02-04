#include <iostream>
#include <Windows.h>

int main()
{
    SetConsoleOutputCP(1251); // fix Ukrainian output

    std::cout << "Ваш уже є 16 років? (1 - так, 0 - ні): ";
    int ageAnswer;
    std::cin >> ageAnswer;

    std::cout << "Ви живете в Україні? (1 - так, 0 - ні): ";
    int locationAnswer;
    std::cin >> locationAnswer;

    bool userIsAdult = (ageAnswer == 1);
    bool userLiveInUkraine = (locationAnswer == 1);

    std::cout << "Ви ";
    std::cout << (userIsAdult && userLiveInUkraine ? "можете" : "не можете");
    std::cout << " отримати паспорт громадянина України\n";

    return 0;
}