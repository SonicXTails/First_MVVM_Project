   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Calculator.ViewModelsCalculator.ViewModels  5   	   !    Calculator.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Calculator.ViewModels     5   	     � Title$  Калькулятор��5   	   ���	#FF3E3535$	��358��64   $	��400��6A    � DataContext 5
      /   )Calculator.ViewModels.CalculatorViewModel  5   
   .��5      � $��0,0,0,-6q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Stretch=�5      $��10q�60   $	��Top=�6<   
�������$��0��5      $��0��6"   $��3��6/   ��5      �� *FirstNumber+ �� UpdateSourceTrigger$ PropertyChanged=�5   /   �� 5"   
   $��Stretch=�5#      $��10q�60   $	��Top=�6<   
�������$��0��5$      $��1��6"   $��3��6/   ��5"      �� *SecondNumber+$ PropertyChanged=�5$   /   �� 5'   
    �� 
IsReadOnly . $��Stretch=�5(      $��10q�60   $	��Top=�6<   
�������$��0��5)      $��2��6"   $��3��6/   ��5'      �� *Result+5)   /   �� 5,   
   $��Stretch=�5-      $��10q�61   $	��Top=�6=   
�������$��0��5.      $��3��6#   $��3��60    �� Text 5,      �� *
Operator+$ PropertyChanged=�.@�5/      �� $��+��6   �� 50      $��-��6   �� 51      $��*��6   �� 52      $��/��6   53      �� 55   
   $��Рассчитать��6   $��
10,48,10,0q�6K   $	��Top=�6_   $��0��56      $��3��6!   $��3��6.   ��55   &   �� *CalculateCommand+56   .   �� 58   
   $8��2Показать историю рассчётов��6   $��
10,94,10,0q�6]   $	��Top=�6q   $��0��59      $��3��6!   $��3��6.   ��58   6   �� *OpenHistoryCommand+59   .   �� 5;   
   $9��3Рассчитать процент от числа��6   $��10,140,10,0q�6k   $	��Top=�6�   $��0��5<      $��3��6!   $��3��6.   ��5;   7   �� *!OpenPercentageCalculatorCommand+5<   .   5=      5>      