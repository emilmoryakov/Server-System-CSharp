   M S B A M L   `   `   `  ����F  B206Homework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:_206Homework_206Homework  5   	       _206Homework.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:_206Homework     5   	     � Title$  Database Elements��5   	   $	��470��6#   $	��600��60   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� $��0��6   $��10q�6%   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��0,0,0,10q�6O   �� 5      -   5        $��Sort by Name��5      $��60��6,   $��16(�68   $
��Bold"�6F   6X   �� 5      -   5        $��Sort by Price��5      $��60��6-   $��16(�69   $
��Bold"�6G   6Y   �� 5      -   5         ��Name$ ElementsTextBox��5      $	��198��6/   $��54��6;   $��18(�6G   $��0,10,0,0q�6U   �� 5      -   5        $��LimitCountBtn��5   ?   $��Show Limited Amount��6   $��32��63   6T   �� 5      -   5        $ 
NameTxtBox��5   *   $��Product Name��6   $	��198��6>   $��50��6J   $��18(�6V   $��0,10,0,0q�6d   �� 5      -   5        $ PriceTxtBox��5   ,   $��Product Price��6   $	��198��6A   $��50��6M   $��18(�6Y   $��0,10,0,0q�6g   �� 5      -   5         ��Name$ AddNewProductBtn��5      $��Add Product��6/   $��60��6E   $��16(�6Q   $
��Bold"�6_   $��0,10,0,0q�6q   6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ ElementsDataGrid��5      $��1��6-      AutoGenerateColumns$ False��6=   $��10q�6Y      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6H   
   FontSize$
 14Q�6R      
FontWeight$
 Bold"�6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6`     5      $
 Name��6%   $	 * 6L   $
 14Q�6V   $
 Bold"�6d    63   �� *Name+6d     5      $ Price��6%   $	 * 6N   $
 14Q�6X   $
 Bold"�6f    64   �� *Price+6f   5!      5"      5$      