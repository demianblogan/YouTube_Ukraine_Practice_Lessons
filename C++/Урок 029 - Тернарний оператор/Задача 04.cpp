#include <iostream>
#include <Windows.h>

int main()
{
    SetConsoleOutputCP(1251); // fix Ukrainian output

    std::cout << "��� ��� � 16 ����? (1 - ���, 0 - �): ";
    int ageAnswer;
    std::cin >> ageAnswer;

    std::cout << "�� ������ � �����? (1 - ���, 0 - �): ";
    int locationAnswer;
    std::cin >> locationAnswer;

    bool userIsAdult = (ageAnswer == 1);
    bool userLiveInUkraine = (locationAnswer == 1);

    std::cout << "�� ";
    std::cout << (userIsAdult && userLiveInUkraine ? "������" : "�� ������");
    std::cout << " �������� ������� ����������� ������\n";

    return 0;
}