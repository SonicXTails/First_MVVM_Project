   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Calculator.ViewsCalculator.Views  5   	   =#clr-namespace:Calculator.ViewModelsCalculator.ViewModels  5   	   1    +Calculator.Views.PercentageCalculatorWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Calculator.Views     5   	   :
viewModels#clr-namespace:Calculator.ViewModels     5   	     � Title$=  7Калькулятор процента от числа��5	   	   $	��300��6/   $	��500��6<   ���	#FF3E3535 � DataContext 5
      9  3Calculator.ViewModels.PercentageCalculatorViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Число:��6   $��0��6"   $��5q�6/   
�������6:   �� 5   
   $��0��61   $��25q�6>   
���������6   �� *InitialAmount+6J   �� 5   
   $��Процент %:��6   $��1��6&   $��5q�63   
�������6>   �� 5   
   $��1��6.   $��25q�6;   
���������6   �� *
Percentage+6G   �� 5   
   $9��3Рассчитать процент от числа��6   $��2��6f   $��5q�6s   
���   ���67   �� *CalculatePercentageCommand+6~   �� 5   
   $��Результат:��6   $��3��6&   $��5q�63   
�������6>   �� 5   
   $��3��6*   $��25q�67    �� 
IsReadOnly . 
���������6   �� *Result+6U   5      5       