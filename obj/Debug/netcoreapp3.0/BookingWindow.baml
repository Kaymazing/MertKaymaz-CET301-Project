   M S B A M L   `   `   `  ����P  LMertKaymaz-301Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MertKaymaz_301ProjectMertKaymaz_301Project  5   	   )    #MertKaymaz_301Project.BookingWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MertKaymaz_301Project     5   	   -   5          � Title$   ALA KURUMSAL - Kiralamalar��5   	   $	��450��6,   $	��716��69    � 
ResizeMode$ NoResize=�6\   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��337* �6   �� 5      $
��463* �6   ��5   
   �� 5       �� ImageSource$P JC:\Users\MertKaymaz\source\repos\MertKaymaz-301Project\source\blueblue.jpg��6   .+�5   
   �� -   5        $��	Ana Menü��5      $
��Left=�6$   $��	10,10,0,0q�5      $	��Top=�6$    J� RenderTransformOrigin$ -2.511,-0.428&�6<   $��26��6b   $��70��5      ���	#FFF68C59 J� Opacity$
 0.85Q�6I   $��
Montserrat)�6X   $��Black"�5      $��11(�6$   $	��1.5q�62   ���	#FF97B4EC6H   �� 5   
   -   5        $��	sparaclar��5   ,   $y�	Collapsed=�6   $��
0,10,0,380q�6=   $ 0.5,0.5&�6Q    K� ZIndex$ -2��6q   $��2��6�   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -0.262Q�6$   �� 5      T� 5       T� X$ -0.495Q�6)   5      .+�5      �� $��40��6   �� 6%   $�deneme��6)   6:   5      &   System.Windows.Controls.DataGrid  5    
   -   5        $��	dgBooking��5       $��22,80,22,36q�6Z   $
 0.60Q�6o   $��2��6~   9� 5"   
   	 9� 
IsExpanded$	 False��6   $��
Montserrat)�6&   $
��Bold"�6>   $
��Left=�6P   $��78��6k   $��94,2,0,0q�6w   $	��Top=�6�   $	��716��6�   
 9� ExpandDirection$
 Right=�6�    � Cursor$	 Pen��6�   $y�Visible=�6�   $��2��6�   $ 0.5,0.5&�6�   z�5#      V� 5$      .~�5%      �� �� 5&       �� AngleY$
 0.04Q�6$   �� 5'      T� 5(       T� Y$ 0.249Q�6)   5)      ��5+      �� 5,      ���	#FFD58C6B$��2q�60   ���	#FF84AEE8$��27��6\   ._�5-      �� 
���   �$��Ekle/Güncelle/Sil��63   $��Black"�6L   $��Center=�6_   $��11(�6z   $	��113��6�    �� TextAlignment$ Center=�6�   5.      .��50      � .+�52      �� -   5        $��
BWcustomer��52   L    �� DisplayMemberPath$
 Name��63   $
��Left=�6^   $��	10,14,0,0q�6y    �� Text$ 	Müşteri��6�   $	��Top=�6�   $��75��6�   $ -1.46,1.867&�6�   $
 0.65Q�6�   $��20��6�   ��6   �� 6�   �� 53      -   5        $��	BWvehicle��53   Q   $ 	ModelName��63   $
��Left=�6b   $��	10,47,0,0q�6}   $ Araç��6�   $	��Top=�6�   $��75��6�   $ -1.46,1.867&�6�   $
 0.65Q�6�   $��19��6�   ��6   �� 6�   �� 54      -   5        $��BWhire��54   o    �� SelectedValuePath$ Id��63   $
��Left=�6}   $��	90,14,0,0q�6�   $ Alış Yeri��6�   $	��Top=�6�   $��93��6�   $ -1.46,1.867&�6�   $
 0.65Q�6  $��20��6  ��6   ��  �� SelectedValue 6J   �� *
SelectedId+.@�55      �� .��6#   	İstanbul6-   �� 56      .��6#   İzmir6*   �� 57      .��6#   Ankara6+   58      �� 59      -   5        $��BWdrop��59   v   $ Id��6:   $
��Left=�6�   $��	91,46,0,0q�6�   $ Bırakma Yeri��6�   $	��Top=�6�   $��92��6�   $ -1.46,1.867&�6�   $
 0.65Q�6  $��20��6  ��6   �� *MyList+ 6Q   �� *
SelectedId+.@�5:      �� .��6#   	İstanbul6-   �� 5;      .��6#   İzmir6*   �� 5<      .��6#   Ankara6+   5=      �� 5?      -	   5        $��BWsold��5?      $��303,16,198,44q�6)   $��Satıldı mı?��6@   $ 0.645Q�6V   �� 5A      -
   5        $��BWeklee��5A      $
��Ekle��6(   $��396,7,123,51q�67   ���	#FF8ACE4B6u   �� 5B      -   5        $��BWsill��5B      $	��Sil��6'   $��396,52,123,6q�65   ���	#FFC425256b   �� 5C      -   5        $��BWguncellee��5C      $��	Güncelle��6,   $��396,29,123,29q�6?   ���	#FF25BDD96m   (  "System.Windows.Controls.DatePicker  5D      -   5        $��BWbaslangic��5D      $
��Left=�60   $��
196,14,0,0q�6K   $	��Top=�6_      Text$ Kiralama Tarihi��6w   $ 0.481,2.356&�6�   $��20��6�     5E      -   5        $��BWbitis��5E      $
��Left=�6,   $��
196,46,0,0q�6G   $	��Top=�6[   $ Kiralama Tarihi��6s   $ 0.481,2.356&�6�   $��20��6�   �� 5F      $��11(�6   $
��Left=�6*   $��10,3,0,0q�6E   $��	Müşteri��6W   $
��Wrap=�6f   $	��Top=�6z   �� 5G      $��11(�6   $
��Left=�6*   $��	10,35,0,0q�6E   $��Araç��6X   $
��Wrap=�6d   $	��Top=�6x   �� 5H      $��11(�6   $
��Left=�6*   $��91,3,0,0q�6E   $��Teslim Alma��6W   $
��Wrap=�6j   $	��Top=�6~   �� 5I      $��11(�6   $
��Left=�6*   $��	91,35,0,0q�6E   $��Teslim Etme��6X   $
��Wrap=�6k   $	��Top=�6   �� 5J      $��11(�6   $
��Left=�6*   $��	196,3,0,0q�6E   $��Başlangıç��6X   $
��Wrap=�6i   $	��Top=�6}   �� 5K      $��11(�6   $
��Left=�6*   $��
196,35,0,0q�6E   $��Bitiş��6Y   $
��Wrap=�6f   $	��Top=�6z   5L      5M      �� 5N   
   -   5        $��	Ödemeler��5N      $
��Left=�6$   $��	10,41,0,0q�5O      $	��Top=�6    $ -2.511,-0.428&�68   $��26��6^   $��70��5P      ���	#FF865582$
 0.85Q�6E   $��
Montserrat)�6T   $��Black"�5Q      $��11(�6    $	��1.5q�6.   ���	#FF97B4EC6D   5U      5V      