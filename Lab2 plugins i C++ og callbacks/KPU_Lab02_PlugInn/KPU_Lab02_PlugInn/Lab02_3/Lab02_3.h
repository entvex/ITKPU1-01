// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the LAB02_3_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// LAB02_3_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef LAB02_3_EXPORTS
#define LAB02_3_API __declspec(dllexport)
#else
#define LAB02_3_API __declspec(dllimport)
#endif

// Factory Method function 
extern "C" LAB02_3_API CDLLclass * CreateDllObject();

// Deletes a CDLLclass object
extern "C" LAB02_3_API void DeleteDllObject (CDLLclass *);
