   M S B A M L   `   `   `  ����B  >TestAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TestAPPTestAPP  5   	       TestAPP.First   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:TestAPP     5   	     � Title$  First��5   	   $	��450��6   $	��800��6$   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Check��5
         AutoGenerateColumns .     SelectionMode$ Single=�6>   $��400,0,0,218q�6U   $
��Left=�6j   $	��400��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *	IdProduct+  5      $ 
Товар��6%    64   �� *NameProduct+  5      $ Количество��6%    69   �� *Price+  5      $ Дата��6%    63   �� *Price+5      �� 5   
   -   5         ��Name$ 
btnAddCorz��5      $(��"Добавить в корзину��6%   $
��Left=�6B   $��	0,234,0,0q�6]   $	��Top=�6p   $	��150��6�   $��30��6�   �� 5   
   -   5        $ btnDellCorz��5      $(��"Удалить из корзины��6&   $
��Left=�6C   $��	0,304,0,0q�6^   $	��Top=�6q   $	��150��6�   $��30��6�     5   
   -   5        $ ProductsDataGrid��5       .  $ Single=�6I   $��	0,0,0,218q�6`   $
��Left=�6s   $	��400��6�    5        5      $ 
Номер��6%    64   �� *	IdProduct+  5      $ 
Товар��6%    64   �� *NameProduct+  5      $ Количество��6%    69   �� *Price+  5      $ Дата��6%    63   �� *Price+5      �� 5   
   -   5        $ btnLoadCorz��5      $#��Скачать корзину��6&   $
��Left=�6@   $��650,229,0,0q�6[   $	��Top=�6p   $	��150��6�   $��30��6�   6�   �� 5   
   -   5        $	 REG��5      $ ��Редактировать��6   $
��Left=�66   $��	0,269,0,0q�6Q   $	��Top=�6d   $	��150��6|   $��30��6�   6�   5!      5"      