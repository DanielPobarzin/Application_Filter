   M S B A M L   `   `   `  ���� M  IFiltersApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:FiltersApplication.ViewModelFiltersApplication.ViewModel  A%clr-namespace:FiltersApplication.ViewFiltersApplication.View  K*clr-namespace:FiltersApplication.UtilitiesFiltersApplication.Utilities  W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� DataType)   #FiltersApplication.ViewModel.HomeVM"   FiltersApplication.View.Home,  &FiltersApplication.ViewModel.FiltersVM%   FiltersApplication.View.Filters*  $FiltersApplication.ViewModel.FuelsVM#   FiltersApplication.View.Fuels,  &FiltersApplication.ViewModel.StationVM&    FiltersApplication.View.Stations.  (FiltersApplication.ViewModel.CalculateVM'	   !FiltersApplication.View.Calculate+
   %FiltersApplication.ViewModel.ChartsVM$   FiltersApplication.View.Charts   Home_Desktop_Layout �Name �� CornerRadius � ColumnDefinitions ��Name � RowDefinitions ��Name  Card_5_Desktop  Card_7_Desktop  Home_Laptop_Layout 
 Card_5  Card_7_Horizontal   Home_Tablet_Landscape_Layout  Home_Tablet_Portrait_Layout   Home_Mobile_Landscape_Layout 	 Home_Mobile_Portrait_Layout 
 Card_5_Mobile  Card_7_Vertical_Mobile�� F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     1vm*clr-namespace:FiltersApplication.ViewModel  .view%clr-namespace:FiltersApplication.View  3Menu*clr-namespace:FiltersApplication.Utilities  %%  (��       *,  +)(��      *, +)(�� $     *, +)(�� 6     *, +)(�� H     *, +)(�� Z     *,
 +)&	  l     7  7  &	 �    7  7  &	 �    7  7  &	 �    7  7  &	 �    7  7  &		 �    7 
 7  �� "    .R�  �� "   .R�  �� "   .R�  �� "   .R�  �� "   .R�	  �� "  
 .R�  �� .R�� $ BaseGrid��
������ $��8q�.+��� $��30��$	��230�����#373E46$��Center=�$	��Top=�$��5,0,5,0q����	#FF0BCDFF$ 5��._�� .+��� $��C B F : App P R O��$��Fonts/#Saira Regular)�$��18(�$��Center=�$��Center=����#DCE0E4�� $
��Auto=�.��� $ 	Card_Grid��
������ $	��Top=�$��	10,0,10,0q� �� $ c0��$��1* ��� $ c1��$��1* ��� $ c2��$��1* ��� $ c3��$��1* � �� $ CG_R1��$��50 ��� $ CG_R2��$
��0.3* ��� $ CG_R3��$
��0.3* ��� $ CG_R4��$
��0.4* �.+��� $��2��$��0��$��4��8��  �� $��3��$��0��$��4��8�� �� .R�� $ BaseGrid��
������ $��5q�.+�� $	��Top=�$
��Left=�$��	20,20,0,0q�.+��� $��30��$	��250�����#373E46$��Center=�$	��Top=�$��5,0,5,0q����	#FF0BCDFF$ 5��._�� .+��� $��C B F : App P R O��$��Fonts/#Saira Regular)�$��18(�$��Center=�$��Center=����#DCE0E4�� $
��Auto=�.��� $ 	Card_Grid��
������ $	��800��$	��Top=�$��10,0,0,0q� �� $ c0��$��1* ��� $ c1��$��1* ��� $ c2��$��1* ��� $ c3��$��1* ��� $ c4��$
��1.3* �$��0�� �� $ CG_R1��$��0* ��� $ CG_R2��$
��0.1* ��� $ CG_R3��$
��0.4* ��� $ CG_R4��$
��0.4* �.+��� $��2��$��0��$��4��8��  �� $��3��$��0��$��4��8�� �� .R�� $ BaseGrid��
������ $��8q�.+�� $	��Top=�$��Center=�$��0,20,0,0q�.+��� $��30��$	��230�����#373E46$��Center=�$	��Top=�$��5,0,5,0q����	#FF0BCDFF$ 5��._�� .+��� $��C B F : App P R O��$��Fonts/#Saira Regular)�$��18(�$��Center=�$��Center=����#DCE0E4�� $
��Auto=�.��� $ 	Card_Grid��
������ $	��700��$	��Top=�$��	10,0,10,0q� �� $ c0��$��1* ��� $ c1��$��1* ��� $ c2��$��1* ��� $ c3��$��1* ��� $ c4��$
��1.3* �$	��260�� �� $ CG_R1��$��0.20* ��� $ CG_R2��$��0* ��� $ CG_R3��$��0.70* ��� $ CG_R4��$��0.50* ��� $ CG_R5��$��0* ��� $ CG_R6��$��0.02* �.+��� $��2��$��0��$��5��8��  �� $��3��$��0��$��5��8�� �� .R�� $ BaseGrid��
������ $��8q�.+�� $��30��$	��230��$	��Top=�$��Center=�$��0,20,0,0q�.+��� $��30��$	��230�����#373E46$��Center=�$	��Top=�$��5,0,5,0q����	#FF0BCDFF$ 5��._�� .+��� $��C B F : App P R O��$��Fonts/#Saira Regular)�$��18(�$��Center=�$��Center=����#DCE0E4�� $��1��$��1��$
��Auto=�.��� $ 	Card_Grid��
������ $	��900��$	��Top=�$��	10,0,10,0q� �� $ c0��$��1* ��� $ c1��$��1* ��� $ c2��$��1* ��� $ c3��$��1* � �� $ CG_R1��$
��0.0* ��� $ CG_R2��$��0.04* ��� $ CG_R3��$
��0.2* ��� $ CG_R4��$
��0.2* ��� $ CG_R5��$
��0.1* �.+��� $��2��$��0��$��4��8��  �� $��3��$��0��$��4��8�� �� .R�� $ BaseGrid��
������ $��8q�.+�� $��30��$	��230��$	��Top=�$��Center=�$��0,20,0,0q�.+��� $��30��$	��230�����#373E46$��Center=�$	��Top=�$��5,0,5,0q����	#FF0BCDFF$ 5��._�� .+��� $��C B F : App P R O��$��Fonts/#Saira Regular)�$��18(�$��Center=�$��Center=����#DCE0E4�� $��1��$��1��$
��Auto=�.��� $ 	Card_Grid��
������ $
��1180��$	��Top=�$��	10,0,10,0q� �� $ c0��$��1* ��� $ c1��$��1* ��� $ c2��$��1* ��� $ c3��$��1* � �� $ CG_R1��$��0.05* ��� $ CG_R2��$
��0.3* ��� $ CG_R3��$��0.15* ��� $ CG_R4��$
��0.5* ��� $ CG_R5��$��0* �.+��� $��1��$��0��$��4��8��  �� $��2��$��0��$��4��8�� �� .R�� $ BaseGrid��
������ $��8q�.+�� $��30��$	��230��$	��Top=�$��Center=�$��0,20,0,0q�.+��� $��30��$	��230�����#373E46$��Center=�$	��Top=�$��5,0,5,0q����	#FF0BCDFF$ 5��._�� .+��� $��C B F : App P R O��$��Fonts/#Saira Regular)�$��18(�$��Center=�$��Center=����#DCE0E4�� $��1��$��1��$
��Auto=�.��� $ 	Card_Grid��
������ $
��1540��$	��Top=�$��	10,0,10,0q� �� $ c0��$��1* ��� $ c1��$��1* ��� $ c2��$��1* ��� $ c3��$��1* � �� $ CG_R1��$��0.05* ��� $ CG_R2��$��0.25* ��� $ CG_R3��$��0.16* ��� $ CG_R4��$
��0.5* �.+��� $��1��$��0��$��4��8��  �� $��2��$��0��$��4��8�� 