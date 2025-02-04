#include <iostream>

int main()
{
	std::cout << "Integer data types:" << std::endl;
	std::cout << "| Name               | Size |" << std::endl;
	std::cout << "+--------------------+------+" << std::endl;
	std::cout << "| short              | " << sizeof(short) << "    |" << std::endl;
	std::cout << "| unsigned short     | " << sizeof(unsigned short) << "    |" << std::endl;
	std::cout << "| int                | " << sizeof(int) << "    |" << std::endl;
	std::cout << "| unsigned int       | " << sizeof(unsigned int) << "    |" << std::endl;
	std::cout << "| long               | " << sizeof(long) << "    |" << std::endl;
	std::cout << "| unsigned long      | " << sizeof(unsigned long) << "    |" << std::endl;
	std::cout << "| long long          | " << sizeof(long long) << "    |" << std::endl;
	std::cout << "| unsigned long long | " << sizeof(unsigned long long) << "    |" << std::endl;
	std::cout << "+--------------------+------+" << std::endl;

	std::cout << std::endl;

	std::cout << "Decimal data types:" << std::endl;
	std::cout << "+---------------+------+" << std::endl;
	std::cout << "| Name          | Size |" << std::endl;
	std::cout << "+---------------+------+" << std::endl;
	std::cout << "| float         | " << sizeof(float) << "    |" << std::endl;
	std::cout << "| double        | " << sizeof(double) << "    |" << std::endl;
	std::cout << "| long double   | " << sizeof(long double) << "    |" << std::endl;
	std::cout << "+---------------+------+" << std::endl;

	std::cout << std::endl;

	std::cout << "Character data types:" << std::endl;
	std::cout << "+-------------+------+" << std::endl;
	std::cout << "| Name        | Size |" << std::endl;
	std::cout << "+-------------+------+" << std::endl;
	std::cout << "| char        | " << sizeof(char) << "    |" << std::endl;
	std::cout << "| wchar_t     | " << sizeof(wchar_t) << "    |" << std::endl;
	std::cout << "| char16_t    | " << sizeof(char16_t) << "    |" << std::endl;
	std::cout << "| char32_t    | " << sizeof(char32_t) << "    |" << std::endl;
	std::cout << "+-------------+------+";

	std::cout << std::endl;

	return 0;
}