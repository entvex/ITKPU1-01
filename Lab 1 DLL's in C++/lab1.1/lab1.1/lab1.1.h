// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the LAB11_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// LAB11_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef LAB11_EXPORTS
#define LAB11_API __declspec(dllexport)
#else
#define LAB11_API __declspec(dllimport)
#endif
#include <string>

// This class is exported from the lab1.1.dll
extern "C" LAB11_API int   AddInts(int a, int b);
extern "C" LAB11_API char* AddChars(char* a, char* b);
extern "C" LAB11_API std::string AddStrings(std::string a, std::string b);