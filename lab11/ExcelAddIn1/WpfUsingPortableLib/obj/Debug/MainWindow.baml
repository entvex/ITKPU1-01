   M S B A M L   `   `   `  ����N  JWpfUsingPortableLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfUsingPortableLibWpfUsingPortableLib  5   	   U QPortableClassLibraryOpgave, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�`clr-namespace:PortableClassLibraryOpgaveSimpleMVVM.ViewModel;assembly=PortableClassLibraryOpgave.PortableClassLibraryOpgaveSimpleMVVM.ViewModel 5   	   $    WpfUsingPortableLib.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WpfUsingPortableLib     5   	   v	viewModel`clr-namespace:PortableClassLibraryOpgaveSimpleMVVM.ViewModel;assembly=PortableClassLibraryOpgave     5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)    � 	Resources 5
      F  @PortableClassLibraryOpgaveSimpleMVVM.ViewModel.CustomerViewModel   	ViewModel��%   &	          5   
   6&   5      .��5      �  � DataContext 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� -   5        $��
textBlock2��5   d   $��23��6   $��5q�6    $��Right=�6+   $��0��6G   $��0��6W   $��Select a Customer:��5      $	��Top=�6.   �� 5   
   -   5        $��CustomersComboBox��5   W   $��23��6   $
��Left=�6   $��1��6:   $��0��6J   $	��Top=�6p   $	��173��6�    �� DisplayMemberPath$ FullName��5       �� SelectedItem 60   ��  �� Path$ CurrentCustomer�	 �� Mode$	 TwoWay=���6k   �� $ 	Customers��� 5   
   -   5        $��
textBlock4��5   d   $��23��6   $��5q�6    $��Right=�6+   $��0��6G   $��1��6W   $��Customer ID��6v   �� 5   
   -   5        $��
textBlock5��5   d   $��23��6   $��5q�6    $��Right=�6+   $��0��6G   $��2��6W   $
��Name��6v   �� 5   
   -   5        $��
textBlock9��5   d   $��23��6   $��5q�6    $��Right=�6+   $��0��6G   $��3��6W   $��Phone��6v   �� 5    
   -   5        $��CustomerIDTextBlock��5    X   $��23��6   $
��Left=�6    $��1��6;   $��1��6K   ��5!      �� 
 �� ElementName$
 CustomersComboBox��$ SelectedItem.CustomerID��� 5"   
   $��23��6   $
��Left=�6   $��1��69   $��2��6I   $	��219��6V   ��5#      �� $ CurrentCustomer.FullName�$	 TwoWay=��� 5$   
   $��23��6   $
��Left=�6   $��1��69   $��3��6I   $	��219��6V   ��5%      �� $ CurrentCustomer.Phone�$	 TwoWay=��� 5&   
   -   5        $��UpdateButton��5)      $��Update��5(      $��23��6   $��Right=�6*   $��0��6F   $��4��6V   $	��Top=�5)   !   $��75��69   ��5'      �� *UpdateCustomerCommand+5)   9   5*      5+      