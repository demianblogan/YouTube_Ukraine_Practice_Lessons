#include <iostream>
#include <io.h>
#include <fcntl.h>

int main()
{
	_setmode(_fileno(stdout), _O_U16TEXT);

	std::wcout << L"Connerie compl�te." << std::endl;

	return 0;
}