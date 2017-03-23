// lab1.1.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "lab1.1.h"
#include <iostream>
#include <cstring>
// This is an example of an exported function.
LAB11_API int AddInts(int a, int b)
{
	return a + b;
}

LAB11_API char* AddChars(char* a, char* b)
{
	int buff = std::strlen(a) + std::strlen(b);
	char* result = new char[buff];
	
	strcpy(result, a); // copy string one into the result.
	strcat(result, b); // append string two to the result.

	return result;
}

LAB11_API std::string AddStrings(std::string a, std::string b)
{
	return  a + b;
}