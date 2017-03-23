
#include "stdafx.h"

#include <iostream>
#include <bemapiset.h>
#include <winbase.h>

int main()
{
	typedef UINT(*ADDINTSFUNC)(int, int);
	typedef UINT(*ADDCHAR)(DWORD, UINT);
	typedef UINT(*ADDSTRINGSFUNC)(std::string, std::string);


	HINSTANCE hDLL;               // Handle to DLL  
	ADDINTSFUNC AddInts;    // Function pointer  
	ADDCHAR AddChars;    // Function pointer  
	ADDSTRINGSFUNC AddStrings;    // Function pointer  

	hDLL = LoadLibrary(L"lab1.1.dll");
	if (hDLL != NULL)
	{
		AddInts = (ADDINTSFUNC)GetProcAddress(hDLL, "DLLFunc1");
		if (!AddInts)
		{
			// handle the error  
			FreeLibrary(hDLL);
			return 400;
		}
		else
		{
			std::cout << "Adding ints";
			// call the function  
			std::cout << AddInts(10, 10);
		}
	}
}