   M S B A M L   `   `   `  ����B  >CRUDWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CRUDWPFCRUDWPF  5      !    CRUDWPF.UserControlSupplier   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:CRUDWPF     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � .+�5   
   � $��0,2,-253,-2q�6   $
��Left=�6$   $
��1053��6?   
�������.+�5      �� $��Supplier��6   $
��Left=�6'   $��
122,18,0,0q�6B   $	��Top=�6V   $��48(�6n   �� 5      -   5          ��Name$  Id��5      $��ID��6    $
��Left=�6-   $��517,187,0,0q�6H   $	��Top=�6]   �� 5      -   5        $
  nama��5      $
��Nama��6"   $
��Left=�61   $��517,225,0,0q�6L   $	��Top=�6a   �� 5      -   5         ��Name$ 	BtnInsert��5      $��Insert��6(   $
��Left=�69   $��867,303,0,0q�6T   $	��Top=�6i   $	��113��6�   ���	#FF116FA46�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dg_Supplier��5      $
��Left=�6,   $	��336��6G   $��	48,90,0,0q�6T   $	��Top=�6g   $	��366��6   "   VerticalScrollBarVisibility$ Visible=�6�      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� *Id+  5      $
 Nama��6)    5      �� *Name+  5      $ 	Join Date��6)    5      �� *
JoinDate+	 �� StringFormat$	 
dd/MM/yyyy��4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Action��6-   
   CellTemplate
 5      �� 5      .R�5   "   �� $ 	btnDelete��6)   -   5        .��5   &   '  !MaterialDesignThemes.Wpf.PackIcon  ���	#FFFFFAFC   Kind$ Trash=�6U   $��25��6b   $��25��6m   5   #   5      5!      5#      �� 5$      -   5        $  JoinDate��5$      $��	Join Date��6&   $
��Left=�6:   $��517,264,0,0q�6U   $	��Top=�6j   �� 5%      -   5         ��Name$ txt_ID��5%      $
��Left=�6&   $��23��6A   $��630,188,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��174��6�   {�.  6�   �� 5&      -   5        $ txt_Nama��5&      $
��Left=�6(   $��23��6C   $��629,226,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��175��6�   6�   �� 5'      -	   5        $ 	BtnUpdate��5'      $��Update��6(   $
��Left=�69   $��867,249,0,0q�6T   $	��Top=�6i   $	��113��6�   ���	#FF116FA46�   �� 5(      -
   5        $  	lblSearch��5(      $��Search��6'   $
��Left=�68   $��560,110,0,0q�6S   $	��Top=�6h   $��52��6�   �� 5)      -   5        $ 
Txt_Search��5)      $
��Left=�6*   $��32��6E   $��630,109,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��175��6�   6�   �� 5*      -   5        $ 	BtnSearch��5*      $��Search��6(   $
��Left=�69   $��853,110,0,0q�6T   $	��Top=�6i   $	��112��6�   ���	#FF116FA4 J� RenderTransformOrigin$ 
0.96,0.906&�6�   (  "System.Windows.Controls.DatePicker  5+      -   5        $��DatePicker1��5+   U   $��25��6   $
��Left=�6%   $��630,270,0,0q�6@   $	��Top=�6h   $	��124��6�   6�   �� 5,      -   5        $ 
BtnRefresh��5,      $��Refresh��6)   $
��Left=�6;   $��867,190,0,0q�6V   $	��Top=�6k   $	��113��6�   ���	#FF116FA46�   5-      5.      5/      