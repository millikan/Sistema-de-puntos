   M S B A M L   `   `   `  ����I  ECasitaDeMadera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CasitaDeMaderaCasitaDeMadera  5      !    CasitaDeMadera.CanjeoPuntos   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:CasitaDeMadera     5        N� Title$  CanjeoPuntos��5	      .��5      � .+�5   
   �� $
��Left=�6   $��
231,10,0,0q�6/   $
��Wrap=�6C   $��Canjera puntos��6W   $	��Top=�6m   $��36(�6�   $
��Bold"�6�   ���	#FF52330A6�   �� 5   
   $��Buscar usuario:��6   $
��Left=�6*   $��	46,64,0,0q�6E   $	��Top=�6X   $��18(�6p   $
��Bold"�6~   $��Arial)�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ TablaCanjeo��5      $
��Left=�6(   $	��306��6C   $��
46,123,0,0q�6P   $	��Top=�6d   $	��594��6|   $��16(�6�      AutoGenerateColumns .  $
��Bold"�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre del cliente��6@      FontSize$ 16Q�6\      Width5  /System.Windows.Controls.DataGridLengthConverter$	 280 6j   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Nombre+6j     5      $ Número telefónico��6@   $	 160 6[   $ 16Q�6g    6%   �� *Numero+6g     5      $ Puntos totales��6@   $	 150 6X   $ 16Q�6d    6%   �� *Puntos+6d   5      �� 5   
   -   5         ��Name$ CanjearPuntos��5      $��Canjea puntos��6(   $
��Left=�6@   $��251,459,0,0q�6[   $	��Top=�6p   $	��160��6�   	 J� RenderTransformOrigin$	 	1.6,0.818&�6�   $��30��6�   $��16(�6�   $��Arial)�6�   ���	#FFCCDBEF��5      �� 5      
 �� EndPoint$	
 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5      �  � Color$ 	#FFCCDBEF��6#    � Offset$ 0.881Q�65   � 5      $ 	#FF0464E6��6#   $ 1Q�65   5      5      �� 5   
   -   5         ��Name$ Buscar��5      $
��Left=�6"   $��30��6=   $��
231,65,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��377��6�   $��14(�6�   
���   �6�   5      5       