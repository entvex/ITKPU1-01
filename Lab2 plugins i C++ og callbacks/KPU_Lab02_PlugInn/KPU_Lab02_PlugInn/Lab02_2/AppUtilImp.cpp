#include "stdafx.h"
#include "AppUtilImp.h"

using namespace std;

CAppUtilImp::CAppUtilImp(void)
{
	m_name = "No Name";
}

CAppUtilImp::CAppUtilImp(string name)
{
	m_name = name;
}

CAppUtilImp::~CAppUtilImp(void)
{
}

string CAppUtilImp::GetName(void)
{
	return m_name;
}

string CAppUtilImp::MyAddString(string str1, string str2)
{
	return str1 + str2;
}
