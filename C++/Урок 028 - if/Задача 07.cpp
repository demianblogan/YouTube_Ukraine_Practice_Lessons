#include <iostream>
#include <Windows.h>

int main()
{
    SetConsoleOutputCP(1251);

    std::cout << "��� ��� � 16 ����? (1 - ���, 0 - �): ";
    int ageAnswer;
    std::cin >> ageAnswer;

    std::cout << "�� ������ � �����? (1 - ���, 0 - �): ";
    int locationAnswer;
    std::cin >> locationAnswer;

    bool userIsAdult = (ageAnswer == 1);
    bool userLiveInUkraine = (locationAnswer == 1);

    bool userIsAdult = (ageAnswer == 1);
    bool userLiveInUkraine = (locationAnswer == 1);

    if (userIsAdult && userLiveInUkraine)
    {
        std::cout << "�� ������ �������� ������� ����������� ������!\n";
    }
    else
    {
        std::cout << "�� �� ������ �������� ������� ����������� ������!\n";
    }

    return 0;
}