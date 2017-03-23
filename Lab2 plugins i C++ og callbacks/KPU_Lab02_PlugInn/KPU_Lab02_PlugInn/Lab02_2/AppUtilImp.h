#pragma once

#include "..\lab02_1\AppUtil.h"

class CAppUtilImp : public CAppUtil
{
public:
	CAppUtilImp(void);
	CAppUtilImp(string name);
	virtual ~CAppUtilImp(void);

	virtual string GetName();
	virtual string MyAddString(string str1, string str2);

private:
	string m_name;
};

