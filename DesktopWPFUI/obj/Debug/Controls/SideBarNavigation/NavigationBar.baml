   M S B A M L   `   `   `  ����B  >TodoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:DesktopWPFUI.Controls.SideBarNavigation'DesktopWPFUI.Controls.SideBarNavigation  5      a5clr-namespace:DesktopWPFUI.Controls.SideBarNavigation'DesktopWPFUI.Controls.SideBarNavigation  5      M+clr-namespace:DesktopWPFUI.State.NavigatorsDesktopWPFUI.State.Navigators  5      ;    5DesktopWPFUI.Controls.SideBarNavigation.NavigationBar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:DesktopWPFUI.Controls.SideBarNavigation     5      L
navigation5clr-namespace:DesktopWPFUI.Controls.SideBarNavigation     5      ;nav+clr-namespace:DesktopWPFUI.State.Navigators     5      ���	#FF0046FF.��5      �   � 	Resources  5   
    �� 
TargetType   	NavButton �� BasedOn��%0   '	�       7   �� 5      " 	�6   8   6-   5       � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $	��100 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   =   7DesktopWPFUI.Controls.SideBarNavigation.SideBarIconItem  $��1��6%   $��50��62   $��50��6>   �� 5   
   $��3��6   $��Center=�6#    �� Orientation$ 
Horizontal=�6>   ���	#3F000000.+�5      �� $��5,0,0,0q�6   $/��)/TodoApp;component/Sources/icons/task.png��6%   $��26��6X   $��26��6c   $
��Left=�6o   $��Center=�6�   	� 5      $��Tasks��6   ,   &DesktopWPFUI.State.Navigators.ViewType   Tasks#��Z 6�   ��6+   Z� ��6A   Z� ��6X   �� *UpdateCurrentViewModelCommand+6�   5      �� 5!   
   $��4��6   $��Center=�6#   $ 
Horizontal=�6>   ���	#3F000000.+�5"      �� $��5,0,0,0q�6   $/��)/TodoApp;component/Sources/icons/user.png��6%   $��26��6X   $��26��6c   $
��Left=�6o   $��Center=�6�   	� 5#      $��Clients��6      Clients#��Z 6�   ��6-   Z� ��6C   Z� ��6Z   �� *UpdateCurrentViewModelCommand+6�   5$      �� 5&   
   $��5��6   $��Center=�6"   $ 
Horizontal=�6=   ���	#3F000000.+�5'      �� $��5,0,0,0q�6   $.��(/TodoApp;component/Sources/icons/tag.png��6%   $��26��6W   $��26��6b   $
��Left=�6n   $��Center=�6�   	� 5(      $
��Tags��6      Tags#��Z 6�   ��6*   Z� ��6@   Z� ��6W   �� *UpdateCurrentViewModelCommand+6�   5)      5*      5,      