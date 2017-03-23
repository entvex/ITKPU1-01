

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 8.00.0603 */
/* at Tue Feb 21 15:31:05 2017
 */
/* Compiler settings for exercise3_1.idl:
    Oicf, W1, Zp8, env=Win32 (32b run), target_arch=X86 8.00.0603 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __exercise3_1_i_h__
#define __exercise3_1_i_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __Icalc_FWD_DEFINED__
#define __Icalc_FWD_DEFINED__
typedef interface Icalc Icalc;

#endif 	/* __Icalc_FWD_DEFINED__ */


#ifndef __calc_FWD_DEFINED__
#define __calc_FWD_DEFINED__

#ifdef __cplusplus
typedef class calc calc;
#else
typedef struct calc calc;
#endif /* __cplusplus */

#endif 	/* __calc_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

#ifdef __cplusplus
extern "C"{
#endif 


#ifndef __Icalc_INTERFACE_DEFINED__
#define __Icalc_INTERFACE_DEFINED__

/* interface Icalc */
/* [unique][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_Icalc;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("89203B20-5D1A-41F0-8612-258F2C140C9C")
    Icalc : public IDispatch
    {
    public:
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Add( 
            /* [in] */ LONG n1,
            /* [in] */ LONG n2,
            /* [out] */ LONG *result) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Sub( 
            /* [in] */ LONG n1,
            /* [in] */ LONG n2,
            /* [retval][out] */ LONG *result) = 0;
        
        virtual /* [id][propget] */ HRESULT STDMETHODCALLTYPE get_offset( 
            /* [retval][out] */ LONG *pVal) = 0;
        
        virtual /* [id][propput] */ HRESULT STDMETHODCALLTYPE put_offset( 
            /* [in] */ LONG newVal) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IcalcVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            Icalc * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            Icalc * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            Icalc * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            Icalc * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            Icalc * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            Icalc * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            Icalc * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Add )( 
            Icalc * This,
            /* [in] */ LONG n1,
            /* [in] */ LONG n2,
            /* [out] */ LONG *result);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Sub )( 
            Icalc * This,
            /* [in] */ LONG n1,
            /* [in] */ LONG n2,
            /* [retval][out] */ LONG *result);
        
        /* [id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_offset )( 
            Icalc * This,
            /* [retval][out] */ LONG *pVal);
        
        /* [id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_offset )( 
            Icalc * This,
            /* [in] */ LONG newVal);
        
        END_INTERFACE
    } IcalcVtbl;

    interface Icalc
    {
        CONST_VTBL struct IcalcVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define Icalc_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define Icalc_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define Icalc_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define Icalc_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define Icalc_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define Icalc_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define Icalc_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define Icalc_Add(This,n1,n2,result)	\
    ( (This)->lpVtbl -> Add(This,n1,n2,result) ) 

#define Icalc_Sub(This,n1,n2,result)	\
    ( (This)->lpVtbl -> Sub(This,n1,n2,result) ) 

#define Icalc_get_offset(This,pVal)	\
    ( (This)->lpVtbl -> get_offset(This,pVal) ) 

#define Icalc_put_offset(This,newVal)	\
    ( (This)->lpVtbl -> put_offset(This,newVal) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __Icalc_INTERFACE_DEFINED__ */



#ifndef __exercise3_1Lib_LIBRARY_DEFINED__
#define __exercise3_1Lib_LIBRARY_DEFINED__

/* library exercise3_1Lib */
/* [version][uuid] */ 


EXTERN_C const IID LIBID_exercise3_1Lib;

EXTERN_C const CLSID CLSID_calc;

#ifdef __cplusplus

class DECLSPEC_UUID("35AB0EE9-C7C0-4592-BCDD-7A780E43B411")
calc;
#endif
#endif /* __exercise3_1Lib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


