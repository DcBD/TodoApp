   M S B A M L   `   `   `  ����B  >TodoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DesktopWPFUI.ControlsDesktopWPFUI.Controls  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 6@   (    "DesktopWPFUI.Controls.TaskContents   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:DesktopWPFUI.Controls     5      6sys&clr-namespace:System;assembly=mscorlib     6@   -   5        .��5	      � -   5        $��TaskContentsGrid��5	        � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $��20 �6   �� 5      $	��150 �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��1��6&   $��75��64   $��Center=�6@   .+�5      �� $��25(�6.   $��0,0,0,6q�6<   $��Yu Gothic Medium)�6M   $��Center=�6k    �� TextAlignment$ Center=�6�   ��6   �� *Name+6�   ��5       �� 5!       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67    �� RelativeTransform 5"      V� 5#      .~�5$      ��  �� CenterY$	 0.5Q�6-    �� CenterX$	 0.5Q�6;   �� 5%       �� CenterY$	 0.5Q�6,   	 �� CenterX$		 0.5Q�6:   �� 5&      
 �� Angle$
 90Q�6.    �� CenterY$	 0.5Q�69    �� CenterX$	 0.5Q�6G   T� 5'      5(      .��5*      �  � Color$ White��6#    � Offset$ 0.759Q�61   � 5+      $ 	#FFC9C9C9��6#   $ 1Q�65   5,      50      �� 54   
   $��0��6   $��2��6(   $��Visible=�65   ���	#FFCBCBCB$��10q�6r   $��0,0,0,10q�6   $��4q�6�    � 	Resources 55      ��%X   (��       56      *,*SystemParameters.VerticalScrollBarWidthKey+)X�6   4Q�6^   57      .��59      �� $��15(�66   $
��0,20q�6D   $
��auto��6R   $
��Wrap=�6`   ��6   �� *Description+6`   5:      � 5<   
   $��2��6   $��3��6    5>      �� 5?      $
��auto �6    �� 5@      $
��auto �6    �� 5A      $
��auto �6    �� 5B      $
��auto �6    �� 5C      $��* �6    �� 5D      $
��auto �6    �� 5E      $
��auto �6    �� 5F      $
��auto �6    �� 5G      $��40 �6    .+�5J      �� $��0��6   $��Start��6%   $
��Bold"�62   $��16(�6D    �� Padding$ 10q�6R   
�������6_   �� 5K      $��1��6   $ 10q�6=   $��DemiBold"�6J   
���������6%   �� *Start+6`   �� 5M      $��2��6   $��Status��6%   $
��Bold"�63   $��16(�6E   $ 10q�6S   
�������6`   �� 5N      $��3��6   $ 10q�6F   
��� � �$��DemiBold"�6f   ��6%   ��  �� Path$ 
StatusText�6f   �� 5P      -   5        $��StartTaskButton��5P      $��5��6.   $��Start��6;   $��7q�6K   $��4q�6W   ���	#FFA1D0FF6y   �� 5Q      -   5        $��SetTaskAsFinished��5Q      $��5��6.   $��Finish��6;   ���	#FF17D878$��7q�6c   $��4q�6o   6z   �� 5R      -   5        $��DeleteTaskButton��5R   J   $��7��6   $��Delete��6"   ���	#FFC5177E$��7q�6�   $��4q�6�   5U      5V      5W      