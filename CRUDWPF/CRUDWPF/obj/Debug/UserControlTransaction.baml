   M S B A M L   `   `   `  ����B  >CRUDWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CRUDWPFCRUDWPF  5      $    CRUDWPF.UserControlTransaction   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:CRUDWPF     5      .��5	      � .+�5
   
   � $��0,2,-253,-2q�6   $
��Left=�6$   $
��1053��6?   
�������.+�5      �� $��Transaction��6   $
��Left=�6*   $��
394,70,0,0q�6E   $	��Top=�6Y   $��48(�6q   �� 5      $��ID��6   $
��Left=�6!   $��517,280,0,0q�6<   $	��Top=�6Q   �� 5      -   5        $��Insert��5      $
��Left=�6&   $��764,284,0,0q�6A   $	��Top=�6V   $��75��6n   ���	#FF116FA46�   &   System.Windows.Controls.DataGrid  5      -   5           Name$  dg_Supplier��5      $
��Left=�6,   $	��248��6G   $��132,185,0,0q�6T   $	��Top=�6i   $	��349��6�   "   VerticalScrollBarVisibility$ Visible=�6�      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� *Id+  5      $ 
Order Date��6)    5      �� *	OrderDate+ �� StringFormat$ 
dd/MM/yyyy��4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5   "   �� -   5        .��5   B   Delete6J   5      5      5      �� 5      $��
Order Date��6   $
��Left=�6)   $��517,342,0,0q�6D   $	��Top=�6Y   �� 5      -   5        	 ��Name$	 txt_ID��5      $
��Left=�6&   $��23��6A   $��517,309,0,0q�6M   
 �� TextWrapping$

 Wrap=�6b   $	��Top=�6v   $	��175��6�   {�.  6�   �� 5      -   5         ��Name$ 	UpdateBtn��5      $
��Edit��6(   $
��Left=�67   $��764,342,0,0q�6R   $	��Top=�6g   $��75��6   ���	#FF116FA46�   �� 5       -   5        $	 
Txt_Search��5       $
��Left=�6*   $��23��6E   $��517,185,0,0q�6Q   $

 Wrap=�6f   $	��Top=�6z   $	��175��6�   6�   �� 5!      -   5        $��Search��5!      $
��Left=�6&   $��764,186,0,0q�6A   $	��Top=�6V   $��75��6n   ���	#FF116FA46�   (  "System.Windows.Controls.DatePicker  5"      -   5        $��datePicker1��5"   U   $��25��6   $
��Left=�6%   $��517,371,0,0q�6@   $	��Top=�6h   $	��124��6�   6�   �� 5#      -	   5        $ btn_refresh��5#      $��Refresh��6*   $
��Left=�6<   $��882,185,0,0q�6W   $	��Top=�6l   $��83��6�   ���	#FF116FA46�   5$      5%      5&      