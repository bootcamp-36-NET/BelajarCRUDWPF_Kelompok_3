   M S B A M L   `   `   `  ����B  >CRUDWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CRUDWPFCRUDWPF  5   	       CRUDWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CRUDWPF     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��600��5
   	   $
��1000��6    � WindowStyle$
 None=�6#    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � 	Resources 5         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 70Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.5��6'   $ 70Q�69   5      5      5      	 � Triggers	 5      :� 5   
   
 :� RoutedEvent$
 ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $
 ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5      �� #��[ 6   5      .��5!      �  � ColumnDefinitions 5"   
   �� 5#      $
��481* �6   �� 5$      $
��513* �6   .+�5&   
   � -   5         �Name$ GridMain��5&      $��Right=�6!   $��Bottom=�6=   $	��540��6X   $
��1010��6e   $��2��6r   $��-17,0,0.334,0.333q�6�   � 5'   
   $��60��6   $	��Top=�6   ���	#FF5C99D6$��2��6J   $��0,0,0.334,0q�6^    J� Effect 5(      3  -System.Windows.Media.Effects.DropShadowEffect  5)         
BlurRadius$ 1Q�6#      ShadowDepth$ 1Q�62      Color$ 	#FFACACAC��6B   .+�57      �� $��Center=�6   $��Center=�65   $��22(�6P   ���#FFFFFFBelajar CRUD WPF6�   58      � 59   
   -   5        $ GridMenu��59      $��70��6!   $
��Left=�6,   ���	#FF31577E$��0,0,0,0.333q�6^    5:        5;      $ 2Q�6#   $ 1Q�62   $ 	#FFAEAEAE��6B   .+�5=      �� .+�5>      � $	��150��6   
������� J� RenderTransformOrigin$ 0.5,0.5&�67   z�5?      V� 5@      .~�5A      �� �� 5B      �� 5C      T� 5D      5E      .+�5G      �� -   5         ��Name$ ButtonOpenMenu��5G      $��60��65   $��60��6A   $��5q�6L   $��Right=�6W   $	��Top=�6s    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5H      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�62   $��25��6>   $��25��6I   5I      �� 5J      -   5        $ ButtonCloseMenu��5J      $y�	Collapsed=�66   $��60��6M   $��60��6Y   $��5q�6d   $��Right=�6o   $	��Top=�6�   #��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5K        $ 	ArrowLeft=�62   $��25��6C   $��25��6N   5L      �� 5N      $��80��6   $��Bottom=�6(   5O      �� 5P      -   5         ��Name$ ListViewMenu��5P      ���	#FF5C99D6$��Disabled=�6H   .@�5Q      �� -   5         ��Name$ ItemHome��5Q   #   $��60��65   .��5R      ��  �� Orientation$ 
Horizontal=�6%   .+�5S        $ ViewDashboard=�66   $��25��6K   $��25��6W   $��10q�6b   ���	#FFA4C6E96n   �� 5T      $
��Home��6(   $��Center=�64   $��20 10q�6O   ���	#FFD8E6F56^   5U      5V      �� 5W      -   5        $
 Item��5W   #   $��60��61   .��5X      �� $ 
Horizontal=�6%   .+�5Y        $ Pencil=�66   $��25��6D   $��25��6P   $��10q�6[   ���	#FFA4C6E96g   �� 5Z      $
��Item��6(   $��Center=�64   $��20 10q�6O   ���	#FFD8E6F56^   5[      5\      �� 5]      -   5        $ Supplier��5]   #   $��60��65   .��5^      �� $ 
Horizontal=�6%   .+�5_        $ Pencil=�66   $��25��6D   $��25��6P   $��10q�6[   ���	#FFA4C6E96g   �� 5`      $��Supplier��6(   $��Center=�68   $��20 10q�6S   ���	#FFD8E6F56b   5a      5b      �� 5c      -	   5        $ Transaction��5c   #   $��60��68   .��5d      �� $ 
Horizontal=�6%   .+�5e        $ Pencil=�66   $��25��6D   $��25��6P   $��10q�6[   ���	#FFA4C6E96g   �� 5f      $��Transaction��6(   $��Center=�6;   $��20 10q�6V   ���	#FFD8E6F56e   5g      5h      �� 5i      -
   5        $ TransactionItem��5i   #   $��60��6<   .��5j      �� $ 
Horizontal=�6%   .+�5k        $ Pencil=�66   $��25��6D   $��25��6P   $��10q�6[   ���	#FFA4C6E96g   �� 5l      $��Transaction Item��6(   $��Center=�6@   $��20 10q�6[   ���	#FFD8E6F56j   5m      5n      5o      5p      5q      5r      5s      