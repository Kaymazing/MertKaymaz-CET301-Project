   M S B A M L   `   `   `  ����P  LMertKaymaz-301Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MertKaymaz_301ProjectMertKaymaz_301Project  5   	   '    !MertKaymaz_301Project.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MertKaymaz_301Project     5   	     � Title$#  ALA KURUMSAL - Giriş Ekranı��5   	   $	��248��6-   $	��364��6:    � 
ResizeMode$ NoResize=�6F   .��5	      � ��5
   
   �� 5       �� ImageSource$P JC:\Users\MertKaymaz\source\repos\MertKaymaz-301Project\source\bluecar2.png��6    � ColumnDefinitions 5   
   �� 5      $	��148 �6   6-   �� 5      6!    � RowDefinitions 5   
   �� 5      $	��82* �6   6+   �� 5      $	��43* �6   6+   �� 5      $	��43* �6   6+   �� 5      $	��36* �6   6+   .+�5   
   �� $��2��6   $��0��6$   $��0��61   $��source/placeholder2.png��6A    J� RenderTransformOrigin$ 0.494,0.479&�6b   $
��Fill=�6�   $��0,1,0,0q�6�    K� ZIndex$ 11��6�   �� 5   
   $��Kullanıcı Adı :��6   $��0��6+   $��1��6;   $��
Montserrat)�6H   $
��Bold"�6`   $��16(�6r   $
��Left=�6�   $	��Top=�6�   $��	34,13,0,0q�6�   $��19��6�   $	��114��6�   $��Normal$�6�   ���	#FF0A3044��5      }� 5      �� 5   
   $��Şifre :��6   $��0��6#   $��2��63   $��
Montserrat)�6@   $
��Bold"�6X   $��16(�6j   $
��Left=�6x   $��Center=�6�   $��	100,0,0,0q�6�   $��20��6�   $��48��6�   ���	#FF0B374C��5!      }� 5#      �� 5$   
   -   5         ��Name$ txtUserName��5$      $��1��6'   $��1��64   $��18,10,40,10q�6D   ���	#FF0C364C J� Opacity$	 0.6Q�6q   G� 5%   
   -   5        	 G�Name$	 txtPassword��5%   *   $��
18,10,40,9q�6   $��2��6?   $��1��6L   
 G� PasswordChar$
 *��6\   $ 0.514,0.484&�6m   ���	#FF0C3B54$	 0.6Q�6�   �� 5&   
   -   5         ��Name$ btnLogin��5&      $��
Giriş Yap��6#   $��3��67   $	��100��6D   $��	47,2,0,10q�6P   $
��Left=�6c   $��15(�6~   $��
Montserrat)�6�   $
��Bold"�6�   $��1��6�   ���	#FFF68C59���	#FF092F43$��1q�5'   @    �� 	IsDefault$
 True��6k   5(      5)      