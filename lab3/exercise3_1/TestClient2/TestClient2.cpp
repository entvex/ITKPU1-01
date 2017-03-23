// TestClient2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include "../exercise3_1/exercise3_1_i.h"
#include "../exercise3_1/exercise3_1_i.c"
int main()
{
	CoInitialize(NULL);
	IUnknown* pUnk = NULL;
	Icalc* calc = NULL;
	HRESULT hr = E_FAIL;
	IClassFactory* pCF = NULL;


	hr = CoGetClassObject(CLSID_calc, CLSCTX_INPROC_SERVER,
		NULL, IID_IClassFactory, (void**)&pCF);
	if (SUCCEEDED(hr))
		hr = pCF->CreateInstance(NULL, IID_Icalc, (void**)&calc);
	else
	{
		//cout << "Debug info: Unable to load COM-server get access to Class Factory";
		MessageBox(NULL, TEXT("Unable to load COM-server and get access to Class Factory!"), TEXT("Raw Com Car Says:"), MB_OK);
		exit(1);
		return 0;

	}
	LONG r;
	calc->Add(10, 10, &r);
	std::cout << r << std::endl;
}
