   M S B A M L   `   `   `  ����D  @WPFDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPFDesign.ViewModelWPFDesign.ViewModel  5   	   %clr-namespace:WPFDesign	WPFDesign  5   	       WPFDesign.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0vm!clr-namespace:WPFDesign.ViewModel     5   	   )localclr-namespace:WPFDesign     5   	   -   5          �Name$  DashboardWindow��5
   	    � Title$ 
MainWindow��5	   	   $	��580��6   $	��930��6)    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      -   'WPFDesign.ViewModel.NavigationViewModel  5   
   .��5      � .+�5   
   �� ���#ECF0F1 �� CornerRadius$ 10��5      �� 5   
   ���#5C5C5C$	��Top=�5      $
��Left=�5      $ 
10,0,100,0��5      $��80��5      $	��850��5      ._�5      �� $��C #  D E S I G N  P R O��6      HeaderStyle#��[  5       5"      �� 5$   
   ���#5C5C5C$��Bottom=�5%      $��Right=�5&      $ 
100,0,10,0��5'      $��80��5(      $	��850��5)      ._�5*      �� $.��(D E S I G N    T H E   I N T E R F A C E��6     FooterStyle#��[ 5+      5-      �� 52   
   ���#303030���#FFFFFF$��0,5,0,5q�54      $	��480��55      $��0,10,0,0q�56      $ 25��57      � 59   
    � ColumnDefinitions 5:      �� 5;      $��25 �6#   �� 5<      $	��180 �6#   �� 5=      $��40 �6#   �� 5>      $	��660 �6#   �� 5?      $��25 �6#   	 � RowDefinitions	 5A      �� 5B      $��0 �6    �� 5C      $��80 �6    �� 5D      $��55 �6    �� 5E      $	��370 �6    �� 5F      $��0 �6    .+�5J      � $��2��6   $��1��5K      .+�5L      �� -   5        
 ��Name$
 	SearchBox��5L        SearchBoxStyle#��[ 5N      ��5M      �� *
FilterText+ �� UpdateSourceTrigger$ PropertyChanged=�5N      �� 5P      $��Search��6     SearchTextStyle#��[ 5Q      5R      � 5U      $��3��6   $��1��5V      $��0,10,0,0q�5W      .+�5X      �� $
��Auto=�6   .��5Y      �� ��6#   �� *SourceCollection+��5Z      �� 5[      .R�5\   "   �� .+�5]   &   	�   MenuButtonStyle#��[ 5_   .    	� 	GroupName$ 	MenuGroup��5`   .   ��5]   2   �� *
MenuName+
 � Tag 5^   .   �� *	MenuImage+5`   .   5a   #   5b      5d      5e      5f      5i      5j      5k      