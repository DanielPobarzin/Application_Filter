   M S B A M L   `   `   `  ����M  IFiltersApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:FiltersApplication.ViewModelFiltersApplication.ViewModel  5      #    FiltersApplication.View.Fuels   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9vm*clr-namespace:FiltersApplication.ViewModel     5      k gTelerik.Windows.Cloud.Controls, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7t	 pTelerik.Windows.Controls.Chart.Direct2D, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n
 jTelerik.Windows.Controls.Charting, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7v rTelerik.Windows.Controls.ConversationalUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r nTelerik.Windows.Controls.DataServices, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Diagrams, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7y uTelerik.Windows.Controls.Diagrams.Extensions, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7u qTelerik.Windows.Controls.Diagrams.Ribbon, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m iTelerik.Windows.Controls.Docking, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7y uTelerik.Windows.Controls.EntityFrameworkCore, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.Expressions, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.FileDialogs, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7z vTelerik.Windows.Controls.FixedDocumentViewers, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7| xTelerik.Windows.Controls.FixedDocumentViewersUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GanttView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.GridView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.ImageEditor, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Media, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.RichTextBox, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r  nTelerik.Windows.Controls.ScheduleView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q! mTelerik.Windows.Controls.Spreadsheet, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7s" oTelerik.Windows.Controls.SpreadsheetUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r# nTelerik.Windows.Controls.SyntaxEditor, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q$ mTelerik.Windows.Controls.VirtualGrid, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a% ]Telerik.Windows.Data, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k& gTelerik.Windows.Documents.Core, Version=2022.1.217.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q' mTelerik.Windows.PersistenceFramework, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l( hTelerik.Windows.Scheduling.Core, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7�telerik1http://schemas.telerik.com/2008/xaml/presentation#    	 
                        ! " # $ % & ' ( 6D      
Page_Style#��[  5
        � 	Resources  5      7  1Telerik.Windows.Controls.InvertedBooleanConverter  InvertedBooleanConverter   MultipleSelectionBoxTemplate �� ElementName �� Path �� StringFormat  CheckBoxItemTemplate ��Name.  (Telerik.Windows.Input.Touch.TouchManager"   ShouldSuspendMousePromotion �� RelativeSource �� AncestorType d� 	IsChecked  NormalItemTemplate��%4  &	       &	      &	 �     &	 �      5   
   6+   �� 5   
   .R�5      �� 
���   �$��Italic$�6�   ��6   �� $ radComboBox��$ SelectedItems.Count�$1 +Выбрано типов топлива: 0��6�   5      �� 5   
   .R�5      �� $ cb��6   $
 True��5      ��5      �� *	BrandFuel+��6.   ��  ��  telerik:RadComboBoxItem$ 
Foreground� 5      ��  ��  telerik:RadComboBoxItem$ 
IsSelected�5      5      �� 5   
   .R�5      �� ��6   �� *	BrandFuel+5      5      	 � DataContext	 5      *  $FiltersApplication.ViewModel.FuelsVM  5   
   .��5!      � 
������ .+�5"   
   �� ���#212529���#3A4149$��5q�6<   
 �� CornerRadius$
 8,8,0,8��6P   ._�5#      �� $
��Auto=�6   .��5$      � 
������  � RowDefinitions 5%      �� 5&      $
��Auto �6(   �� 5'      $
��Auto �6(   �� 5(      $��1* �6(   �� 5)      $
��Auto �6(    � ColumnDefinitions 5+      �� 5,      $��1* �6+   �� 5-      $
��0.6* �6+   .+�5/      �� $��0��6   $��0��6)   $��4��6:   $��2��6K   $��5,50,5,5q�6_   $��/Images/fuels_page.png��6q   $��UniformToFill=�6�   �� 50       �� Orientation$ 
Horizontal=�6!   $��Center=�51      $��0��52      $��0��6   $��2��6#   $��0,50,0,5q�53      $	��170��6   .+�54      (  "Telerik.Windows.Controls.RadButton  $*��$Cохранить изменения��6,      CornerRadius$ 10��55       $	��170��57      $��Century Gothic)�58      ��56      �� *SaveCommand+59      5:      *  $Telerik.Windows.Controls.RadGridView  5;      -   5        $��	fuelsGrid��5;   *   ;  5Telerik.Windows.Controls.GridView.GridViewDataControl   IsBusy$
 True��6;   8  2Telerik.Windows.Controls.GridView.BaseItemsControl   GroupRenderMode$
 Flat=�6I   ���#373E46$��1��5<   	   $��8,15,8,8q�5=   	   $
��Auto��5>      $	��Top=�5?         AutoGenerateColumns$ False��5@   	      RowIndicatorVisibility$ 	Collapsed=�5B   	      CanUserFreezeColumns$ False��5C   	      DataLoadMode$ Asynchronous=�6&      CanUserResizeColumns$ False��5D   	      NewRowPosition$ Bottom=�6&      ShowColumnHeaders$
 True��6>   $��Century Gothic)�6W      ShowSearchPanel$
 True��6s      ShowColumnSortIndexes$
 True��6�      ShowGroupPanel$ False��6�   $��2��6�   * % $Telerik.Windows.Controls.DataControl   ItemsSource 5A   	   �� *Fuels+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� 
AsyncState$
 True�� �� IsAsync$
 True��    Columns  5F      1	  +Telerik.Windows.Controls.GridViewDataColumn	  5H      6
  0Telerik.Windows.Controls.GridViewBoundColumnBase! 
  Header$! Топливо��69   " 
  DataMemberBinding" 5I      �� *	BrandFuel+$ PropertyChanged=�$ TwoWay=�$
 True��	  5J      $! Марка топлива��69   " 5K      �� *Type+$ PropertyChanged=�$ TwoWay=�$
 True��	  5L      $A! ;Низшая теплота сгорания Q, МДж/кг��69   " 5M      �� *LowerHeatCombustion+$ PropertyChanged=�$ TwoWay=�$
 True��	  5N      $	! S,%��69   " 5O      �� *SulfurContent+$ PropertyChanged=�$ TwoWay=�$
 True��	  5P      $
! А,%��69   " 5Q      �� *
AshContent+$ PropertyChanged=�$ TwoWay=�$
 True��	  5R      $	! W,%��69   " 5S      �� *
Humidity+$ PropertyChanged=�$ TwoWay=�$
 True��	  5T      $	! N,%��69   " 5U      �� *
NContent+$ PropertyChanged=�$ TwoWay=�$
 True��	  5V      $I! CТеоретический объем воздуха Vв, м³/кг��69   " 5W      �� *TheoreticalAirVolume+$ PropertyChanged=�$ TwoWay=�$
 True��	  5X      $C! =Теоретический объем газа Vг, м³/кг��69   " 5Y      �� *TheoreticalVolumeGas+$ PropertyChanged=�$ TwoWay=�$
 True��	  5Z      $X! RТеоретический объем водяных паров Vвпо, м³/кг��69   " 5[      �� *TheoreticalVolumeWaterVapor+$ PropertyChanged=�$ TwoWay=�$
 True��	  5\      $8! 2Медианный диаметр золы d50, м��69   " 5]      �� *MedianDiameterAsh+$ PropertyChanged=�$ TwoWay=�$
 True��	  5^      $Q! KНапряженность электрического поля E, кВ/м��69   " 5_      �� *ElectricFieldStrength+$ PropertyChanged=�$ TwoWay=�$
 True��	  5`      $A! ;Коэффициент обратной короны Кок��69   " 5a      �� *CoefficientReverseCrown+$ PropertyChanged=�$ TwoWay=�$
 True��	  5b      $\! VУдельное электрическое сопротивление золы, lg(p)��69   " 5c      �� *ElectricalResistanceAsh+$ PropertyChanged=�$ TwoWay=�$
 True��5f      �� 5g      $��2��6!   $��1��6.   $��	5,5,10,30q�6>   $��2��6Q   .+�5h      �� $��Конфигуратор��6$   $��Century Gothic)�68   $��60,0,0,0q�6T   
��� ���$
��Bold"�6z   $��14(�6�   �� 5j      $)��#Формат разделителя��6$   $��5,10,0,0q�6>   $��Century Gothic)�6P   
�������6l   �� 5k      -   5        # ��Name$,# &MultipleSelectionSeparatorStringFormat��5k   "   $	��0 2q�6R   
������ 
��� �����5l      �� $ radComboBox��$, &MultipleSelectionSeparatorStringFormat�$ �� ValidatesOnExceptions$
$ True��$ PropertyChanged=�.��6�   5m      �� 5o      $��0 10 0 0q�6%   {�67   �� $ radComboBox��$ 	IsEnabled�.+�5p        $��Выбрать все��60   $ 8,8,8,8��6F   2  ,Telerik.Windows.Controls.RadComboBoxCommands%   	SelectAll#��Z% 5q       ��5r       �� $ radComboBox����5s   "   *�5t   &   Century Gothic)�6A   5v        5w      $��Сбросить все��60   $	��0 8q�6G   $ 8,8,8,8��6T   &   UnselectAll#��Z& 5x       ��5y       �� $ radComboBox����5z   "   *�5{   &   Century Gothic)�6A   5}      �� 5~      $��
Опции��6(   $��Century Gothic)�65   $��	80,10,0,0q�6Q   
��� ���$
��Bold"�6x   $��14(�6�   �� 5      -   5        
��� ���$��0 10 0 0q�5   ;   $��Century Gothic)�6M   ' d� IsThreeState$' False��6i   $8��2Вывод количества элементов��6~   $ FalseY�6�   
�������{�5�      �� $ 
IsEditable��$ 	IsChecked�( �� 	Converter#( [ 6�   �� 5�      -   5        
��� ���$	��0 4q�5�   ;   $��Century Gothic)�6H   $' False��6d   $3��-Элементы с флагом выбора��6y   $ FalseY�6�   
�������6�   �� 5�      -   5        $ 
IsEditable��5�   j   
��� ���
�������$��Century Gothic)�6N   $��0 0 0 0q�6~   $' False��6�   $#��Текстовый поиск��6�   $ FalseY�6�   5�      5�      � 5�      -   5        ) �Name$
) root��5�   0   $��20,10,20,10q�6   $��2��6>   $��0��6K    5�      �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   .+�5�      � $��0��6    5�      �� 5�   "   �� 5�   "   .+�5�      �� $��0��6)   .+�5�   "   $  Telerik.Windows.Controls.Label  $��0 10 0 0q�60   $-��'Выбраны виды топлива:��6B   $��0q�6b   $��Century Gothic)�6n   
�������6�   �� 5�   "   ��6/   �� $ radComboBox��$ SelectedItems���5�   &   �� 5�   *   .R�5�   .   �� 
��� ���$��12(�6g   $��Century Gothic)�6u   ��68   �� *	BrandFuel+6u   5�   +   5�   #   5�      5�      *  $Telerik.Windows.Controls.RadComboBox  5�      -   5        *  Name$* radComboBox��5�   .   $��	0 10 0 10q�6C   $��1��6V   +   	EmptyText$>+ 8Выберите топливо для расчета...��6c   $��Century Gothic)�6�   ,   AllowMultipleSelection$
, True��5�      - �� SelectedValuePath$- 	BrandFuel��6Z   . w� TextPath$. 	BrandFuel��5�      #��[ 6>   ��5�   <   �� *Fuels+!/   MultipleSelectionSeparator/ 5�      �� $  MultipleSelectionSeparator��$
 Text�$ TwoWay=�0   
IsEditable0 5�      �� *	IsChecked+$ 
IsEditable��5�      +  %Telerik.Windows.Controls.RadDataPager  5�      -   5        1  Name$1 radDataPager��5�   +   $��Century Gothic)�6A   $��3��5�   
   $��12(�6   2   DisplayMode$	2 All=�5�   
   3   PageSize$3 10��5�      $
{�True��5�      4   IsTotalItemCountFixed$
4 True��5�   
   $��0��6'   $��2��68   5   Source5 5�   
   �� $ 	fuelsGrid��$ Items�5�   8   5�      5�      5�      5�      5�      