   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       WpfApp1.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  Window1��5	   	   $��1290.367��6   $��925.188��6+    � 	Resources 5
         str  dbl�� 5   
   %f   &	        &	 1     ��5      常德移动分公司��5      X�5      	3.1415926Q�60   5      .��5      � $��0,0,-0.4,16q�6    � ColumnDefinitions 5   
   �� 5      $
��683* �6   �� 5      $
��111* �6   .+�5   
      WpfApp1.UserControl1  -   5          Name$ myUserControl1��5      $
��Left=�67   $��93��6R   $��	78,84,0,0q�6^   $	��Top=�6q   $	��308��6�   � 5   
   -   5         �Name$ gridMain��5      $
��Left=�6"   $	��185��6=   $��
44,209,0,0q�6J   $	��Top=�6^   $	��422��6v   .+�5      �� -   5         ��Name$ button1��5      $��Button��6?   $
��Left=�6P   $��	37,10,0,0q�6k   $	��Top=�6~   $	��127��6�   $��33��6�   z�5      T� 5      -   5        button1_movie�� T� X$ 0Q�5   @    T� Y$ 0Q�6F   5      5      �� 5   
   -   5         ��Name$ 
stackPanel��5      $
��Left=�6+   $	��624��6F   $��419,115,0,0q�6S   $	��Top=�6h   $	��466��6�   $��2��6�   .+�5       �� -   5        $ button2��5       $��Button��6&   $
��Left=�67   $��50��6R   $��53,0,0,0q�6^   $	��192��6p   �� 5"      -   5        	 ��Name$	 textBox2��5"      #��[  6)   $
��Left=�6S   $��65��6n   $��53,0,0,0q�6z   
 �� TextWrapping$

 Wrap=�6�   $	��192��6�   �� 5#      $	��111��6   $��NewFolder1/uu.jpg��6!   $��
0,0,-0.2,0q�6<   r� 5$      -   5        $��mediaElement��5$   4   $	��300��6   $	��450��6(    r� LoadedBehavior$ Manual=�5%   E    r� Volume 6   ��  �� ElementName$ volumeSlider�� �� Path$ Value�6E   �� 5(       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��5q�6O   .+�5)      �� $��Volume��6   
��� ���6*   �� 5*      -	   5         ��Name$ volumeSlider��5*       � Minimum$ 0Q�6/    � Maximum$ 1Q�6;    � Value$	 0.5Q�6G   $	��200��6S   5+      �� 5,      $ 
Horizontal=�6   $��Center=�62   $��5q�6O   .+�5-      �� -
   5        $ select��5-      $��select file��6=   $
��Left=�6S   $��23��6n   $��56��6{   �� 5.      -   5        $ playBtn��5.      {�.  $
��play��6M   $
��Left=�6\   $��23��6w   $��56��6�   50      53      55      56      