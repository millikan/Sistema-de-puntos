   M S B A M L   `   `   `  ����I  ECasitaDeMadera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CasitaDeMaderaCasitaDeMadera  5          CasitaDeMadera.Historial   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:CasitaDeMadera     5        N� Title$  	Historial��5	      .��5      � .+�5   
   �� $
��Left=�6   $��
272,10,0,0q�6/   $
��Wrap=�6C   $��	Historial��6W   $	��Top=�6h   $��36(�6�   $
��Bold"�6�   ���	#FF52330A6�   �� 5   
   $��Buscar usuario:��6   $
��Left=�6*   $��	46,64,0,0q�6E   $	��Top=�6X   $��18(�6p   $
��Bold"�6~   $��Arial)�6�   �� 5   
   -   5         ��Name$ Buscar��5      $
��Left=�6"   $��30��6=   $��
231,65,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��377��6�   $��14(�6�   6�   &   System.Windows.Controls.DataGrid  5   
   $
��Left=�6   $	��305��6.   $��
10,129,0,0q�6;   $	��Top=�6O   $	��680��6g   $   HorizontalScrollBarVisibility$ Visible=�6s   $��16(�6�   $
��Bold"�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre del cliente��6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   Z�    ClipboardContentBinding 68   Z� 6[     5      $ Número telefónico��6[    6%   Z�  68   Z� 6[     5      $ Puntos totales��6[    6%   Z�  68   Z� 6[     5      $ Tipo de cliente��6[    6%   Z�  68   Z� 6[     5      $ Ultima compra��6[    6%   Z�  68   Z� 6[     5      $ Ultima fecha de compra��6[    6%   Z�  68   Z� 6[     5      $ Observaciones��6[    6%   Z�  68   Z� 6[     5      $ Puntos canjeados��6[    6%   Z�  68   Z� 6[     5      $ ultima fecha de canjeo��6[    6%   Z�  68   Z� 6[   5      �� 5   
   -   5         ��Name$ EditUs��5      $��Editar usuario��6!   $
��Left=�6:   $��
10,466,0,0q�6U   $	��Top=�6i   $	��140��6�   $��30��6�   $��16(�6�   $��Arial)�6�   ���	#FFCCDBEF��5      �� 5      	 �� EndPoint$		 0,1&�6&   
 �� 
StartPoint$	
 0,0&�65   .��5      �  � Color$ 	#FFCCDBEF��6#    � Offset$ 0.881Q�65   � 5       $ 	#FF0464E6��6#   $ 1Q�65   5!      5#      �� 5$   
   -   5        $ 
EliminarUs��5$      $��Eliminar usuario��6%   $
��Left=�6@   $��192,466,0,0q�6[   $	��Top=�6p   $	��140��6�   $��30��6�    J� RenderTransformOrigin$ 1.704,0.273&�6�   $��16(�6�   $��Arial)�6�   ���	#FFCCDBEF��5%      �� 5&      $		 0,1&�6&   $	
 0,0&�65   .��5'      � $ 	#FFCCDBEF��6#   $ 0.881Q�65   � 5(      $ 	#FF0464E6��6#   $ 1Q�65   5)      5+      �� 5,   
   -   5        $ 
GuardarCam��5,      $��Guardar cambios��6%   $
��Left=�6?   $��369,466,0,0q�6Z   $	��Top=�6o   $	��140��6�   $��30��6�   $��16(�6�   $��Arial)�6�   ���	#FFCCDBEF��5-      �� 5.      $		 0,1&�6&   $	
 0,0&�65   .��5/      � $ 	#FFCCDBEF��6#   $ 0.881Q�65   � 50      $ 	#FF0464E6��6#   $ 1Q�65   51      53      �� 54   
   -   5        $ VerUs��54      $��Ver usuario��6    $
��Left=�66   $��550,466,0,0q�6Q   $	��Top=�6f   $	��140��6~   $��30��6�   $��16(�6�   $��Arial)�6�   ���	#FFCCDBEF��55      �� 56      $		 0,1&�6&   $	
 0,0&�65   .��57      � $ 	#FFCCDBEF��6#   $ 0.881Q�65   � 58      $ 	#FF0464E6��6#   $ 1Q�65   59      5;      5=      5>      