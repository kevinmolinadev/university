   M S B A M L   `   `   `  ����N  JEstructura de Datos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Estructura_de_Datos.Ventanas.Lineales%Estructura_de_Datos.Ventanas.Lineales  5   	   ;    5Estructura_de_Datos.Ventanas.Lineales.ListasEnlazadas   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:Estructura_de_Datos.Ventanas.Lineales     5   	     � Title$  ListasEnlazadas��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5
   
   �� $��85,124,392,0q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��
btnNumber1��5   %   $��1��6   $��50��6O   $��50��6Z   �� 5      -   5        $��
btnNumber2��5   %   $��2��6   $��50��6O   $��50��6Z   �� 5      -   5        $��
btnNumber3��5   %   $��3��6   $��50��6O   $��50��6Z   �� 5      -   5        $��	btnBlank0��5   $   $�� ��6   $��50��65   $��50��6@   ${�False��6L   �� 5      -   5        $��btnBackspace��5   *   $	��<- ��6   $��50��6Y   $��50��6d   �� 5      -   5        $��btnClear��5   &   $��AC��6   $��50��6M   $��50��6X   5      �� 5      $ 
Horizontal=�6   .+�5      �� -   5        $��
btnNumber4��5   %   $��4��6   $��50��6O   $��50��6Z   �� 5      -   5        $��
btnNumber5��5   %   $��5��6   $��50��6O   $��50��6Z   �� 5      -	   5        $��
btnNumber6��5   %   $��6��6   $��50��6O   $��50��6Z   �� 5      -
   5        $��btnCos��5   '   $	��cos��6   $��50��6G   $��50��6R   
 � Tag$ coseno��6^   �� 5      -   5        $��btnSin��5   '   $	��sin��6   $��50��6G   $��50��6R   $
 seno��6^   �� 5      -   5        $��btnLog��5   '   $	��log��6   $��50��6G   $��50��6R   $	 log��6^   5      �� 5      $ 
Horizontal=�6   .+�5      �� -   5        $��
btnNumber7��5   %   $��7��6   $��50��6O   $��50��6Z   �� 5      -   5        $��
btnNumber8��5   %   $��8��6   $��50��6O   $��50��6Z   �� 5      -   5        $��
btnNumber9��5   %   $��9��6   $��50��6O   $��50��6Z   �� 5      -   5        $��btnTan��5   '   $	��tan��6   $��50��6G   $��50��6R   $ tangent��6^   �� 5       -   5        $��btnMultiply��5    %   $��*��6   $��50��6J   $��50��6U   $ multiply��6a   �� 5!      -   5        $��	btnDivide��5!   %   $��/��6   $��50��6H   $��50��6S   $ divide��6_   5"      �� 5#      $ 
Horizontal=�6   .+�5$      �� -   5        $��btnBlank��5$   $   $�� ��6   $��50��64   $��50��6?   ${�False��6K   �� 5%      -   5        $��
btnNumber0��5%   %   $��0��6   $��50��6O   $��50��6Z   �� 5&      -   5        $��
btnDecimal��5&   $   $�� ��6   $��50��66   $��50��6A   ${�False��6M   �� 5'      -   5        $��btnPow��5'   %   $��^��6   $��50��6E   $��50��6P   $	 pow��6\   �� 5(      -   5        $��btnAdd��5(   %   $��+��6   $��50��6E   $��50��6P   $	 add��6\   �� 5)      -   5        $��btnSubtract��5)   %   $��-��6   $��50��6J   $��50��6U   $ subtract��6a   5*      �� 5+      $ 
Horizontal=�6   .+�5,      �� -   5        $��	btnBlank1��5,   $   $�� ��6   $��50��65   $��50��6@   ${�False��6L   �� 5-      -   5        $��	btnBlank2��5-   $   $�� ��6   $��50��65   $��50��6@   ${�False��6L   �� 5.      -   5        $��	btnBlank3��5.   $   $�� ��6   $��50��65   $��50��6@   ${�False��6L   �� 5/      -   5        $��btnFrac��5/   '   $	��1/x��6   $��50��6H   $��50��6S   $
 frac��6_   �� 50      -   5        $��btnSqrt��50   %   $	��√��6   $��50��6F   $��50��6Q   $
 sqrt��6]   �� 51      -   5        $��	btnEquals��51   %   $��=��6   $��50��6O   $��50��6Z   $ equals��6f   52      53      �� 55   
   -   5        $��
txtDisplay��55      $��50��6$   $��85,35,458,349q�60    �� 
IsReadOnly$
 True��6l   �� 56   
   $��CALCULADORA��6   $
��Left=�6&   $��99��6A   $��
368,25,0,0q�6M   $	��Top=�6a   $	��424��6y   $��60(�6�   �� 57   
   $	��CON��6   $
��Left=�6   $��99��69   $��506,129,0,0q�6E   $	��Top=�6Z   $	��130��6r   $��60(�6~    J� RenderTransformOrigin$ 0.469,0.505&�6�   �� 58   
   $��LISTAS��6   $
��Left=�6!   $��99��6<   $��479,221,0,0q�6H   $	��Top=�6]   $	��184��6u   $��60(�6�   �� 59   
   $��	ENLAZADAS��6   $
��Left=�6$   $��99��6?   $��408,306,0,0q�6K   $	��Top=�6`   $	��344��6x   $��60(�6�   5:      5<      