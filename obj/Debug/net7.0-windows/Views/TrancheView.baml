   M S B A M L   `   `   `  ����F  BOrdersLogic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:OrdersLogic.ViewsOrdersLogic.Views  5   	   #    OrdersLogic.Views.TrancheView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:OrdersLogic.Views     5   	     � Title$  TrancheView��5   	   $	��210��6   $	��528��6*   .��5	      � -   5         �Name$ AddNewTranche��5	      .+�5
   
   �� $��Дата��6   $
��Left=�6    $��28��6;   $��	53,20,0,0q�6G   $	��Top=�6Z   $	��200��6r   �� 5   
   $��
Сумма��6   $
��Left=�6    $��28��6;   $��	53,80,0,0q�6G   $	��Top=�6Z   $	��200��6r   �� 5   
   -   5         ��Name$ TrancheSumTextBox��5      $
��Left=�6-   $��28��6H   $��
264,80,0,0q�6T    �� TextWrapping$
 Wrap=�6h   $	��Top=�6�   $	��200��6�   ��6|   �� *Sum+ �� Mode$ TwoWay=�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ TrancheDatePicker��5      $
��Left=�60   $��28��6K   $��
264,20,0,0q�6W   $	��Top=�6�   $	��200��6�      SelectedDate 6k   �� *TrancheDate+$ TwoWay=�6�   �� 5   
   -   5         ��Name$ AddNewTrancheButton��5      $��Добавить��6.   $��Center=�6A   $��30��6^   $��	0,136,0,0q�6j   $	��Top=�6}   $	��150��6�   6�   5      5      