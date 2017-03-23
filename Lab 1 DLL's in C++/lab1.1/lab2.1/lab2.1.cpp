// lab2.1.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "lab2.1.h"

// This is the constructor of a class that has been exported.
// see lab2.1.h for the class definition
Clab21::Clab21()
{

}

int Clab21::AddInts(int a, int b)
{
	return a + b;
}

char* Clab21::AddChars(char* a, char* b)
{
	int buff = std::strlen(a) + std::strlen(b);
	auto* result = new char[buff];

	strcpy(result, a); // copy string one into the result.
	strcat(result, b); // append string two to the result.

	return result;
}

std::string Clab21::AddStrings(std::string a, std::string b)
{
	return  a + b;
}