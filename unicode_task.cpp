#include <iostream>  
#include <fcntl.h> 
#include <io.h>

int main()
{
	_setmode(_fileno(stdout), _O_U16TEXT);  //тут встановлюється режим для консоли в якому можно вивести ємодзі з юнікоду
	std::wcout << L"\x263a \x263b \n";      //вивід символів, L - позначка того що вивід виконується само в юнікоді а не де небудь
}                                           // \х... це вивід символу де замість крапок стають код символу
