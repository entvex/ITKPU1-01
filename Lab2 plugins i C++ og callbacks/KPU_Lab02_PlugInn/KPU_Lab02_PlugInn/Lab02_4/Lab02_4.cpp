// Lab02_4.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "Lab02_4.h"

using namespace std;

// Factory Method function 
CDLLclass * CreateDllObject()
{
	return new CDLLclass24Imp();
}

// Deletes a CDLLclass object
void DeleteDllObject (CDLLclass *pObj)
{
	delete pObj;
}

CDLLclass24Imp::CDLLclass24Imp()
{
	pAppUtil = NULL;
}

CDLLclass24Imp::~CDLLclass24Imp()
{
	// No initialization needed
}

bool CDLLclass24Imp::Init(CAppUtil * pUtil)
{
	pAppUtil = pUtil;
	
	return true;
}

bool CDLLclass24Imp::Run(void)
{
	if (pAppUtil == NULL)
		return false;
	cout << "Wake up " << pAppUtil->GetName() << endl;
	return true;
}

void CDLLclass24Imp::TearDown(void)
{
	// No clean up needed
}

