   M S B A M L   `   `   `  ����N  JEstructura de Datos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Estructura_de_Datos.Ventanas.NoLineales'Estructura_de_Datos.Ventanas.NoLineales  5   	   5    /Estructura_de_Datos.Ventanas.NoLineales.Arboles   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:Estructura_de_Datos.Ventanas.NoLineales     5   	     � Title$  Arboles��5   	   $	��600��6   $
��1000��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   $��0��6:   .+�5      �� $��Número de nodos:��6   $��0 0 10 0q�60   �� 5      -   5         ��Name$ NodeCountLabel��5      $��10��6,   �� 5      -   5         ��Name$ NodeCountSlider��5       � Minimum$ 1Q�6.    � Maximum$	 100Q�6:    � Value$ 10Q�6H    �� TickFrequency$ 1Q�6S   $	��150��6e   $��10 0 0 0q�6q   6�   5      �� 5   
   -   5        	 ��Name$	 GenerateTreeButton��5      $��Generar árbol aleatorio��6-   $��10q�6O   $��1��6[   $��Center=�6h   $��Bottom=�6�   6�   �� 5   
   -   5        
 ��Name$
 canvas��5      $��2��6!   $
��Auto��6.   5      5      