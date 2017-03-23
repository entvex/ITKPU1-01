﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace GUIFrontend
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace GUIFrontend.GUIFrontend_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[11];
            _typeNameTable[0] = "PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel";
            _typeNameTable[1] = "PortableClassLibraryOpgaveSimpleMVVM.ViewModel.ViewModelBase";
            _typeNameTable[2] = "Object";
            _typeNameTable[3] = "PortableClassLibraryOpgaveSimpleMVVM.ViewModel.RelayCommand";
            _typeNameTable[4] = "System.Collections.Generic.List`1<PortableClassLibraryOpgaveSimpleMVVM.Model.Customer>";
            _typeNameTable[5] = "PortableClassLibraryOpgaveSimpleMVVM.Model.Customer";
            _typeNameTable[6] = "Int32";
            _typeNameTable[7] = "String";
            _typeNameTable[8] = "GUIFrontend.MainPage";
            _typeNameTable[9] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[10] = "Windows.UI.Xaml.Controls.UserControl";

            _typeTable = new global::System.Type[11];
            _typeTable[0] = typeof(global::PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel);
            _typeTable[1] = typeof(global::PortableClassLibraryOpgaveSimpleMVVM.ViewModel.ViewModelBase);
            _typeTable[2] = typeof(global::System.Object);
            _typeTable[3] = typeof(global::PortableClassLibraryOpgaveSimpleMVVM.ViewModel.RelayCommand);
            _typeTable[4] = typeof(global::System.Collections.Generic.List<global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer>);
            _typeTable[5] = typeof(global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer);
            _typeTable[6] = typeof(global::System.Int32);
            _typeTable[7] = typeof(global::System.String);
            _typeTable[8] = typeof(global::GUIFrontend.MainPage);
            _typeTable[9] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[10] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_CustomerViewModel() { return new global::PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel(); }
        private object Activate_4_List() { return new global::System.Collections.Generic.List<global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer>(); }
        private object Activate_5_Customer() { return new global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer(); }
        private object Activate_8_MainPage() { return new global::GUIFrontend.MainPage(); }
        private void VectorAdd_4_List(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer>)instance;
            var newItem = (global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer)item;
            collection.Add(newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel
                userType = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("PortableClassLibraryOpgaveSimpleMVVM.ViewModel.ViewModelBase"));
                userType.Activator = Activate_0_CustomerViewModel;
                userType.AddMemberName("UpdateCustomerCommand");
                userType.AddMemberName("Customers");
                userType.AddMemberName("CurrentCustomer");
                xamlType = userType;
                break;

            case 1:   //  PortableClassLibraryOpgaveSimpleMVVM.ViewModel.ViewModelBase
                userType = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case 2:   //  Object
                xamlType = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  PortableClassLibraryOpgaveSimpleMVVM.ViewModel.RelayCommand
                userType = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 4:   //  System.Collections.Generic.List`1<PortableClassLibraryOpgaveSimpleMVVM.Model.Customer>
                userType = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.CollectionAdd = VectorAdd_4_List;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 5:   //  PortableClassLibraryOpgaveSimpleMVVM.Model.Customer
                userType = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_5_Customer;
                userType.AddMemberName("CustomerID");
                userType.AddMemberName("FullName");
                userType.AddMemberName("Phone");
                xamlType = userType;
                break;

            case 6:   //  Int32
                xamlType = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  String
                xamlType = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 8:   //  GUIFrontend.MainPage
                userType = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }


        private object get_0_CustomerViewModel_UpdateCustomerCommand(object instance)
        {
            var that = (global::PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel)instance;
            return that.UpdateCustomerCommand;
        }
        private object get_1_CustomerViewModel_Customers(object instance)
        {
            var that = (global::PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel)instance;
            return that.Customers;
        }
        private void set_1_CustomerViewModel_Customers(object instance, object Value)
        {
            var that = (global::PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel)instance;
            that.Customers = (global::System.Collections.Generic.List<global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer>)Value;
        }
        private object get_2_Customer_CustomerID(object instance)
        {
            var that = (global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer)instance;
            return that.CustomerID;
        }
        private void set_2_Customer_CustomerID(object instance, object Value)
        {
            var that = (global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer)instance;
            that.CustomerID = (global::System.Int32)Value;
        }
        private object get_3_Customer_FullName(object instance)
        {
            var that = (global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer)instance;
            return that.FullName;
        }
        private void set_3_Customer_FullName(object instance, object Value)
        {
            var that = (global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer)instance;
            that.FullName = (global::System.String)Value;
        }
        private object get_4_Customer_Phone(object instance)
        {
            var that = (global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer)instance;
            return that.Phone;
        }
        private void set_4_Customer_Phone(object instance, object Value)
        {
            var that = (global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer)instance;
            that.Phone = (global::System.String)Value;
        }
        private object get_5_CustomerViewModel_CurrentCustomer(object instance)
        {
            var that = (global::PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel)instance;
            return that.CurrentCustomer;
        }
        private void set_5_CustomerViewModel_CurrentCustomer(object instance, object Value)
        {
            var that = (global::PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel)instance;
            that.CurrentCustomer = (global::PortableClassLibraryOpgaveSimpleMVVM.Model.Customer)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlMember xamlMember = null;
            global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel.UpdateCustomerCommand":
                userType = (global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel");
                xamlMember = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlMember(this, "UpdateCustomerCommand", "PortableClassLibraryOpgaveSimpleMVVM.ViewModel.RelayCommand");
                xamlMember.Getter = get_0_CustomerViewModel_UpdateCustomerCommand;
                xamlMember.SetIsReadOnly();
                break;
            case "PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel.Customers":
                userType = (global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel");
                xamlMember = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlMember(this, "Customers", "System.Collections.Generic.List`1<PortableClassLibraryOpgaveSimpleMVVM.Model.Customer>");
                xamlMember.Getter = get_1_CustomerViewModel_Customers;
                xamlMember.Setter = set_1_CustomerViewModel_Customers;
                break;
            case "PortableClassLibraryOpgaveSimpleMVVM.Model.Customer.CustomerID":
                userType = (global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PortableClassLibraryOpgaveSimpleMVVM.Model.Customer");
                xamlMember = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlMember(this, "CustomerID", "Int32");
                xamlMember.Getter = get_2_Customer_CustomerID;
                xamlMember.Setter = set_2_Customer_CustomerID;
                break;
            case "PortableClassLibraryOpgaveSimpleMVVM.Model.Customer.FullName":
                userType = (global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PortableClassLibraryOpgaveSimpleMVVM.Model.Customer");
                xamlMember = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlMember(this, "FullName", "String");
                xamlMember.Getter = get_3_Customer_FullName;
                xamlMember.Setter = set_3_Customer_FullName;
                break;
            case "PortableClassLibraryOpgaveSimpleMVVM.Model.Customer.Phone":
                userType = (global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PortableClassLibraryOpgaveSimpleMVVM.Model.Customer");
                xamlMember = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlMember(this, "Phone", "String");
                xamlMember.Getter = get_4_Customer_Phone;
                xamlMember.Setter = set_4_Customer_Phone;
                break;
            case "PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel.CurrentCustomer":
                userType = (global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel");
                xamlMember = new global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlMember(this, "CurrentCustomer", "PortableClassLibraryOpgaveSimpleMVVM.Model.Customer");
                xamlMember.Getter = get_5_CustomerViewModel_CurrentCustomer;
                xamlMember.Setter = set_5_CustomerViewModel_CurrentCustomer;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlSystemBaseType
    {
        global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::GUIFrontend.GUIFrontend_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}
