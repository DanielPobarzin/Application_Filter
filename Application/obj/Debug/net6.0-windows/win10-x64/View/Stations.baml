   M S B A M L   `   `   `  ����M  IFiltersApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:FiltersApplication.ViewModelFiltersApplication.ViewModel  5      K*clr-namespace:FiltersApplication.UtilitiesFiltersApplication.Utilities  5      &     FiltersApplication.View.Stations   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9vm*clr-namespace:FiltersApplication.ViewModel     5      ;Menu*clr-namespace:FiltersApplication.Utilities     5      k gTelerik.Windows.Cloud.Controls, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7t	 pTelerik.Windows.Controls.Chart.Direct2D, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n
 jTelerik.Windows.Controls.Charting, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7v rTelerik.Windows.Controls.ConversationalUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r nTelerik.Windows.Controls.DataServices, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Diagrams, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7y uTelerik.Windows.Controls.Diagrams.Extensions, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7u qTelerik.Windows.Controls.Diagrams.Ribbon, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m iTelerik.Windows.Controls.Docking, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7y uTelerik.Windows.Controls.EntityFrameworkCore, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.Expressions, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.FileDialogs, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7z vTelerik.Windows.Controls.FixedDocumentViewers, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7| xTelerik.Windows.Controls.FixedDocumentViewersUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GanttView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.GridView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.ImageEditor, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Media, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.RichTextBox, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r  nTelerik.Windows.Controls.ScheduleView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q! mTelerik.Windows.Controls.Spreadsheet, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7s" oTelerik.Windows.Controls.SpreadsheetUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r# nTelerik.Windows.Controls.SyntaxEditor, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q$ mTelerik.Windows.Controls.VirtualGrid, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a% ]Telerik.Windows.Data, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k& gTelerik.Windows.Documents.Core, Version=2022.1.217.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q' mTelerik.Windows.PersistenceFramework, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l( hTelerik.Windows.Scheduling.Core, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7�telerik1http://schemas.telerik.com/2008/xaml/presentation#    	 
                        ! " # $ % & ' ( 5         
Page_Style#��[  5        � DataContext  5      ,  &FiltersApplication.ViewModel.StationVM  5   
   .��5      � -   5         �Name$ StationGrid��5      
������ .+�5   
   �� ���#212529���#3A4149$��5q�5       �� CornerRadius$ 8,8,0,8��5   	   ._�5      �� $
��Auto=�6   .��5      �  � ColumnDefinitions 5      �� 5      -   5         ��Name$ c0��5   +   $��1* �5      �� 5      -   5        $ c1��5   +   $��1* �5      �� 5      -   5        $ c2��5   +   $��1* �5      �� 5       -   5        $ c3��5    +   $��1* �5!       � RowDefinitions 5%      �� 5'      -   5         ��Name$ CG_R1��5'   (   $��1* �5(      �� 5)      -   5        $ CG_R2��5)   (   $��1* �5*      �� 5+      -   5        $ CG_R5��5+   (   $��1* �5,      �� 5-      -	   5        $ CG_R6��5-   (   $
��Auto �5.      .+�51      �� 
������ $��0 20 0 0q�68   $��0��6J   $��4��6Z   $��0��6n   $��2��6{   ._�52      �� $��/Images/station_page.png��6   $��UniformToFill=�6>   53      �� 54      ���#373E46$	��300��62   $	��Top=�6B   $��
20 0 20 20q�6Z   $ 25��6n   $��0��6�   $��2��6�   $��2��6�   $��3��6�   ._�55      � $��10,10,10,10q�6   .+�56      �� $
��Auto=�6+   .��57   "   � .+�59   &   �� $��20, 10, 20, 210q�60   ���#DCE0E4$��22(�6^   $��К сведению��6m   $
��Wrap=�6   $��Fonts/#Raleway SemiBold)�6�   6�   �� 5;   &   $��20, 50, 20, 20q�60   ���#DCE0E4 �� TextAlignment$ Justify=�6]   $����/summary/specify useful information for the calculation or a description of the power plant /param name = object.propertyStation/ /return inputData/ /summary/��5<   1   $��15(�5=   0   $
��Wrap=�6>   $��Fonts/#Raleway SemiBold)�6R   6z   5?   #   5@      5A      5B      �� 5C      -
   5        $��
FormBorder��5C      ���#373E46$	��Top=�6D   $	��700��6\   $��80��6l   $��80��6x   $	��500��6�   $��20 20 20 20q�6�   $
��Left=�6�   $ 25��6�   $��0��6�   $��3��6�   $��0��6�   $��4��6	  ._�5E      � $��20,20,20,20q�6   .+�5F      �� $
��Auto=�6+   $
��Auto=�6N   .��5G   "   �  5H   &   �� 5I   *   $
��Auto �5J   -   �� 5K   *   $
��Auto �5L   -    5N   &   �� 5O   *   $
��Auto �5P   )   �� 5Q   *   $
��Auto �5R   )   �� 5S   *   $
��Auto �5T   )   �� 5U   *   $
��Auto �5V   )   �� 5W   *   $
��Auto �5X   )   �� 5Y   *   $
��Auto �5Z   )   �� 5[   *   $
��Auto �5\   )   �� 5]   *   $
��Auto �5^   )   �� 5_   *   $
��Auto �5`   )   �� 5a   *   $
��Auto �5b   )   �� 5c   *   $
��Auto �5d   )   �� 5e   *   $
��Auto �5f   )   �� 5g   *   $
��Auto �5h   )   �� 5i   *   $
��Auto �5j   )   .+�5m   &   �� $��0��61   $��4��6A   $��0��6U   ���#DCE0E4$��22(�6w   $��Форма данных��6�   $ Center=�6�   $
��Wrap=�6�   $��Fonts/#Raleway SemiBold)�6�   �� 5n   &   $	��Top=�60   $��0��6H   $��2��6X   $��1��6l   $��0, 10, 0, 0q�6y   $��20��6�   $
��Left=�6�   $	��120��6�   ���#DCE0E4$
 Left=�6�   $��Тип мельницы:��6�   $��15(�5o   %   $
��Wrap=�63   $��Fonts/#Raleway SemiBold)�6G   6n   �� 5p   &   -   5        $
��Mill��5p   .   $��0, 10, 10, 0q�6:   $��3��6P   $��4��6`   $��1��6t   $��60��6�   $��20��6�   $	��120��6�    �� TextAlignment$
 Left=�6�   $��13(�6�   
�������$��Fonts/#Raleway SemiBold)�6�   6
  �� 5q   &   $	��Top=�60   $��0��6H   $��2��6X   $��0, 10, 0, 0q�6e   $��40��6z   $
��Left=�6�   $	��120��6�   ���#DCE0E4$
 Left=�6�   $(��"Тип шлакоудаления:��6�   $��15(�5r   %   $
��Wrap=�63   $��Fonts/#Raleway SemiBold)�6G   6n   �� 5s   &   -   5        $��comboBoxTypeSlagRemoval��5s   /   $��0, 10, 10, 0q�6N   $��1��6d   $��2��6t   $��20��6�   $	��120��6�   $��13(�6�   
�������$��Fonts/#Raleway SemiBold)�6�   ��6�   �� 6�   �� 5t   &   $	��Top=�60   $��0��6H   $��3��6X   $��0, 10, 0, 0q�6e   $��60��6z   $
��Left=�6�   $	��120��6�   ���#DCE0E4$
 Left=�6�   $?��9Температура уходящих газов, °С:��6�   $��15(�5u   %   $
��Wrap=�63   $��Fonts/#Raleway SemiBold)�6G   6n   �� 5v   &   -   5        $��ExhaustGasTemperature��5v   .   $��0, 10, 10, 0q�6K   $��1��6a   $��3��6q   $
 Left=�6~   $��20��6�   $	��120��6�   $��13(�6�   
�������$��Fonts/#Raleway SemiBold)�6�   6�   �� 5w   &   $	��Top=�60   $��0��6H   $��4��6X   $��0, 10, 0, 0q�6e   $��40��6z   $
��Left=�6�   $	��120��6�   ���#DCE0E4$
 Left=�6�   $)��#Расход топлива, т/ч:��6�   $��15(�5x   %   $
��Wrap=�63   $��Fonts/#Raleway SemiBold)�6G   6n   �� 5y   &   -   5        $��FuelConsumption��5y   .   $��0, 10, 10, 0q�6E   $��1��6[   $��4��6k   $
 Left=�6x   $��20��6�   $	��120��6�   $��13(�6�   
�������$��Fonts/#Raleway SemiBold)�6�   6�   �� 5z   &   $	��Top=�60   $��0��6H   $��5��6X   $��0, 10, 0, 0q�6e   $��60��6z   $
��Left=�6�   $	��120��6�   ���#DCE0E4$
 Left=�6�   $5��/Высота подъемной шахты, м:��6�   $��15(�5{   %   $
��Wrap=�63   $��Fonts/#Raleway SemiBold)�6G   6n   �� 5|   &   -   5        $��HeightLiftShift��5|   .   $��0, 10, 10, 0q�6E   $��1��6[   $��5��6k   $
 Left=�6x   $��20��6�   $	��120��6�   $��13(�6�   
�������$��Fonts/#Raleway SemiBold)�6�   6�   �� 5}   &   $	��Top=�60   $��0��6H   $��6��6X   $��0, 10, 0, 0q�6e   $��40��6z   $
��Left=�6�   $	��120��6�   ���#DCE0E4$
 Left=�6�   $.��(Количество дымососов:��6�   $��15(�5~   %   $
��Wrap=�63   $��Fonts/#Raleway SemiBold)�6G   6n   �� 5   &   -   5        $��comboBoxSmokePumps��5   /   $��0, 10, 10, 0q�6I   $��1��6_   $��6��6o   $��20��6|   $	��120��6�   $��13(�6�   
�������$��Fonts/#Raleway SemiBold)�6�   ��6�   �� 6�   �� 5�   &   $	��Top=�60   $��0��6H   $��7��6X   $��0, 10, 0, 0q�6e   $��40��6z   $
��Left=�6�   $	��120��6�   ���#DCE0E4$
 Left=�6�   $5��/Величина избытка воздуха:��6�   $��15(�5�   %   $
��Wrap=�63   $��Fonts/#Raleway SemiBold)�6G   6n   �� 5�   &   -   5        $��
AirSuction��5�   .   $��0, 10, 10, 0q�6A   $��1��6W   $��7��6g   $
 Left=�6t   $��20��6�   $	��120��6�   $��13(�6�   
�������$��Fonts/#Raleway SemiBold)�6�   6�   �� 5�   &   $	��Top=�60   $��0��6H   $��2��6X   $��8��6l   $��0, 10, 0, 0q�6y   $��40��6�   $��Center=�6�   $	��300��6�   ���#DCE0E4$
 Left=�6�   $:��4Схема бункерных перегородок��6�   $��15(�5�   %   $
��Wrap=�63   $��Fonts/#Raleway SemiBold)�6G   6n   &    FiltersApplication.Utilities.Btn  5�   &   &    FiltersApplication.Utilities.Btn	   Click$	 	SchemeOne��6/     SchemeBtnStyle#��[ 6A   $��0��6i   $��9��6y   
 d� 	IsChecked$

 TrueY�6�   $
��Left=�6�   $	��Top=�6�   $��10 10 10 10q�6�   .��5�   *   �� $��/Images/Schema_1.png��60   $��Center=�6O   $��Center=�6l   $��Uniform=�5�   -   5�   '     5�   &   $	 	SchemeTwo��6/   #��[ 6A   $��1��6i   $��9��6y   $��Right=�6�   $	��Top=�6�   $��10 10 10 10q�6�   .��5�   *   �� $��/Images/Schema_2.png��60   $��Center=�6O   $��Center=�6l   $��Uniform=�5�   &   5�   '     5�   &   $	 SchemeThree��6/   #��[ 6C   $��0��6k   $��10��6{   $
��Left=�6�   $	��Top=�6�   $��10 10 10 10q�6�   .��5�   *   �� $��/Images/Schema_3.png��60   $��Center=�6O   $��Center=�6l   $��Uniform=�5�   &   5�   '     5�   &   $	 
SchemeFour��6/   #��[ 6B   $��1��6j   $��10��6z   $��Right=�6�   $	��Top=�6�   $��10 10 10 10q�6�   .��5�   *   �� $��/Images/Schema_4.png��60   $��Center=�6O   $��Center=�6l   $��Uniform=�5�   &   5�   '   �� 5�   &   $	��Top=�60   $��0��6H   $��11��6X   $��0, 10, 0, 0q�6f   $��40��6{   $
��Left=�6�   $	��120��6�   ���#DCE0E4$
 Left=�6�   $*��$Количество решеток:��6�   $��15(�5�      $
��Wrap=�6   $��Fonts/#Raleway SemiBold)�6#   6J   �� 5�   &   -   5        $��comboBoxNumberGrids��5�   /   $��0, 10, 10, 0q�6J   $��1��6`   $	��11 ��6p   $��20��6   $	��120��6�   $��13(�6�   
�������$��Fonts/#Raleway SemiBold)�6�   ��6�   ��  �� SelectedItem 6�   �� *NumberGrids+ �� 
AsyncState$
 True�� �� IsAsync$
 True��6A  �� 5�   &   $	��Top=�60   $��0��6H   $��12��6X   $��0, 10, 0, 0q�6f   $��40��6{   $
��Left=�6�   $	��120��6�   ���#DCE0E4$
 Left=�6�   $%��Тип подвода газа:��6�   $��15(�5�      $
��Wrap=�6   $��Fonts/#Raleway SemiBold)�6#   6J   �� 5�   &   -   5        $��comboBoxTypeFlueGasSupply��5�   /   $��0, 10, 10, 0q�6P   $��1��6f   $��12��6v   $��20��6�   $	��120��6�   $��13(�6�   
�������$��Fonts/#Raleway SemiBold)�6�   ��6�   ��  6�   �� *NumberGrids+$
 True��$
 True��6F  �� 5�   &   -   5        $��	MenuClose��5�   -   $y�	Collapsed=�6>   $��2��6U   $��0��6e     CloseMenuButton#��[ 6�   �� 5�   &   -   5        $��MenuOpen��5�   -   $��0��6=   $��0��6M     HamburgerMenuButton#��[ 6q   (  "Telerik.Windows.Controls.RadButton  5�   &   -   5        $��Принять��5�   8   $��0��6J   $��2��6Z   $��13��6n      CornerRadius$ 10��5�   %   $	��170��5�      $��10, 10, 10, 0q�5�      $��Century Gothic)�6-   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      