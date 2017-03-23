// Lab2.4.h 
//
#include "..\\Lab02_1\\DLLclass.h"

// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the LAB02_4_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// LAB02_4_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef LAB02_4_EXPORTS
#define LAB02_4_API __declspec(dllexport)
#else
#define LAB02_4_API __declspec(dllimport)
#endif

class CDLLclass24Imp : public CDLLclass
{
public:
	CDLLclass24Imp();
	~CDLLclass24Imp();
	virtual bool Init(CAppUtil * pUtil);
	virtual bool Run(void);
	virtual void TearDown(void);
private:
	CAppUtil *pAppUtil; 
};

// Factory Method function 
extern "C" LAB02_4_API CDLLclass * CreateDllObject();

// Deletes a CDLLclass object
extern "C" LAB02_4_API void DeleteDllObject (CDLLclass *);
