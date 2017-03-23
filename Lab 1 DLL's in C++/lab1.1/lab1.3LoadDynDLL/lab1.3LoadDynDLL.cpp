// lab1.3LoadDynDLL.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <Windows.h>
#include <string>

int main()
{
	typedef int(*ADDINTSFUNC)(int, int);
	typedef char*(*ADDCHAR)(char*, char*);
	typedef std::string(*ADDSTRINGSFUNC)(std::string, std::string);

	HINSTANCE hDLL;               // Handle to DLL  
	ADDINTSFUNC AddInts;          // Function pointer  
	ADDCHAR AddChars;             // Function pointer  
	ADDSTRINGSFUNC AddStrings;    // Function pointer  

	hDLL = LoadLibrary(L"lab1.1.dll");
	if (hDLL != NULL)
	{
		AddInts    =    (ADDINTSFUNC)GetProcAddress(hDLL, "AddInts");
		AddChars   =   (ADDCHAR)GetProcAddress(hDLL, "AddChars");
		AddStrings = (ADDSTRINGSFUNC)GetProcAddress(hDLL, "AddStrings");
		if (!AddInts && !AddChars && !AddStrings)
		{
			// handle the error  
			FreeLibrary(hDLL);
			return 400;
		}
		else
		{
			std::cout << "Adding ints" << std::endl;
			std::cout << AddInts(10, 10) << std::endl;

			std::cout << "Adding char*" << std::endl;
			std::cout << AddChars("meep", "Meeep ") << std::endl;

			std::cout << "Adding Strings" << std::endl;
			std::cout << AddStrings("String", "String1") << std::endl;
		}
	}
}
