   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          �Name$  window_1��5   	      WpfApp1.TimeButton   ReportTimeA$ ReportTimeAHandler��5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$ 
MainWindow��5   	   $��509.6��6   $��839.6��6+   .��5      � -   5         �Name$ Grid_1��5      $ ReportTimeAHandler��6   .+�5   
   � -   5        $ Grid_2��5      $ ReportTimeAHandler��6   .+�5      � -   5        $ Grid_3��5   M   $ ReportTimeAHandler��6]   $��Center=�6   $��Center=�62    � RowDefinitions 5      �� 5      $	��60* �6$   �� 5      $	��60* �6$    � ColumnDefinitions 5      �� 5      $	��500 �6'   �� 5      $
��Auto �6'   .+�5      �� -   5        $��Button1��5      $��0��6+   $��1��68   $
��Left=�6H   $��50��6c   $	��Top=�6q   $	��131��6�   6�   �� 5      -   5        $��Button2��5      $��1��6+   $��1��68   $
��Left=�6H   $	��Top=�6c   $	��131��6{   $��42��6�   6�   �� 5      $��0��6   $��2��6)   $
��Left=�6;   $	��327��6V   $	��Top=�6d   $	��332��6|   .+�5      �� ���	#FFBF5316$��39��61   
���   �$��43��6�    �� Left 6=   ��  �� ElementName$ slider1��	 �� Path$	 Value�

 �� Top
 6�   �� $ slider2��$	 Value�6�   �� 5      -   5        $��slider1��5      $��21��6,   $ 69��68   $	
 164��6I   $	��199��6Z    � Minimum$ 1Q�6f    � Maximum$	 400Q�6r   �� 5       -   5        $��slider2��5       $��27��6,   $ 69��68   $	
 218��6I   $	��199��6Z   $ 1Q�6f   $	 100Q�6r   5!      5#      �� 5$      -	   5         ��Name$ 
stackPanel��5$      $ ReportTimeAHandler��6-   .+�5%      �� -
   5         ��Name$ listBox��5%      $ ReportTimeAHandler��6,   $
��Left=�6^   $	��100��6y   $	��Top=�6�   $	��195��6�      WpfApp1.TimeButton  5&      -   5          Name$ 
timeButton��5&   $   $ ReportTimeAHandler��68   $��Button��6j   $
��Left=�6{   $	��Top=�6�   $��75��6�   5'      5(      5)      5+      