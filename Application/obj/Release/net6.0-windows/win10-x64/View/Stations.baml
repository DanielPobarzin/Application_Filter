   M S B A M L   `   `   `  ���� M  IFiltersApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:FiltersApplication.ViewModelFiltersApplication.ViewModel  K*clr-namespace:FiltersApplication.UtilitiesFiltersApplication.Utilities  &     FiltersApplication.View.Stations   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9vm*clr-namespace:FiltersApplication.ViewModel     ;Menu*clr-namespace:FiltersApplication.Utilities     k gTelerik.Windows.Cloud.Controls, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7t	 pTelerik.Windows.Controls.Chart.Direct2D, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n
 jTelerik.Windows.Controls.Charting, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7v rTelerik.Windows.Controls.ConversationalUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r nTelerik.Windows.Controls.DataServices, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Diagrams, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7y uTelerik.Windows.Controls.Diagrams.Extensions, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7u qTelerik.Windows.Controls.Diagrams.Ribbon, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m iTelerik.Windows.Controls.Docking, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7y uTelerik.Windows.Controls.EntityFrameworkCore, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.Expressions, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.FileDialogs, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7z vTelerik.Windows.Controls.FixedDocumentViewers, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7| xTelerik.Windows.Controls.FixedDocumentViewersUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GanttView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.GridView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.ImageEditor, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Media, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.RichTextBox, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r  nTelerik.Windows.Controls.ScheduleView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q! mTelerik.Windows.Controls.Spreadsheet, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7s" oTelerik.Windows.Controls.SpreadsheetUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r# nTelerik.Windows.Controls.SyntaxEditor, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q$ mTelerik.Windows.Controls.VirtualGrid, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a% ]Telerik.Windows.Data, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k& gTelerik.Windows.Documents.Core, Version=2022.1.217.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q' mTelerik.Windows.PersistenceFramework, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l( hTelerik.Windows.Scheduling.Core, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7�telerik1http://schemas.telerik.com/2008/xaml/presentation#    	 
                        ! " # $ % & ' (    
Page_Style#��[    � DataContext  ,  &FiltersApplication.ViewModel.StationVM  .��� -    �Name$ StationGrid��
������ .+��� ���#212529���#3A4149$��5q� �� CornerRadius$ 8,8,0,8��._��� $
��Auto=�.���  � ColumnDefinitions �� -    ��Name$ c0��$��1* ��� -   $ c1��$��1* ��� -   $ c2��$��1* ��� -   $ c3��$��1* � � RowDefinitions �� -    ��Name$ CG_R1��$��1* ��� -   $ CG_R2��$��1* ��� -   $ CG_R5��$��1* ��� -	   $ CG_R6��$
��Auto �.+��� 
������ $��0 20 0 0q�$��0��$��4��$��0��$��2��._��� $��/Images/station_page.png��$��UniformToFill=��� ���#373E46$	��300��$	��Top=�$��
20 0 20 20q�$ 25��$��0��$��2��$��2��$��3��._�� $��10,10,10,10q�.+��� $
��Auto=�.��� .+��� $��20, 10, 20, 210q����#DCE0E4$��22(�$��К сведению��$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��20, 50, 20, 20q����#DCE0E4 �� TextAlignment$ Justify=�$����/summary/specify useful information for the calculation or a description of the power plant /param name = object.propertyStation/ /return inputData/ /summary/��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� -
   $��
FormBorder�����#373E46$	��Top=�$	��700��$��80��$��80��$	��500��$��20 20 20 20q�$
��Left=�$ 25��$��0��$��3��$��0��$��4��._�� $��20,20,20,20q�.+��� $
��Auto=�$
��Auto=�.���  �� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��4��$��0�����#DCE0E4$��22(�$��Форма данных��$ Center=�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $	��Top=�$��0��$��2��$��1��$��0, 10, 0, 0q�$��20��$
��Left=�$	��120�����#DCE0E4$
 Left=�$��Тип мельницы:��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� -   $
��Mill��$��0, 10, 10, 0q�$��3��$��4��$��1��$��60��$��20��$	��120�� �� TextAlignment$
 Left=�$��13(�
�������$��Fonts/#Raleway SemiBold)��� $	��Top=�$��0��$��2��$��0, 10, 0, 0q�$��40��$
��Left=�$	��120�����#DCE0E4$
 Left=�$(��"Тип шлакоудаления:��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� -   $��comboBoxTypeSlagRemoval��$��0, 10, 10, 0q�$��1��$��2��$��20��$	��120��$��13(�
�������$��Fonts/#Raleway SemiBold)����� �� $	��Top=�$��0��$��3��$��0, 10, 0, 0q�$��60��$
��Left=�$	��120�����#DCE0E4$
 Left=�$?��9Температура уходящих газов, °С:��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� -   $��ExhaustGasTemperature��$��0, 10, 10, 0q�$��1��$��3��$
 Left=�$��20��$	��120��$��13(�
�������$��Fonts/#Raleway SemiBold)��� $	��Top=�$��0��$��4��$��0, 10, 0, 0q�$��40��$
��Left=�$	��120�����#DCE0E4$
 Left=�$)��#Расход топлива, т/ч:��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� -   $��FuelConsumption��$��0, 10, 10, 0q�$��1��$��4��$
 Left=�$��20��$	��120��$��13(�
�������$��Fonts/#Raleway SemiBold)��� $	��Top=�$��0��$��5��$��0, 10, 0, 0q�$��60��$
��Left=�$	��120�����#DCE0E4$
 Left=�$5��/Высота подъемной шахты, м:��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� -   $��HeightLiftShift��$��0, 10, 10, 0q�$��1��$��5��$
 Left=�$��20��$	��120��$��13(�
�������$��Fonts/#Raleway SemiBold)��� $	��Top=�$��0��$��6��$��0, 10, 0, 0q�$��40��$
��Left=�$	��120�����#DCE0E4$
 Left=�$.��(Количество дымососов:��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� -   $��comboBoxSmokePumps��$��0, 10, 10, 0q�$��1��$��6��$��20��$	��120��$��13(�
�������$��Fonts/#Raleway SemiBold)����� �� $	��Top=�$��0��$��7��$��0, 10, 0, 0q�$��40��$
��Left=�$	��120�����#DCE0E4$
 Left=�$5��/Величина избытка воздуха:��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� -   $��
AirSuction��$��0, 10, 10, 0q�$��1��$��7��$
 Left=�$��20��$	��120��$��13(�
�������$��Fonts/#Raleway SemiBold)��� $	��Top=�$��0��$��2��$��8��$��0, 10, 0, 0q�$��40��$��Center=�$	��300�����#DCE0E4$
 Left=�$:��4Схема бункерных перегородок��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)�&    FiltersApplication.Utilities.Btn  &    FiltersApplication.Utilities.Btn	   Click$	 	SchemeOne��  SchemeBtnStyle#��[ $��0��$��9��
 d� 	IsChecked$

 TrueY�$
��Left=�$	��Top=�$��10 10 10 10q�.���� $��/Images/Schema_1.png��$��Center=�$��Center=�$��Uniform=�  $	 	SchemeTwo��#��[ $��1��$��9��$��Right=�$	��Top=�$��10 10 10 10q�.���� $��/Images/Schema_2.png��$��Center=�$��Center=�$��Uniform=�  $	 SchemeThree��#��[ $��0��$��10��$
��Left=�$	��Top=�$��10 10 10 10q�.���� $��/Images/Schema_3.png��$��Center=�$��Center=�$��Uniform=�  $	 
SchemeFour��#��[ $��1��$��10��$��Right=�$	��Top=�$��10 10 10 10q�.���� $��/Images/Schema_4.png��$��Center=�$��Center=�$��Uniform=��� $	��Top=�$��0��$��11��$��0, 10, 0, 0q�$��40��$
��Left=�$	��120�����#DCE0E4$
 Left=�$*��$Количество решеток:��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� -   $��comboBoxNumberGrids��$��0, 10, 10, 0q�$��1��$	��11 ��$��20��$	��120��$��13(�
�������$��Fonts/#Raleway SemiBold)�����  �� SelectedItem �� *NumberGrids+ �� 
AsyncState$
 True�� �� IsAsync$
 True���� $	��Top=�$��0��$��12��$��0, 10, 0, 0q�$��40��$
��Left=�$	��120�����#DCE0E4$
 Left=�$%��Тип подвода газа:��$��15(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� -   $��comboBoxTypeFlueGasSupply��$��0, 10, 10, 0q�$��1��$��12��$��20��$	��120��$��13(�
�������$��Fonts/#Raleway SemiBold)�����  �� *NumberGrids+$
 True��$
 True���� -   $��	MenuClose��$y�	Collapsed=�$��2��$��0��  CloseMenuButton#��[ �� -   $��MenuOpen��$��0��$��0��  HamburgerMenuButton#��[ (  "Telerik.Windows.Controls.RadButton  -   $��Принять��$��0��$��2��$��13��   CornerRadius$ 10��$	��170��$��10, 10, 10, 0q�$��Century Gothic)�