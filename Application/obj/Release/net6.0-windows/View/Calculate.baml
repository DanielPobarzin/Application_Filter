   M S B A M L   `   `   `  ���� M  IFiltersApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:FiltersApplication.ViewModelFiltersApplication.ViewModel  K*clr-namespace:FiltersApplication.UtilitiesFiltersApplication.Utilities  '    !FiltersApplication.View.Calculate   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     @	ViewModel*clr-namespace:FiltersApplication.ViewModel     <style*clr-namespace:FiltersApplication.Utilities        
Page_Style#��[    � 	Resources    AshCleanForFourFieldFilter � 	Resources7   1FiltersApplication.Utilities.RandomColorConverter  Key ��Name �� CornerRadius �� RelativeSource  RandomColorConverter �� 	Converter � RowDefinitions � ColumnDefinitions �� Orientation	 �� TextAlignment
 �� 
StartPoint �� EndPoint � Offset � Color �� 
IsReadOnly �� TextAlignment J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   
BlurRadius   Opacity   Color �� AncestorType �� Path  DegreeAshCapture  AshCleanForThreeFieldFilter��%(  &	       7  &	 �    7  &	 �    7  ��  ��  RandomColorConverter .R�� .+��� $ ExternalBorder��$��10 10 10 10q�$��4q�$ 20������  �� *Self+8   ._��� ���#3A4149$��3 3 3 3q�$ 20��._��  �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � �� $��1* ��� $��1* �.+��� $��0��$��0��$��2��$ 
Horizontal=�$��10q�$	��Top=�$��Stretch=�.+��� $
	 Left=�$
��Left=����#DCE0E4$��Топливо: ��$��18(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $
��Fuel��$
	 Left=�$
��Left=����#DCE0E4$��18(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $ InternalBorder��$��Bottom=�$��Stretch=�$��5��$ 2��$��1��$��0��$��2��$��5 0 5 0q����� $	
 0,0&�$	 1,0&�.��� $ 0Q�� $ #3A4149��$ 1Q��� $	��Top=�$��0��$��2��$��
5, 5, 5, 5q�$��20��$
��Left=�$	��120�����#DCE0E4$
	 Left=�$��Для 1 поля: ��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��
FirstField��$��10, 10, 10, 10q�$
 true��$��1��$��2��$	��120��$��20��$	��200��$
 Left=�$��15(�
�������$��Fonts/#Raleway SemiBold)��� $	��Top=�$��0��$��3��$��
5, 5, 5, 5q�$��20��$
��Left=�$	��120�����#DCE0E4$
	 Left=�$��Для 2 поля: ��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��SecondField��$��10, 10, 10, 10q�$
 true��$��1��$��3��$	��120��$��20��$	��200��$
 Left=�$��15(�
�������$��Fonts/#Raleway SemiBold)��� $	��Top=�$��0��$��4��$��
5, 5, 5, 5q�$��20��$
��Left=�$	��120�����#DCE0E4$
	 Left=�$��Для 3 поля: ��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��
ThirdField��$��10, 10, 10, 10q�$
 true��$��1��$��4��$	��120��$��20��$	��200��$
 Left=�$��15(�
�������$��Fonts/#Raleway SemiBold)��� $	��Top=�$��0��$��5��$��
5, 5, 5, 5q�$��20��$
��Left=�$	��120�����#DCE0E4$
	 Left=�$��Для 4 поля: ��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��	FourField��$��10, 10, 10, 10q�$
 true��$��1��$��5��$	��120��$��20��$	��200��$
 Left=�$��15(�
�������$��Fonts/#Raleway SemiBold)�   $ 0Q�$ 20Q�$	 0.5Q� ��  �� 
 Border$ BorderBrush.Color���  ��  RandomColorConverter .R�� .+��� $ ExternalBorder��$��10 10 10 10q�$��4q�$ 20������  �� *Self+8   ._��� ���#3A4149$��3 3 3 3q�$ 20��._��  �� $
��Auto ��� $
��Auto ��� $
��Auto � �� $��1* ��� $��1* �.+��� $��0��$��0��$��2��$ 
Horizontal=�$��10q�$	��Top=�$��Stretch=�.+��� $
	 Left=�$
��Left=����#DCE0E4$��Топливо: ��$��18(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $
��Fuel��$
	 Left=�$
��Left=����#DCE0E4$��18(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $ InternalBorder��$��Bottom=�$��Stretch=�$��5��$ 2��$��1��$��0��$��2��$��5 0 5 0q����� $	
 0,0&�$	 1,0&�.��� $ 0Q�� $ #3A4149��$ 1Q��� $	��Top=�$��0��$��2��$��
5, 5, 5, 5q�$��20��$
��Left=�$	��150�����#DCE0E4$
	 Left=�$#��Улавливание в %: ��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��
FirstField��$��10, 10, 10, 10q�$
 true��$��1��$��2��$	��120��$��20��$	��200��$
 Left=�$��15(�
�������$��Fonts/#Raleway SemiBold)�   $ 0Q�$ 20Q�$	 0.5Q� ��  �� 
 Border$ BorderBrush.Color���  ��  RandomColorConverter .R��� $ ExternalBorder��$��10 10 10 10q�$��4q�$ 20������  �� *Self+8   ._��� ���#3A4149$��3 3 3 3q�$ 20��._��  �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � �� $��1* ��� $��1* �.+��� $��0��$��0��$��2��$ 
Horizontal=�$��10q�$	��Top=�$��Stretch=�.+��� $
	 Left=�$
��Left=����#DCE0E4$��Топливо: ��$��18(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $
��Fuel��$
	 Left=�$
��Left=����#DCE0E4$��18(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $ InternalBorder��$��Bottom=�$��Stretch=�$��5��$ 2��$��1��$��0��$��2��$��5 0 5 0q����� $	
 0,0&�$	 1,0&�.��� $ 0Q�� $ #3A4149��$ 1Q��� $	��Top=�$��0��$��2��$��
5, 5, 5, 5q�$��20��$
��Left=�$	��120�����#DCE0E4$
	 Left=�$��Для 1 поля: ��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��
FirstField��$��10, 10, 10, 10q�$
 true��$��1��$��2��$	��120��$��20��$	��200��$
 Left=�$��15(�
�������$��Fonts/#Raleway SemiBold)��� $	��Top=�$��0��$��3��$��
5, 5, 5, 5q�$��20��$
��Left=�$	��120�����#DCE0E4$
	 Left=�$��Для 2 поля: ��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��SecondField��$��10, 10, 10, 10q�$
 true��$��1��$��3��$	��120��$��20��$	��200��$
 Left=�$��15(�
�������$��Fonts/#Raleway SemiBold)��� $	��Top=�$��0��$��4��$��
5, 5, 5, 5q�$��20��$
��Left=�$	��120�����#DCE0E4$
	 Left=�$��Для 3 поля: ��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��
ThirdField��$��10, 10, 10, 10q�$
 true��$��1��$��4��$	��120��$��20��$	��200��$
 Left=�$��15(�
�������$��Fonts/#Raleway SemiBold)�   $ 0Q�$ 20Q�$	 0.5Q� ��  �� 
 Border$ BorderBrush.Color� � DataContext .  (FiltersApplication.ViewModel.CalculateVM  .��� 
������ .+��� ���#212529���#3A4149$��5q�$ 8,8,0,8��$��0,0,0,0q�._��� $
��Auto=�.��� 
������  �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � �� $��1* ��� $��1* ��� $��1* �.+��� $��1��$��0��$��10,10,10,10q�.+��� ���#373E46$��10q�$	��400��$ 25��$	��400��._�� $��
10,10,2,10q�.+��� $
��Auto=�.��� .+��� $��20, 10, 20, 210q����#DCE0E4$ ��Электрофильтр��$��20(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��20, 50, 20, 20q����#DCE0E4$	 Justify=�$	��   ��$��16(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��1��$��1��$��10,10,10,10q�.+��� ���#373E46$��10q�$	��400��$ 25��$	��400��._�� $��
10,10,2,10q�.+��� $
��Auto=�.��� .+��� $��20, 10, 20, 210q����#DCE0E4$��Топливо��$��20(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� -   $��FuelText��$��20, 50, 20, 20q����#DCE0E4$	 Justify=�$��16(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��1��$��3��$��10,10,10,10q�.+��� ���#373E46$��10q�$	��400��$ 25��$	��400��._�� $��
10,10,2,10q�.+��� $
��Auto=�.��� .+��� $��20, 10, 20, 210q����#DCE0E4$
��ыв��$��20(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��20, 50, 20, 20q����#DCE0E4$	 Justify=�$��А��$��16(�$
��Wrap=�$��Fonts/#Raleway SemiBold)�d� -    d�Name$ 	Start_Btn��$��1��$��3��$��10q�$��50��$��50��$��Center=�$��Center=�  PlayBtn_Style#��[  d� 	IsChecked$ FalseY��� -   $��	ImageLoad��$	��150��$y�	Collapsed=�$	��150��$��1��$��2��$	��Top=�$��Center=�  
Dial_Image#��[ $��Uniform=��� -   $��StartCalculate��$y�Visible=�$��1��$��2��$��50��$	��150��$	��Top=�$��Center=�.+��� ���	#FF0BCDFF$��50��$	��150��$ 25��._��� $	 Center=�$��Center=�$��Center=�
���   �$��К РАСЧЕТУ��$��20(�$
��Wrap=�$��Century Gothic)�� -   $��GridLoad��$	��150��$��1��$��2��$y�	Collapsed=�$	��150��$	��Top=�$��Center=�.+�A� $	��160��$	��160�����#212529$��18��$��Center=�$��Center=�A� $	��100��$	��100�����#4D4D4D$��10��$��Center=�$��Center=��� -    ��Name$ 
TimerLabel�����#FEF200$��60��$��60��$��30(�$��Center=�$��Center=�$	 Center=�$��0,10,0,0q�   $ 30Q�$ 2Q�   	Direction$	 -90Q�$ #FEF200���� -   $��LoadText�����#FFFFFF$��16��$	��150��$��10(�$��Center=�$	 Center=�$��0,40,0,0q��� -   $��BorderSuccess��$��0��$��3��$��4��$��20 20 20 20q�$��5��$ 20�����	#FF0BCDFF$��6q�$��10��$��10��$	��800��._�� $��20 20 20 20q� �� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��1��$��20 20 20 20q�$	��Top=�$��Center=�$	��300��$	��300��$ ��/Images/calculate_page.png��$��Uniform=�� $��1��$��0��$��10,10,10,10q�$��Bottom=�$��Center=� �� $
��Auto ��� $
��Auto �.+��� $ 
Horizontal=�$��0��$	��Top=�$��Stretch=�.+��� $��20, 20, 20, 20q�$	��Top=�$��60��$��Center=����#DCE0E4$3��-Степень золоулавливания��$��20(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� ���#3A4149$��1��$ 25��$	��Top=�$	��250��$��Stretch=�$��10 10 10 10q�._��� $
��Auto=�$��10 10 10 10q�.��� -	    �Name$ DegreeAshCapture�� � IsSharedSizeScope$
 True��� $��0��$��0��$��10,10,10,10q� �� $
��Auto ��� $
��Auto �.+��� $ 
Horizontal=�$��0��$	��Top=�$��Stretch=�.+��� $��20, 20, 20, 20q�$	��Top=�$��60��$��Center=����#DCE0E4$'��!Концентрация золы��$��20(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� ���#3A4149$��1��$ 25��$	��Top=�$	��600��$��Stretch=�$��10 10 10 10q�._��� $
��Auto=�$��10 10 10 10q�.��� -
   $ GridAshClean��$
 True��� $��2��$��0��$��
10,10,2,10q�.+��� $
��Auto=�.��� $	��200�� �� $
��Auto ��� $
��Auto �.+��� $ 
Horizontal=�$��0��$	��Top=�$��Stretch=�.+��� $��20, 20, 20, 20q�$	��Top=�$��60��$��Center=����#DCE0E4$@��:Оптимальный режим встряхивания��$��20(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� ���#3A4149$��1��$ 25��$	��Top=�$	��600��$��Stretch=�$��10 10 10 10q�._��� $
��Auto=�$��10 10 10 10q�.��� -   $ GridOptimalShakeMode��$
 True��