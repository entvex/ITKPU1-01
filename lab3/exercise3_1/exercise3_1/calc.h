// calc.h : Declaration of the Ccalc

#pragma once
#include "resource.h"       // main symbols



#include "exercise3_1_i.h"



#if defined(_WIN32_WCE) && !defined(_CE_DCOM) && !defined(_CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA)
#error "Single-threaded COM objects are not properly supported on Windows CE platform, such as the Windows Mobile platforms that do not include full DCOM support. Define _CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA to force ATL to support creating single-thread COM object's and allow use of it's single-threaded COM object implementations. The threading model in your rgs file was set to 'Free' as that is the only threading model supported in non DCOM Windows CE platforms."
#endif

using namespace ATL;


// Ccalc

class ATL_NO_VTABLE Ccalc :
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<Ccalc, &CLSID_calc>,
	public IDispatchImpl<Icalc, &IID_Icalc, &LIBID_exercise3_1Lib, /*wMajor =*/ 1, /*wMinor =*/ 0>
{
public:
	long offset = 0;
	Ccalc()
	{
	}

DECLARE_REGISTRY_RESOURCEID(IDR_CALC)


BEGIN_COM_MAP(Ccalc)
	COM_INTERFACE_ENTRY(Icalc)
	COM_INTERFACE_ENTRY(IDispatch)
END_COM_MAP()



	DECLARE_PROTECT_FINAL_CONSTRUCT()

	HRESULT FinalConstruct()
	{
		return S_OK;
	}

	void FinalRelease()
	{
	}

	STDMETHOD(Add)(LONG n1, LONG n2, LONG* result);
	STDMETHOD(Sub)(LONG n1, LONG n2, LONG* result);
	STDMETHOD(get_offset)(LONG* pVal);
	STDMETHOD(put_offset)(LONG newVal);
};

OBJECT_ENTRY_AUTO(__uuidof(calc), Ccalc)
