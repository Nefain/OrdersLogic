   M S B A M L   `   `   `  ����F  BOrdersLogic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:OrdersLogic.ViewsOrdersLogic.Views  5   	   #    OrdersLogic.Views.LoginWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:OrdersLogic.Views     5   	     � Title$  
Логин��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��201��6<   $	��366��6I   .��5	      �  � RowDefinitions 5
   
   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $
��Auto �6   .+�5   
   �� $��1��6   $��	10,0,10,0q�6!   Введите Логин:6D   �� 5   
   -   5        $��LoginBox��5      $��2��6"   $	��250��6/   $��	10,0,10,0q�6>   6S   �� 5   
   $��4��6   $��	10,0,10,0q�6!   Введите Пароль:6E   G� 5   
   -   5        $��newPasswordBox��5      $��5��6,   $	��250��69   $��	10,0,10,0q�6H    G� PasswordChar$ *��6[   6n   � 5   
   $��7��6   $��Right=�6!   $��0,15,0,0q�6=   .+�5      �� -   5         ��Name$ AcceptButton��5       �� 	IsDefault$
 True��6+   $��60��6W   $��0,0,10,0q�6e   .��6w   OK6{   �� 5      -   5         �� IsCancel$
 True��5      $��60��6%   $��0,0,10,0q�63   .��6Z   Отмена6b   5      5      5      