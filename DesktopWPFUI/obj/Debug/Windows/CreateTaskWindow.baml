   M S B A M L   `   `   `  ����B  >TodoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DesktopWPFUI.WindowsDesktopWPFUI.Windows  5   	   M+clr-namespace:DesktopWPFUI.State.NavigatorsDesktopWPFUI.State.Navigators  5      +    %DesktopWPFUI.Windows.CreateTaskWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:DesktopWPFUI.Windows     5   	   ;nav+clr-namespace:DesktopWPFUI.State.Navigators     5        � Title$  Creating task��5	   	   $	��450��6   $	��800��6,    � 
ResizeMode$ NoResize=�68   ��5
      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF0D52B6��6    � Offset$ 0Q�6-   � 5      $ 	#FF164487��6   $ 1Q�6-   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��40 �6   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��40 �6    � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $	��250 �6   �� 5      $
��auto �6   �� 5       $
��auto �6   .+�5#   
   �� $��1��6   $��1��6$   $��Creating task��61   ���	#FFF7F7F7$
��Bold"�6]   $��26(�6o    �� Padding$ 5q�6~   �� 5$   
   -   5        $
��Name��5$   /   $��3��6   $��1��6"   $��1,1,1,0q�6;   $��30(�6U   �� 5%   
   -   5        $��Description��5%   j   $��3��6   $��3��6"   	 �� TextWrapping$
	 Wrap=�6/   
 �� AcceptsReturn
 .  �� 
AcceptsTab . $��18(�6}   �� 5'   
   -   5        $��BtnSave��5'   r   $��3��6   $��5��6!   $
��Save��6/   $	��400��6Z   $��7q�6f   
���   �
���   �
�������$
��Bold"�6�   $��16(�6�   $��40q�6�   � 5)   
   $��3��6   $��1��6   ���	#56112F6E 5*      �� 5+      $
��auto �6    �� 5,      $
��auto �6    �� 5-      $
��auto �6    �� 5.      $
��auto �6    .+�51      �� $��Task planned start��6   $��0��61   $��0��6>   $
��Bold"�6N   
�������6`   (  "System.Windows.Controls.DatePicker  52      -   5        $��Start��52   6   $��1��6   $��1��6&   ���	#FF0074FF6C   � 55      $��2��6    56      �� 57      $
��auto �6'   �� 58      $��* �6'   �� 59      $
��auto �6'    5=      �� 5>      $��10 �6$   �� 5?      $
��auto �6$   .+�5C      �� $
��Tags��6   $��0��6(   $��1��69   $
��Bold"�6F   
�������6X   �� 5D      -   5         ��Name$ AddTagButton��5D      $��2��6/   $��1��6?   $��Add tag��6L   $��4q�6^   
�������6}   5H      � 5J      $��3��6    5K      �� 5L      $	��200 �6'   .+�5O      �� -   5        $��TagsStackPanel��5O      5Q      5S      5Y      5\      5]      