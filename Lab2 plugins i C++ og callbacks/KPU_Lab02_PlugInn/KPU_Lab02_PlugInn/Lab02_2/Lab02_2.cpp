// Lab02_2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "..\\Lab02_1\\DLLclass.h"
#include "AppUtilImp.h"

using namespace std;

// Typedefs
// A typedef to hold the address of the factory method.
typedef CDLLclass * (*PFNCreateDllObject) ();

// A typedef to hold the address of the delete method.
typedef void (*PFNDeleteDllObject)(CDLLclass *);


int _tmain(int argc, _TCHAR* argv[])
{
	// Variables ----------------------------------------------------
	wstring pluginName;
	HINSTANCE dllHandle = NULL;	// Handle to dll 
	PFNCreateDllObject pfnCreateDllObject;
	PFNDeleteDllObject pfnDeleteDllObject;
	wstring caption = TEXT("Message from the Fabulous Main App");
	wstring msg = TEXT("");
	string name;
	CAppUtilImp *pUtil;

	// Execution starts here ---------------------------------------
	wcout << TEXT("Welcome to the fabulous Main App ----------------\n");
	wcout << TEXT("Please enter the name of the plug-in you want to load: ");
	getline(wcin, pluginName);

	// Load the dll and keep the handle to it
	dllHandle = LoadLibrary(pluginName.c_str());

	// If the handle is invalid, give error message and terminate. 
	if (dllHandle == NULL) 
	{
		msg = TEXT("Unable to load plug-in: ") + pluginName;
		::MessageBox(NULL, msg.c_str(), caption.c_str(), MB_OK);
		return 1;
	}

	// Find address of factory method
	pfnCreateDllObject = (PFNCreateDllObject) GetProcAddress(dllHandle, "CreateDllObject");

	// If the function isn't found, give error message and terminate. 
	if (pfnCreateDllObject == NULL) 
	{  
		msg = TEXT("An error occured while initializing the plug-in: ") + pluginName +
			TEXT(".\nUnable to access factory method!");
		::MessageBox(NULL, msg.c_str(), caption.c_str(), MB_OK);
		return 1;
	}

	cout << "Please enter your name: ";
	getline(cin, name);

	pUtil = new CAppUtilImp(name);

	// Create an plug-in object
	CDLLclass *pPlugin = pfnCreateDllObject();

	// Init plug-in
	pPlugin->Init(pUtil);
	// Run plug-in
	pPlugin->Run();
	// Tell the plug-in to clean up - it will soon be terminated
	pPlugin->TearDown();

	// Find address of delete method
	pfnDeleteDllObject = (PFNDeleteDllObject) GetProcAddress(dllHandle, "DeleteDllObject");
	if (pfnDeleteDllObject != NULL)
		pfnDeleteDllObject(pPlugin);

	delete pUtil;

	if (dllHandle != NULL)
		FreeLibrary(dllHandle);

  cout << "Press enter to terminate program: ";
	getline(cin, name);

	return 0;
}

