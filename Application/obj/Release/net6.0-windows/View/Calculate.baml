   M S B A M L   `   `   `  ���� M  IFiltersApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:FiltersApplication.ViewModelFiltersApplication.ViewModel  '    !FiltersApplication.View.Calculate   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     @	ViewModel*clr-namespace:FiltersApplication.ViewModel        
Page_Style#��[    � DataContext  .  (FiltersApplication.ViewModel.CalculateVM  .��� 
������ .+��� ���#212529���#3A4149$��5q� �� CornerRadius$ 8,8,0,8��._��� $
��Auto=�.��� 
������  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��1��$��0��$��10,10,10,10q�.+��� ���#373E46$��10q�$	��400��$ 25��$	��400��._�� $��
10,10,2,10q�.+��� $
��Auto=�.��� .+��� $��20, 10, 20, 210q����#DCE0E4$ ��Электрофильтр��$��20(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��20, 50, 20, 20q����#DCE0E4 �� TextAlignment$ Justify=�$	��   ��$��16(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��1��$��1��$��10,10,10,10q�.+��� ���#373E46$��10q�$	��400��$ 25��$	��400��._�� $��
10,10,2,10q�.+��� $
��Auto=�.��� .+��� $��20, 10, 20, 210q����#DCE0E4$��Топливо��$��20(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��20, 50, 20, 20q����#DCE0E4$ Justify=�$	��   ��$��16(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��1��$��3��$��10,10,10,10q�.+��� ���#373E46$��10q�$	��400��$ 25��$	��400��._�� $��
10,10,2,10q�.+��� $
��Auto=�.��� .+��� $��20, 10, 20, 210q����#DCE0E4$"��Электростанция��$��20(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��20, 50, 20, 20q����#DCE0E4$ Justify=�$	��   ��$��16(�$
��Wrap=�$��Fonts/#Raleway SemiBold)�d� -    d�Name$ 	Start_Btn��$��1��$��3��$��50��$��50��$��Center=�$��Center=�  PlayBtn_Style#��[ �� -   $��	ImageLoad��$	��150��$y�	Collapsed=�$	��150��$��1��$��2��$	��Top=�$��Center=�  
Dial_Image#��[ $��Uniform=�� -   $��GridLoad��$	��150��$��1��$��2��$y�	Collapsed=�$	��150��$	��Top=�$��Center=�.+�A� $	��160��$	��160�����#212529$��18��$��Center=�$��Center=�A� $	��100��$	��100�����#4D4D4D$��10��$��Center=�$��Center=��� -    ��Name$ 
TimerLabel�����#FEF200$��60��$��60��$��30(�$��Center=�$��Center=�$ Center=�$��0,10,0,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 30Q�	   ShadowDepth$	 2Q�
   	Direction$	
 -90Q�   Color$ #FEF200���� -   $��LoadText�����#FFFFFF$��16��$	��150��$��10(�$��Center=�$ Center=�$��0,40,0,0q��� $��4��$��1��$��0 0 0 50q�$��Center=�$��Center=�$	��300��$	��300��$ ��/Images/calculate_page.png��$��Uniform=��� $��4��$��0��$��10,10,10,10q�.+�� $��
10,10,2,10q�.+��� $
��Auto=�.��� .+��� $��20, 10, 20, 210q����#DCE0E4$��20(�$
��Wrap=�$��Fonts/#Raleway SemiBold)����� *SelectedFuels+ �� UpdateSourceTrigger$ PropertyChanged=� �� IsAsync$
 True�� �� Mode$ TwoWay=��� $��20, 50, 20, 20q����#DCE0E4$ Justify=�$	��   ��$��16(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��4��$��2��$��10,10,10,10q�.+�� $��
10,10,2,10q�.+��� $
��Auto=�.��� .+��� $��20, 10, 20, 210q����#DCE0E4$��20(�$
��Wrap=�$��Fonts/#Raleway SemiBold)����� *SelectedFuels+$ PropertyChanged=�$
 True��$ TwoWay=��� $��20, 50, 20, 20q����#DCE0E4$ Justify=�$	��   ��$��16(�$
��Wrap=�$��Fonts/#Raleway SemiBold)�