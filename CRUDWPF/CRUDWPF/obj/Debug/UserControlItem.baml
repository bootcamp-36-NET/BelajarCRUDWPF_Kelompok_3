   M S B A M L   `   `   `  ����B  >CRUDWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CRUDWPFCRUDWPF  5          CRUDWPF.UserControlItem   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:CRUDWPF     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � .+�5   
   � $��0,2,-253,-2q�6   $
��Left=�6$   $
��1053��6?   
�������.+�5      �� $
��Item��6   $
��Left=�6#   $��84,4,0,0q�6>   $	��Top=�6P   $��48(�6h   &   System.Windows.Controls.DataGrid  5      -   5           Name$  dg_Supplier��5      $
��Left=�6,   $	��339��6G   $��	72,76,0,0q�6T   $	��Top=�6g   $	��440��6   "   VerticalScrollBarVisibility$ Visible=�6�      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+  5      $
 Name��6)    67   �� *Name+  5      $ Price��6)    68   �� *Price+  5      $ Stock��6)    68   �� *Stock+  5      $ Supplier Id��6)    6>   �� *
SupplierId+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Action��6-      CellTemplate 5      �� 5      .R�5   "   ��  ��Name$ DeleteBtn_Click��6)   -   5        .��5   &   '  !MaterialDesignThemes.Wpf.PackIcon  ���	#FFFFFAFC	   Kind$	 Trash=�6U   $��25��6b   $��25��6m   5   #   5      5      5      �� 5      -   5        
 ��Name$
 lblID��5      $��ID��6#   $
��Left=�60   $��517,126,0,0q�6K   $	��Top=�6`   �� 5       -   5         ��Name$ txtID��5       $
��Left=�6%   $��26��6@   $��590,126,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��204��6�    �� 
IsReadOnly . 6�   �� 5!      -   5        $
 lblName��5!      $
��Nama��6%   $
��Left=�64   $��517,176,0,0q�6O   $	��Top=�6d   �� 5"      -   5        $ txtName��5"      $
��Left=�6'   $��26��6B   $��590,176,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��204��6�   �� 5#      -   5        $
 lblStatusName��5#      $�� ��6+   $
��Left=�66   $��839,352,0,0q�6Q   $	��Top=�6f   $	��204��6~   ���	#00000000���	#DDFF00006�   �� 5$      -   5        $
 lblPrice��5$      $��Price��6&   $
��Left=�66   $��517,226,0,0q�6Q   $	��Top=�6f   $��52��6~   �� 5%      -	   5        $ txtPrice��5%      $
��Left=�6(   $��26��6C   $��590,228,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��204��6�   �� 5&      -
   5        $
 lblStock��5&      $��Stock��6&   $
��Left=�66   $��517,272,0,0q�6Q   $	��Top=�6f   $��52��6~   �� 5'      -   5        $ txtStock��5'      $
��Left=�6(   $��26��6C   $��590,272,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��204��6�   �� 5(      -   5        $
 lblSupplier��5(      $��Supplier��6)   $
��Left=�6<   $��517,323,0,0q�6W   $	��Top=�6l   $��52��6�   �� 5)      -   5         ��Name$ 
Combo_item��5)      $
��Left=�6+   $��590,319,0,0q�6F   $	��Top=�6[   $	��204��6s   6�   �� 5*      -   5        $ 	BtnInsert��5*      $��Insert��6(   $
��Left=�69   $��859,275,0,0q�6T   $	��Top=�6i   $	��113��6�   ���	#FF116FA46�   �� 5+      -   5        $ 	BtnUpdate��5+      $��Update��6(   $
��Left=�69   $��859,222,0,0q�6T   $	��Top=�6i   $	��113��6�   ���	#FF116FA46�   �� 5,      -   5        $ 
BtnRefresh��5,      $��Refresh��6)   $
��Left=�6;   $��859,172,0,0q�6V   $	��Top=�6k   $	��113��6�   ���	#FF116FA46�   �� 5-      -   5        $
 	lblSearch��5-      $��Search��6'   $
��Left=�68   $��
571,92,0,0q�6S   $	��Top=�6g   $��52��6   �� 5.      -   5        $ 	txtSearch��5.      $
��Left=�6)   $��26��6D   $��
648,90,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��181��6�   �� 5/      -   5        $ 	BtnSearch��5/      $��Search��6(   $
��Left=�69   $��
859,88,0,0q�6T   $	��Top=�6h   $	��113��6�   ���	#FF116FA46�   50      51      52      