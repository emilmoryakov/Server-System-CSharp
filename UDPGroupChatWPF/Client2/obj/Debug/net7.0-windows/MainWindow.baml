   M S B A M L   `   `   `  ����  Client2    Client2.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Group Chat Client��5   	   $	��450��6#   $	��800��60   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5
   
   �� $��0��6   .��5      �� -   5         ��Name$ ChatHistory��5      ��6+   �� ��5      �� 5      .R�5      �� ���#E5E5EA$��1q�67    �� Padding$ 5q�6K    �� CornerRadius$ 5��6W   ._�5      �� $��SF Pro Display)�69   ��6(   �� 69   5      5      5      5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      �� -   5         ��Name$ MessageTextBox��5      $��0��6.   $��5q�6>   $��SF Pro Display)�6I   �� 5      -   5         ��Name$ 
SendButton��5      $
��Send��6)   $��1��68   $��5q�6H   $��80��6l   $��30��6w   ���#007AFF���#FFFFFF$��SF Pro Display)�6�   5      5       � 	Resources 5      	 �� 
TargetType
 �� Property �� Value��%~   '��       �� 5   
   "	 ��6   .�5       �� 
 � ��$
 Auto=�6<   �� 5!      
 � ��$ Disabled=�6>   5"      5#      5$      