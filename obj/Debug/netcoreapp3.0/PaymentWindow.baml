   M S B A M L   `   `   `  ����P  LMertKaymaz-301Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MertKaymaz_301ProjectMertKaymaz_301Project  5   	   )    #MertKaymaz_301Project.PaymentWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MertKaymaz_301Project     5   	   -   5          � Title$  ALA KURUMSAL - Ödemeler��5   	   $	��450��6)   $	��533��66    � 
ResizeMode$ NoResize=�6Y   .��5	      �  � ColumnDefinitions 5
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
   -   5        $��	dgPayment��5!   )   	   CanUserAddRows$
	 True��6   $��55,85,25,31q�6p   $
 0.60Q�6�   9� 5#   
   
 9� 
IsExpanded$
 False��6   $��
Montserrat)�6&   $
��Bold"�6>   $
��Left=�6P   $��78��6k   $��94,2,0,0q�6w   $	��Top=�6�   $	��716��6�    9� ExpandDirection$ Right=�6�    � Cursor$	 Pen��6�   $y�Visible=�6�   $��3��6�   ��5$      �� 5%      ���	#FFD58C6B$��2q�60   ���	#FF84AEE8$��27��6\   ._�5&      �� 
���   �$��Ekle/Güncelle/Sil��63   $��Black"�6L   $��Center=�6_   $��11(�6z   $	��113��6�    �� TextAlignment$ Center=�6�   5'      .��5)      � .+�5*      �� -   5        $��PWtaksitsayi��5*      $
��Left=�6.   $��
112,48,0,0q�6I   $��Taksit Sayısı��6]    �� TextWrapping$
 Wrap=�6r   $	��Top=�6�   $��86��6�   $
 0.65Q�6�   $��18��6�   �� 5+      -   5        $��PWmethod��5+   v    �� SelectedValuePath$ Id��6:   $
��Left=�6�   $��
112,25,0,0q�6�    �� Text$ Bırakma Yeri��6�   $	��Top=�6�   $��86��6�   $ -1.46,1.867&�6�   $
 0.65Q�6  $��18��6  ��6   �� *MyList+ �� SelectedValue 6Q   �� *
SelectedId+.@�5,      �� .��6#   Peşin6*   �� 5-      .��6#   Kredi Kartı60   5/      �� 50      -   5        $��PWtaksit��50      $��112,6,192,54q�6+   $��Taksitli mi?��6A   $ 0.645Q�6X   �� 52      -   5        $��CWekle��52      $
��Ekle��6'   $��220,3,299,55q�66   ���	#FF8ACE4B6z   �� 53      -	   5        $��CWsil��53      $	��Sil��6&   $��220,48,299,10q�64   ���	#FFC425256b   �� 54      -
   5        $��CWguncelleexpand��54      $��	Güncelle��61   $��220,25,299,33q�6D   ���	#FF25BDD96r   �� 55      -   5        $��	PWbooking��55       �� DisplayMemberPath$ Id��6D   $
��Left=�6[   $��	10,25,0,0q�6v   $	��Top=�6�   $��86��6�   $ -1.46,1.867&�6�   $
 0.65Q�6�   $��18��6�   ��6,   �� 58      59      5:      5>      5?      