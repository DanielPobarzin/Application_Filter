   M S B A M L   `   `   `  ���� M  IFiltersApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:FiltersApplication.ViewModelFiltersApplication.ViewModel  #    FiltersApplication.View.Fuels   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9vm*clr-namespace:FiltersApplication.ViewModel     k gTelerik.Windows.Cloud.Controls, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7t	 pTelerik.Windows.Controls.Chart.Direct2D, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n
 jTelerik.Windows.Controls.Charting, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7v rTelerik.Windows.Controls.ConversationalUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r nTelerik.Windows.Controls.DataServices, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Diagrams, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7y uTelerik.Windows.Controls.Diagrams.Extensions, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7u qTelerik.Windows.Controls.Diagrams.Ribbon, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m iTelerik.Windows.Controls.Docking, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7y uTelerik.Windows.Controls.EntityFrameworkCore, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.Expressions, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.FileDialogs, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7z vTelerik.Windows.Controls.FixedDocumentViewers, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7| xTelerik.Windows.Controls.FixedDocumentViewersUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GanttView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.GridView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.ImageEditor, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Media, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.RichTextBox, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r  nTelerik.Windows.Controls.ScheduleView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q! mTelerik.Windows.Controls.Spreadsheet, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7s" oTelerik.Windows.Controls.SpreadsheetUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r# nTelerik.Windows.Controls.SyntaxEditor, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q$ mTelerik.Windows.Controls.VirtualGrid, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a% ]Telerik.Windows.Data, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k& gTelerik.Windows.Documents.Core, Version=2022.1.217.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q' mTelerik.Windows.PersistenceFramework, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l( hTelerik.Windows.Scheduling.Core, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7�telerik1http://schemas.telerik.com/2008/xaml/presentation#    	 
                        ! " # $ % & ' (    
Page_Style#��[    � 	Resources  7  1Telerik.Windows.Controls.InvertedBooleanConverter  InvertedBooleanConverter   MultipleSelectionBoxTemplate �� ElementName �� Path �� StringFormat  CheckBoxItemTemplate ��Name.  (Telerik.Windows.Input.Touch.TouchManager"   ShouldSuspendMousePromotion �� RelativeSource �� AncestorType d� 	IsChecked  NormalItemTemplate��%�  &	       &	      &	 �     &	 G      �� .R��� 
���   �$��Italic$����� $ radComboBox��$ SelectedItems.Count�$1 +Выбрано типов топлива: 0���� .R��� $ cb��$
 True������ *	BrandFuel+����  ��  telerik:RadComboBoxItem$ 
Foreground� ��  ��  telerik:RadComboBoxItem$ 
IsSelected��� .R��� ���� *	BrandFuel+	 � DataContext	 *  $FiltersApplication.ViewModel.FuelsVM  .��� 
������ .+��� ���#212529���#3A4149$��5q�
 �� CornerRadius$
 8,8,0,8��._��� $
��Auto=�.��� 
������  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��1* ��� $
��Auto � � ColumnDefinitions �� $��1* ��� $
��0.6* �.+��� $��0��$��0��$��4��$��2��$��5,50,5,5q�$��/Images/fuels_page.png��$��UniformToFill=���  �� Orientation$ 
Horizontal=�$��Center=�$��0��$��0��$��2��$��0,50,0,5q�$	��170��.+�(  "Telerik.Windows.Controls.RadButton  $*��$Cохранить изменения��   CornerRadius$ 10��$	��170��$��Century Gothic)����� *SaveCommand+*  $Telerik.Windows.Controls.RadGridView  -   $��	fuelsGrid��;  5Telerik.Windows.Controls.GridView.GridViewDataControl   IsBusy$
 True��8  2Telerik.Windows.Controls.GridView.BaseItemsControl   GroupRenderMode$
 Flat=����#373E46$��1��$��8,15,8,8q�$
��Auto��$	��Top=�   AutoGenerateColumns$ False��   RowIndicatorVisibility$ 	Collapsed=�   CanUserFreezeColumns$ False��   DataLoadMode$ Asynchronous=�   CanUserResizeColumns$ False��   NewRowPosition$ Bottom=�   ShowColumnHeaders$
 True��$��Century Gothic)�   ShowSearchPanel$
 True��   ShowColumnSortIndexes$
 True��   ShowGroupPanel$ False��$��2��* % $Telerik.Windows.Controls.DataControl   ItemsSource �� *Fuels+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� 
AsyncState$
 True�� �� IsAsync$
 True��    Columns  1	  +Telerik.Windows.Controls.GridViewDataColumn	  6
  0Telerik.Windows.Controls.GridViewBoundColumnBase! 
  Header$! Топливо��" 
  DataMemberBinding" �� *	BrandFuel+$ PropertyChanged=�$ TwoWay=�$
 True��	  $! Марка топлива��" �� *Type+$ PropertyChanged=�$ TwoWay=�$
 True��	  $A! ;Низшая теплота сгорания Q, МДж/кг��" �� *LowerHeatCombustion+$ PropertyChanged=�$ TwoWay=�$
 True��	  $	! S,%��" �� *SulfurContent+$ PropertyChanged=�$ TwoWay=�$
 True��	  $
! А,%��" �� *
AshContent+$ PropertyChanged=�$ TwoWay=�$
 True��	  $	! W,%��" �� *
Humidity+$ PropertyChanged=�$ TwoWay=�$
 True��	  $	! N,%��" �� *
NContent+$ PropertyChanged=�$ TwoWay=�$
 True��	  $I! CТеоретический объем воздуха Vв, м³/кг��" �� *TheoreticalAirVolume+$ PropertyChanged=�$ TwoWay=�$
 True��	  $C! =Теоретический объем газа Vг, м³/кг��" �� *TheoreticalVolumeGas+$ PropertyChanged=�$ TwoWay=�$
 True��	  $X! RТеоретический объем водяных паров Vвпо, м³/кг��" �� *TheoreticalVolumeWaterVapor+$ PropertyChanged=�$ TwoWay=�$
 True��	  $8! 2Медианный диаметр золы d50, м��" �� *MedianDiameterAsh+$ PropertyChanged=�$ TwoWay=�$
 True��	  $Q! KНапряженность электрического поля E, кВ/м��" �� *ElectricFieldStrength+$ PropertyChanged=�$ TwoWay=�$
 True��	  $A! ;Коэффициент обратной короны Кок��" �� *CoefficientReverseCrown+$ PropertyChanged=�$ TwoWay=�$
 True��	  $\! VУдельное электрическое сопротивление золы, lg(p)��" �� *ElectricalResistanceAsh+$ PropertyChanged=�$ TwoWay=�$
 True���� $��2��$��1��$��	5,5,10,30q�$��2��.+��� $��Конфигуратор��$��Century Gothic)�$��60,0,0,0q�
��� ���$
��Bold"�$��14(��� $)��#Формат разделителя��$��5,10,0,0q�$��Century Gothic)�
��������� -   # ��Name$,# &MultipleSelectionSeparatorStringFormat��$	��0 2q�
������ 
��� ������� $ radComboBox��$, &MultipleSelectionSeparatorStringFormat�$ �� ValidatesOnExceptions$
$ True��$ PropertyChanged=�.���� $��0 10 0 0q�{��� $ radComboBox��$ 	IsEnabled�.+�  $��Выбрать все��$ 8,8,8,8��2  ,Telerik.Windows.Controls.RadComboBoxCommands%   	SelectAll#��Z% ���� $ radComboBox����*�Century Gothic)�  $��Сбросить все��$	��0 8q�$ 8,8,8,8��&   UnselectAll#��Z& ���� $ radComboBox����*�Century Gothic)��� $��
Опции��$��Century Gothic)�$��	80,10,0,0q�
��� ���$
��Bold"�$��14(��� -   
��� ���$��0 10 0 0q�$��Century Gothic)�' d� IsThreeState$' False��$8��2Вывод количества элементов��$ FalseY�
�������{��� $ 
IsEditable��$ 	IsChecked�( �� 	Converter#( [ �� -   
��� ���$	��0 4q�$��Century Gothic)�$' False��$3��-Элементы с флагом выбора��$ FalseY�
��������� -   $ 
IsEditable��
��� ���
�������$��Century Gothic)�$��0 0 0 0q�$' False��$#��Текстовый поиск��$ FalseY�� -   ) �Name$
) root��$��20,10,20,10q�$��2��$��0�� �� $
��Auto ��� $
��Auto �.+�� $��0�� �� �� .+��� $��0��.+�$  Telerik.Windows.Controls.Label  $��0 10 0 0q�$-��'Выбраны виды топлива:��$��0q�$��Century Gothic)�
��������� ���� $ radComboBox��$ SelectedItems����� .R��� 
��� ���$��12(�$��Century Gothic)����� *	BrandFuel+*  $Telerik.Windows.Controls.RadComboBox  -   *  Name$* radComboBox��$��	0 10 0 10q�$��1��+   	EmptyText$>+ 8Выберите топливо для расчета...��$��Century Gothic)�,   AllowMultipleSelection$
, True��- �� SelectedValuePath$- 	BrandFuel��. w� TextPath$. 	BrandFuel��#��[ ���� *Fuels+!/   MultipleSelectionSeparator/ �� $  MultipleSelectionSeparator��$
 Text�$ TwoWay=�0 �� SelectedItem0 �� *SelectedFuels+1   
IsEditable1 �� *	IsChecked+$ 
IsEditable��+  %Telerik.Windows.Controls.RadDataPager  -   2  Name$2 radDataPager��$��Century Gothic)�$��3��$��12(�3   DisplayMode$	3 All=�4   PageSize$4 10��$
{�True��5   IsTotalItemCountFixed$
5 True��$��0��$��2��6   Source6 �� $ 	fuelsGrid��$ Items�