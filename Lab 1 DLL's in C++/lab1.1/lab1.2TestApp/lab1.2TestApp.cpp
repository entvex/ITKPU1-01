// lab1.2TestApp.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "lab1.1.h"
#include <iostream>


int main()
{
	std::cout << "Test app \n";

	std::cout << "10+10 is ";
	std::cout << AddInts(10, 10);
	std::cout << "\n";
	std::cout << "Two chars added ";
	std::cout << AddChars("meep ", "eep2");
	std::cout << "\n";
	std::cout << "Add two strings ";
	std::cout << AddStrings("Addd", " Strings");
	std::cout << "\n";

    return 0;
}