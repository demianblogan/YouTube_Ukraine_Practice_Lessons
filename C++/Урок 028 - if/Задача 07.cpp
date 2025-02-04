#include <iostream>
#include <Windows.h>

int main()
{
    SetConsoleOutputCP(1251);

    std::cout << "Ваш уже є 16 років? (1 - так, 0 - ні): ";
    int ageAnswer;
    std::cin >> ageAnswer;

    std::cout << "Ви живете в Україні? (1 - так, 0 - ні): ";
    int locationAnswer;
    std::cin >> locationAnswer;

    bool userIsAdult = (ageAnswer == 1);
    bool userLiveInUkraine = (locationAnswer == 1);

    bool userIsAdult = (ageAnswer == 1);
    bool userLiveInUkraine = (locationAnswer == 1);

    if (userIsAdult && userLiveInUkraine)
    {
        std::cout << "Ви можете отримати паспорт громадянина України!\n";
    }
    else
    {
        std::cout << "Ви не можете отримати паспорт громадянина України!\n";
    }

    return 0;
}