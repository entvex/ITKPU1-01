// lab2.2Tester.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "../lab2.1/lab2.1.h"
#include <iostream>
#pragma once

int main()
{    
	Clab21 clab21;

	std::cout << "testing exported class" << std::endl;
	std::cout << "adding 10 + 10" << std::endl;
	std::cout << clab21.AddInts(10,10) << std::endl;
	std::cout << "adding chars" << std::endl;
	std::cout << clab21.AddChars("Meep","meep2")<< std::endl;
	std::cout << "adding two Strings" << std::endl;
	std::cout << clab21.AddStrings("String1","Steing2")<< std::endl;
}