   M S B A M L   `   `   `  ���� M  IFiltersApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:FiltersApplication.ViewModelFiltersApplication.ViewModel  %    FiltersApplication.View.Filters   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     k gTelerik.Windows.Cloud.Controls, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7t	 pTelerik.Windows.Controls.Chart.Direct2D, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n
 jTelerik.Windows.Controls.Charting, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7v rTelerik.Windows.Controls.ConversationalUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r nTelerik.Windows.Controls.DataServices, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Diagrams, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7y uTelerik.Windows.Controls.Diagrams.Extensions, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7u qTelerik.Windows.Controls.Diagrams.Ribbon, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m iTelerik.Windows.Controls.Docking, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7y uTelerik.Windows.Controls.EntityFrameworkCore, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.Expressions, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.FileDialogs, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7z vTelerik.Windows.Controls.FixedDocumentViewers, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7| xTelerik.Windows.Controls.FixedDocumentViewersUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GanttView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.GridView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.ImageEditor, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Media, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.RichTextBox, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r  nTelerik.Windows.Controls.ScheduleView, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q! mTelerik.Windows.Controls.Spreadsheet, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7s" oTelerik.Windows.Controls.SpreadsheetUI, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r# nTelerik.Windows.Controls.SyntaxEditor, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q$ mTelerik.Windows.Controls.VirtualGrid, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a% ]Telerik.Windows.Data, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k& gTelerik.Windows.Documents.Core, Version=2022.1.217.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q' mTelerik.Windows.PersistenceFramework, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l( hTelerik.Windows.Scheduling.Core, Version=2022.1.222.60, Culture=neutral, PublicKeyToken=5803cfa389c90ce7�telerik1http://schemas.telerik.com/2008/xaml/presentation#    	 
                        ! " # $ % & ' ( wvm*clr-namespace:FiltersApplication.ViewModel#    	 
                        ! " # $ % & ' (    
Page_Style#��[    � 	Resources  ,  &FiltersApplication.ViewModel.FiltersVM  	FiltersVM  CheckBoxItemTemplate ��Name.  (Telerik.Windows.Input.Touch.TouchManager"   ShouldSuspendMousePromotion �� RelativeSource �� AncestorType �� Path d� 	IsChecked��%�   &	       &	        �� .R��� $ cb��$
 True������ *BrandFilter+����  ��  telerik:RadComboBoxItem$ 
Foreground� ��  ��  telerik:RadComboBoxItem$ 
IsSelected�.���  � DataContext# [ 
������ .+��� ���#212529���#3A4149$��5q� �� CornerRadius$ 8,8,0,8��._��� $
��Auto=�.��� 
������ 	 � RowDefinitions	 �� $
��Auto ��� $
��Auto ��� $��1* ��� $
��Auto �
 � ColumnDefinitions
 �� $��1* ��� $
��0.8* �.+��� $��0��$��3��$��0��$��2��$��0 0 0 50q�$��Bottom=�$	��800��$	��950��$��/Images/filters_page.png��$��Uniform=���  �� Orientation$ 
Horizontal=� %� IsVirtualizing$
 True�� %� VirtualizationMode$ Standard=�$��Center=�$��0��$��0��$��2��$��0, 50, 0, 5q�.+�(  "Telerik.Windows.Controls.RadButton  $*��$Cохранить изменения��   CornerRadius$ 10��$	��170��$��10, 0, 10, 0q�$��Century Gothic)����� *SaveCommand+*  $Telerik.Windows.Controls.RadGridView  -   $��filtersGrid��;  5Telerik.Windows.Controls.GridView.GridViewDataControl   IsBusy$
 True��8  2Telerik.Windows.Controls.GridView.BaseItemsControl   GroupRenderMode$
 Flat=����#373E46$
 True��! %� IsVirtualizingWhenGrouping$
 True��$ Standard=�$��1��$��0��$��2��$��0, 15, 0, 50q�$
��Auto��$	��Top=�   AutoGenerateColumns$ False��   RowIndicatorVisibility$ 	Collapsed=�   CanUserFreezeColumns$ False��   DataLoadMode$ Asynchronous=�   CanUserResizeColumns$ False��   NewRowPosition$ Bottom=�   ShowColumnHeaders$
 True��$��Century Gothic)�   ShowSearchPanel$
 True��   ShowGroupPanel$
 True��&   IsLocalizationLanguageRespected$
 True��* % $Telerik.Windows.Controls.DataControl   ItemsSource �� *	Filters+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� 
AsyncState$
 True��  �� IsAsync$
  True��!   Columns! 1  +Telerik.Windows.Controls.GridViewDataColumn  6	  0Telerik.Windows.Controls.GridViewBoundColumnBase" 	  Header$!" Модель фильтра��# 	  DataMemberBinding# �� *BrandFilter+$ PropertyChanged=�$ TwoWay=�$
  True��  $?" 9Площадь активного сечения ω, м²��# �� *AreaActiveSection+$ PropertyChanged=�$ TwoWay=�$
  True��  $3" -Активная длина поля Lₚ, м��# �� *ActiveFieldLength+$ PropertyChanged=�$ TwoWay=�$
  True��  $;" 5Общая площадь осаждения А, м²��# �� *TotalDepositionArea+$ PropertyChanged=�$ TwoWay=�$
  True��  $" Масса, т��# �� *Weight+$ PropertyChanged=�$ TwoWay=�$
  True��  $" Длина, м��# �� *Length+$ PropertyChanged=�$ TwoWay=�$
  True��  $/" )Ширина (по осям опор), м��# �� *Width+$ PropertyChanged=�$ TwoWay=�$
  True��  $" Высота, м��# �� *Height+$ PropertyChanged=�$ TwoWay=�$
  True��  $)" #Высота электрода, м��# �� *ElectrodeHeight+$ PropertyChanged=�$ TwoWay=�$
  True��  $?" 9Коэфф. режима встряхивания, Квс��# �� *СoefficientShakingMode+$ PropertyChanged=�$ TwoWay=�$
  True��  $%" Количество полей��# �� *NumberFields+$ PropertyChanged=�$ TwoWay=�$
  True��  $u" oРасстояние между коронирующем и осадительным электродом t, м��# �� *DistanceCPDevices+$ PropertyChanged=�$ TwoWay=�$
  True���� $��2��$��1��$��	5,5,10,30q�$��2��.+��� ���#373E46$��10q�$	��450��$ 25��._�� $��
10,10,2,10q�.+��� $
��Auto=�.��� .+��� $��20, 10, 20, 210q����#DCE0E4$!��К ознакомлению��$��20(�$
��Wrap=�$��Fonts/#Raleway SemiBold)��� $��20, 50, 20, 20q����#DCE0E4$ �� TextAlignment$$ Justify=�$�	���	    В настоящее время основными типами золоуловителей, применяемых на угольных ТЭС, являются сухие золоуловители, главным образом электрофильтры. Наряду с этим на вновь вводимых зарубежных энергоблоках возрастает доля рукавных фильтров (более 100 энергоблоков в США). Поскольку только сухие золоуловители позволяют широко использовать в качестве вторичного продукта уловленную летучую золу без загрязнения грунтовых вод и почвы, применение сухих золоуловителей предпочтительно при техперевооружении действующих ТЭС, оснащенных мокрыми золоуловителями. В некоторых странах применение мокрых технологий для улавливания твердых частиц вообще запрещено.��$��16(�$
��Wrap=�$��Fonts/#Raleway SemiBold)�� -   % �Name$
% root��$��20,10,20,10q�$��2��$��0��	 �� $
��Auto ��� $
��Auto �.+�� $��0��
 �� �� .+��� $��0��.+�$
  Telerik.Windows.Controls.Label
  $��0 10 0 0q�$"��Выбрана модель:��$��0q�$��Century Gothic)�
��������� ���� & �� ElementName$& radComboBox��$ SelectedItems����� .R��� 
��� ���$��12(�$��Century Gothic)����� *BrandFilter+*  $Telerik.Windows.Controls.RadComboBox  -   '  Name$' radComboBox��$��	0 10 0 10q�$��1��(   	EmptyText$K( EВыберите модель фильтра для расчета...��$��Century Gothic)�)   AllowMultipleSelection$) False��* �� SelectedValuePath$* BrandFilter��+ w� TextPath$+ BrandFilter��#��[ ���� *	Filters+, �� SelectedItem, �� *SelectedFilter+-   
IsEditable- �� *	IsChecked+$& 
IsEditable��+  %Telerik.Windows.Controls.RadDataPager  -   .  Name$. radDataPager��$��Century Gothic)�$��3��$��12(�$��0��$��2��/   DisplayMode$	/ All=�0   PageSize$0 10��$
{�True��1   IsTotalItemCountFixed$
1 True��2   Source2 �� $& filtersGrid��$ Items�