   M S B A M L   `   `   `  ���� M  IFiltersApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:FiltersApplication.UtilitiesFiltersApplication.Utilities  A%clr-namespace:FiltersApplication.ViewFiltersApplication.View  K*clr-namespace:FiltersApplication.ViewModelFiltersApplication.ViewModel  "    FiltersApplication.View.Home   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <style*clr-namespace:FiltersApplication.Utilities     7local%clr-namespace:FiltersApplication.View     9vm*clr-namespace:FiltersApplication.ViewModel     
������   � DataContext  /  )FiltersApplication.ViewModel.NavigationVM  .��� .+��� $��/Images/home_page.png��$
��Fill=� J� Opacity$	 0.3Q��� 
������ ���#3A4149$��5q� �� CornerRadius$ 8,8,0,8���� ���� ����  �� 
TargetType" ��.���  �� Property � ��   Home_Laptop_Layout �� Value# [   �� Triggers ��  �� Binding ��  �� Path$ ActualWidth�	 �� RelativeSource	 �� 
 �� AncestorType

 Window9   3FiltersApplication.Utilities.IsGreaterThanConverter   Instance �� 	Converter# Z  �� ConverterParameter$
 1400�� �� Value True.a���  � ��  Home_Desktop_Layout# [ ��  �� $ ActualWidth�	 �� 

 Window6   0FiltersApplication.Utilities.IsLessThanConverter   Instance# Z $
 1200�� True.a���  � ��   Home_Tablet_Landscape_Layout# [ ��  �� $ ActualWidth�	 �� 

 Window# Z $
 1024�� True.a���  � ��  Home_Tablet_Portrait_Layout# [ ��  �� $ ActualWidth�	 �� 

 Window# Z $	 812�� True.a���  � ��   Home_Mobile_Landscape_Layout# [ ��  �� $ ActualWidth�	 �� 

 Window# Z $	 667�� True.a���  � ��  Home_Mobile_Portrait_Layout# [ 