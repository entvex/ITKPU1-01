   M S B A M L   `   `   `  ����Q  MMyCompositeApp.Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MyCompositeApp.DesktopMyCompositeApp.Desktop  5   	   A =Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:Common;assembly=CommonCommon 5   	   "    MyCompositeApp.Desktop.Shell   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MyCompositeApp.Desktop     5   	   P LPrism.Wpf, Version=6.1.0.0, Culture=neutral, PublicKeyToken=91a96d2a154366d8&regionshttp://prismlibrary.com/  5   	   1Common$clr-namespace:Common;assembly=Common  5   	     � Title$  
MainWindow��5
   	   $	��350��6   $	��525��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��5* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��5* �6   �� 5      $
��2.5* �6   .+�5   
   �� -   5         ��Name$ label��5      $��MyCompositeApp��6   $��1��68   $��Center=�6H   $��Center=�6e   $��14(�6�   �� 5   
   -   5        $��
MenuRegion��5   5   $��1��6   $��3��6$   $��Stretch=�6G   $��Stretch=�6e     Common.RegionName   
MenuRegion!  Prism.Regions.RegionManager   
RegionName# Z 6�   $��2q�6�   ��5      �� 5      .R�5      � 5      5      �� 5   
   -   5        $��StatusRegion��5   4   $��2��6   $��1��6$      StatusRegion# Z 6H   $��2q�6�   �� 5   
   -   5        $��	LogRegion��5   E   $��1��6   $��2��6$   $��2��65      	LogRegion# Z 6V   $��2q�6�   ��5       �� 5!      .R�5"      � 5#      5%      �� 5&   
   $ 
MainRegion��6   $��1��6G   $��1��6W   5'      5(      