   M S B A M L   `   `   `  ����P  LMertKaymaz-301Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MertKaymaz_301ProjectMertKaymaz_301Project  5   	   %    MertKaymaz_301Project.Customers   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MertKaymaz_301Project     5   	   -   5          � Title$!  ALA KURUMSAL - Müşteriler��5   	   $	��450��6+   $	��716��68    � 
ResizeMode$ NoResize=�6\   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��755* �6   �� 5      $	��29* �6   �� 5      $	��17* �6   ��5   
   �� 5       �� ImageSource$P JC:\Users\MertKaymaz\source\repos\MertKaymaz-301Project\source\blueblue.jpg��6   .+�5   
   �� -   5        $��	Ana Menü��5      $
��Left=�6$   $��	10,27,0,0q�5      $	��Top=�6$    J� RenderTransformOrigin$ -2.511,-0.428&�6<   $��26��6b   $��70��5      ���	#FFF68C59 J� Opacity$
 0.85Q�6E   $��
Montserrat)�6T   $��Black"�5      $��11(�6$   $	��1.5q�62   ���	#FF97B4EC6H   �� 5   
   -   5        $��	sparaclar��5   ,   $y�	Collapsed=�6   $��
0,10,0,380q�6=   $ 0.5,0.5&�6Q    K� ZIndex$ -2��6q   $��3��6�   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -0.262Q�6$   �� 5      T� 5       T� X$ -0.495Q�6)   5      .+�5      �� $��40��6   �� 6%   $�deneme��6)   6:   5       &   System.Windows.Controls.DataGrid  5!   
   -   5        $��dgCustomers��5!   )   	   CanUserAddRows$
	 True��6   $��10,75,10,41q�6v   $
 0.60Q�6�   $��3��6�   9� 5#   
   
 9� 
IsExpanded$
 False��6   $��
Montserrat)�6&   $
��Bold"�6>   $
��Left=�6P   $��78��6k   $��94,2,0,0q�6w   $	��Top=�6�   $	��716��6�    9� ExpandDirection$ Right=�6�    � Cursor$	 Pen��6�   $y�Visible=�6�   $��3��6�   ��5$      �� 5%      ���	#FFD58C6B$��2q�60   ���	#FF84AEE8$��27��6\   ._�5&      �� 
���   �$��Ekle/Güncelle/Sil��63   $��Black"�6L   $��Center=�6_   $��11(�6z   $	��113��6�    �� TextAlignment$ Center=�6�   5'      .��5)      � .+�5*      �� -   5        $��CWisim��5*      $
��Left=�6(   $��10,4,0,0q�6C   $��İsim��6U    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $��75��6�   $
 0.65Q�6�   �� 5+      -   5        $��	CWsoyisim��5+      $
��Left=�6+   $��	10,26,0,0q�6F   $��Soyisim��6Y   $
 Wrap=�6h   $	��Top=�6|   $��75��6�   $
 0.65Q�6�   �� 5,      -   5        $��CWsehir��5,      $
��Left=�6)   $��	98,26,0,0q�6D   $��Şehir��6W   $
 Wrap=�6d   $	��Top=�6x   $��75��6�   $ -1.46,1.867&�6�   $
 0.65Q�6�   �� 5-      -   5        $��CWyas��5-      $
��Left=�6'   $��98,4,0,0q�6B   $
��Yaş��6T   $
 Wrap=�6_   $	��Top=�6s   $��76��6�   $ -1.46,1.867&�6�   $
 0.65Q�6�   �� 5.      -	   5        $��	CWtelefon��5.      $
��Left=�6+   $��	10,49,0,0q�6F   $��Telefon��6Y   $
 Wrap=�6h   $	��Top=�6|   $��75��6�   $ -1.46,1.867&�6�   $
 0.65Q�6�   �� 5/      -
   5        $��	CWehliyet��5/      $��188,4,116,55q�6,   $��Ehliyet��6B   $ 0.645Q�6T   �� 50      -   5        $��CWsabika��50      $��188,26,116,33q�6+   $��Sabıka��6B   $ 0.645Q�6S   (  "System.Windows.Controls.DatePicker  52      -   5        $��CWdate��52      $��259,2,187,10q�6+   �� 53      -   5        $��CWekle��53      $
��Ekle��6'   $��413,3,106,55q�66   ���	#FF8ACE4B6z   �� 54      -   5        $��CWsil��54      $	��Sil��6&   $��413,48,106,10q�64   ���	#FFC425256b   �� 55      -   5        $��CWguncelleexpand��55      $��	Güncelle��61   $��413,25,106,33q�6D   ���	#FF25BDD96r   56      57      5;      5<      