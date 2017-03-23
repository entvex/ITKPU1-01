// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the LAB21_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// LAB21_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef LAB21_EXPORTS
#define LAB21_API __declspec(dllexport)
#else
#define LAB21_API __declspec(dllimport)
#endif
#include <string>

// This class is exported from the lab2.1.dll
class LAB21_API Clab21 {
public:
	Clab21(void);
	int AddInts(int a, int b);
	char* AddChars(char* a, char* b);
	std::string AddStrings(std::string a, std::string b);	
};