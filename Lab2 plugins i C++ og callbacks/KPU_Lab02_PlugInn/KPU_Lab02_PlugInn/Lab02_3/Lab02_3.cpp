// Lab02_3.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "..\\Lab02_1\\DLLclass.h"
#include "Lab02_3.h"

using namespace std;

class CDLLclass23Imp : public CDLLclass
{
public:
	CDLLclass23Imp();
	~CDLLclass23Imp();
	virtual bool Init(CAppUtil * pUtil);
	virtual bool Run(void);
	virtual void TearDown(void);
private:
	CAppUtil *pAppUtil; 
	char * pName;
};

// Factory Method function 
CDLLclass * CreateDllObject()
{
	return new CDLLclass23Imp();
}

// Deletes a CDLLclass object
void DeleteDllObject (CDLLclass *pObj)
{
	delete pObj;
}

CDLLclass23Imp::CDLLclass23Imp()
{
	pName = NULL;
}

CDLLclass23Imp::~CDLLclass23Imp()
{
	if (pName != NULL)
		delete [] pName;
}

bool CDLLclass23Imp::Init(CAppUtil * pUtil)
{
	pAppUtil = pUtil;
	string name = pUtil->GetName();
	rsize_t length = name.length() + 1;
	pName = new char [length];
	if (pName == NULL)
		return false;
	strcpy_s(pName, length, name.c_str());
	return true;
}

bool CDLLclass23Imp::Run(void)
{
	string message = pAppUtil->MyAddString("Hi ", pName);
	cout << message << endl;
	return true;
}

void CDLLclass23Imp::TearDown(void)
{
	if (pName != NULL)
	{
		delete [] pName;
		pName = NULL;
	}
}

