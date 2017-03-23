// calc.cpp : Implementation of Ccalc

#include "stdafx.h"
#include "calc.h"


// Ccalc



STDMETHODIMP Ccalc::Add(LONG n1, LONG n2, LONG* result)
{
	*result = n1 + n2 + offset;
	return S_OK;
}


STDMETHODIMP Ccalc::Sub(LONG n1, LONG n2, LONG* result)
{
	*result = n1 - n2 + offset;
	return S_OK;
}


STDMETHODIMP Ccalc::get_offset(LONG* pVal)
{
	*pVal = offset;
	return S_OK;
}


STDMETHODIMP Ccalc::put_offset(LONG newVal)
{
	offset = newVal;
	return S_OK;
}
