   M S B A M L   `   `   `  ����M  IFiltersApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:FiltersApplication.UtilitiesFiltersApplication.Utilities  5      A%clr-namespace:FiltersApplication.ViewFiltersApplication.View  5      K*clr-namespace:FiltersApplication.ViewModelFiltersApplication.ViewModel  5      "    FiltersApplication.View.Home   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <style*clr-namespace:FiltersApplication.Utilities     5      7local%clr-namespace:FiltersApplication.View     5      9vm*clr-namespace:FiltersApplication.ViewModel     5      
������   � DataContext  5      /  )FiltersApplication.ViewModel.NavigationVM  5   
   .��5      � .+�5   
   �� $��/Images/home_page.png��6   $
��Fill=�5       J� Opacity$	 0.3Q�6+   �� 5   
   
������ ���#3A4149$��5q�5   
    �� CornerRadius$ 8,8,0,8��5   
   �� 5   
   ��6   �� ��5      �� 5       �� 
TargetType" ��6   .�5#      ��  �� Property � ��   Home_Laptop_Layout �� Value# [  5$       �� Triggers 5%      �� 5)       �� Binding 6&   ��  �� Path$ ActualWidth�	 �� RelativeSource	 �� 
 �� AncestorType

 Window9   3FiltersApplication.Utilities.IsGreaterThanConverter   Instance �� 	Converter# Z  �� ConverterParameter$
 1400�� �� Value True5*   "   .a�5,      ��  � ��  Home_Desktop_Layout# [ 5-   !   5/      �� 53       6&   �� $ ActualWidth�	 �� 

 Window6   0FiltersApplication.Utilities.IsLessThanConverter   Instance# Z $
 1200�� True54   "   .a�56      ��  � ��   Home_Tablet_Landscape_Layout# [ 57   !   59      �� 5=       6&   �� $ ActualWidth�	 �� 

 Window# Z $
 1024�� True5>   "   .a�5@      ��  � ��  Home_Tablet_Portrait_Layout# [ 5A   !   5C      �� 5G       6&   �� $ ActualWidth�	 �� 

 Window# Z $	 812�� True5H   "   .a�5J      ��  � ��   Home_Mobile_Landscape_Layout# [ 5K   !   5M      �� 5Q       6&   �� $ ActualWidth�	 �� 

 Window# Z $	 667�� True5R   "   .a�5T      ��  � ��  Home_Mobile_Portrait_Layout# [ 5U   !   5W      5[      5_      5a      5c      