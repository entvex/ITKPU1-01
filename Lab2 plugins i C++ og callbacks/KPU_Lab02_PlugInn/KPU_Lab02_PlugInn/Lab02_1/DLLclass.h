// DLLclass.h
#pragma once

#include "AppUtil.h"

class CDLLclass
{
public:
	virtual bool Init(CAppUtil * pUtil) = 0;
	virtual bool Run(void) = 0;
	virtual void TearDown(void) =0;
};

// Plug-ins must implement these functions:
// Factory Method function 
// CDLLclass * CreateDllObject();

// Deletes a CDLLclass object
// void DeleteDllObject (CDLLclass *);