   M S B A M L   `   `   `  ����P  LMertKaymaz-301Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MertKaymaz_301ProjectMertKaymaz_301Project  5   	   #    MertKaymaz_301Project.Araclar   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MertKaymaz_301Project     5   	   -   5          � Title$  ALA KURUMSAL - Araçlar��5   	   $	��450��6(   $	��872��65    � 
ResizeMode$ NoResize=�6`   .��5	      � ��5
   
   �� 5       �� ImageSource$P JC:\Users\MertKaymaz\source\repos\MertKaymaz-301Project\source\blueblue.jpg��6   .+�5   
   �� -   5        $��	Ana Menü��5      $
��Left=�6$   $��	10,27,0,0q�5      $	��Top=�6$    J� RenderTransformOrigin$ -2.511,-0.428&�6<   $��26��6b   $��70��5      ���	#FFF68C59 J� Opacity$
 0.85Q�6I   $��
Montserrat)�6X   $��Black"�5      $��11(�6$   $	��1.5q�62   ���	#FF97B4EC6H   �� 5   
   -   5        $��	sparaclar��5   ,   $y�	Collapsed=�6   $��
0,10,0,380q�6=   $ 0.5,0.5&�6Q    K� ZIndex$ -2��6q   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -0.262Q�6$   �� 5      T� 5       T� X$ -0.495Q�6)   5      .+�5      �� $��40��6   �� 6%   $�deneme��6)   6:   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��
dgVehicles��5   )      CanUserAddRows$
 True��6   $��10,75,10,41q�6r   $
 0.60Q�6�   9� 5   
   	 9� 
IsExpanded$	 False��6   $��
Montserrat)�6&   $
��Bold"�6>   $
��Left=�6P   $��78��6k   $��94,2,0,0q�6w   $	��Top=�6�   $	��716��6�   
 9� ExpandDirection$
 Right=�6�    � Cursor$	 Pen��6�   $y�Visible=�6�   ��5      �� 5       ���	#FFD58C6B$��2q�60   ���	#FF84AEE8$��27��6\   ._�5!      �� 
���   �$��Ekle/Güncelle/Sil��63   $��Black"�6L   $��Center=�6_   $��11(�6z   $	��113��6�    �� TextAlignment$ Center=�6�   5"      .��5$      � .+�5%      �� -   5        $��VWmodel��5%      $
��Left=�6)   $��10,4,0,0q�6D   $��Model��6V    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $��75��6�   $
 0.65Q�6�   �� 5&      -   5        $��VWbrand��5&      $
��Left=�6)   $��	10,26,0,0q�6D   $��Marka��6W   $
 Wrap=�6d   $	��Top=�6x   $��75��6�   $
 0.65Q�6�   �� 5'      -   5        $��VWcolor��5'      $
��Left=�6)   $��	98,26,0,0q�6D   $
��Renk��6W   $
 Wrap=�6c   $	��Top=�6w   $��75��6�   $ -1.46,1.867&�6�   $
 0.65Q�6�   �� 5(      -   5        $��VWyear��5(      $
��Left=�6(   $��98,4,0,0q�6C   $
��Yıl��6U   $
 Wrap=�6`   $	��Top=�6t   $��76��6�   $ -1.46,1.867&�6�   $
 0.65Q�6�   �� 5)      -	   5        $��	VWcountry��5)      $
��Left=�6+   $��	10,49,0,0q�6F   $��Ülke��6Y   $
 Wrap=�6e   $	��Top=�6y   $��75��6�   $ -1.46,1.867&�6�   $
 0.65Q�6�   �� 5*      -
   5        $��VWowner��5*   L    �� DisplayMemberPath$
 Name��63   $
��Left=�6[   $��	98,49,0,0q�6v    �� Text$ Sahibi��6�   $	��Top=�6�   $��75��6�   $ -1.46,1.867&�6�   $
 0.65Q�6�   $��17��6�   ��6   �� 5,      �� 5.      -   5        $��VWavailable��5.      $��188,4,116,55q�6.   $��Müsait��6D   $ 0.645Q�6U   �� 5/      -   5        $��
VWpreowned��5/      $��188,26,116,33q�6-   $��
İkinci El��6D   $ 0.645Q�6X   �� 50      -   5        $��VWsold��50      $��188,48,116,11q�6)   $��	Satıldı��6@   $ 0.645Q�6R   �� 51      -   5        $��	VWcrashed��51      $��279,4,25,55q�6,   $��Kazalı��6A   $ 0.645Q�6R   �� 52      -   5        $��
VWrentable��52      $��278,26,247,33q�6-   $��Kiralık��6D   $ 0.645Q�6V   �� 53      -   5        $��VWsale��53      $��278,48,25,11q�6)   $��	Satılık��6?   $ 0.645Q�6Q   (  "System.Windows.Controls.DatePicker  54      -   5        $��VWdate��54      $��365,0,81,11q�6+   �� 55      -   5        $��VWekle��55      $
��Ekle��6'   $��
519,3,0,55q�66   ���	#FF8ACE4B6r   �� 56      -   5        $��VMsil��56      $	��Sil��6&   $��519,48,0,10q�64   ���	#FFC425256`   �� 57      -   5        $��VWguncelleexpand��57      $��	Güncelle��61   $��519,25,0,33q�6D   ���	#FF25BDD96p   58      59      5=      5>      