   M S B A M L   `   `   `  ����R  NPracticoListasEnlazadas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:PracticoListasEnlazadasPracticoListasEnlazadas  5   	   (    "PracticoListasEnlazadas.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:PracticoListasEnlazadas     5   	     � Title$  
MainWindow��5   	   $	��800��6   $	��620��6)   .��5	      � 
�������.+�5
   
   �� -   5         ��Name$ 
ltbNombres��5
      $��10,45,339,87q�6Q   �� 5   
   $��Ingrese un nombre:��6   $
��Left=�6-   $��
315,30,0,0q�6H   $	��Top=�6\   $��25(�6t   �� 5   
   -   5         ��Name$ 
txtNombres��5      $
��Left=�6&   $��
324,96,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $��TextBox��6i   $	��Top=�6x   $	��252��6�   $��28��6�   $��15(�6�   �� 5   
   -   5         ��Name$ btnAgregarPrincipio��5      $��Agregar al principio��6.   $
��Left=�6M   $��324,140,0,0q�6h   $	��Top=�6}   $	��116��6�   6�   �� 5   
   -   5        $ btnAgregarFinal��5      $��Agregar al final��6*   $
��Left=�6E   $��324,184,0,0q�6`   $	��Top=�6u   $	��116��6�   6�   �� 5   
   -   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��331,262,0,0q�6N   $	��Top=�6c   $��18��6{   $��78��6�   �� 5   
   -   5        $ 	btnBuscar��5      $��Buscar��6$   $
��Left=�65   $��324,222,0,0q�6P   $	��Top=�6e   $��20��6}   $	��111��6�   6�   �� 5   
   -   5         ��Name$ lblResultadoBusqueda��5      $��	Resultado��6.   $
��Left=�6B   $��324,324,0,0q�6]   $	��Top=�6r   �� 5   
   -   5        $ btnEliminarPrimero��5      $��Eliminar Primero��6-   $
��Left=�6H   $��467,140,0,0q�6c   $	��Top=�6x   $	��109��6�   6�   �� 5   
   -	   5        $ btnEliminarUltimo��5      $��Eliminar Ultimo��6,   $
��Left=�6F   $��467,184,0,0q�6a   $	��Top=�6v   $	��109��6�   6�   �� 5   
   -
   5        $ numero��5   -   $
��Left=�6   $��333,392,0,0q�6=   $
 Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��190��6�   $��15(�6�   �� 5   
   $3��-Ingrese un nombre lista simplemente enlazada:��6   $
��Left=�6H   $��281,362,0,0q�6c   $	��Top=�6x   $��15(�6�   �� 5   
   -   5        $ Ainicio��5      $��Agregar Inicio��6"   $
��Left=�6;   $��331,440,0,0q�6V   $	��Top=�6k   $��15(�6�   $	��190��6�   6�   �� 5   
   -   5        $ Afinal��5      $��Agregar Final��6!   $
��Left=�69   $��331,483,0,0q�6T   $	��Top=�6i   $��15(�6�   $	��190��6�   6�   �� 5   
   -   5        $ Einicio��5      $��Eliminar Inicio��6"   $
��Left=�6<   $��333,528,0,0q�6W   $	��Top=�6l   $��15(�6�   $	��190��6�   6�   �� 5   
   -   5        $ Efinal��5      $��Eliminar Final��6!   $
��Left=�6:   $��332,565,0,0q�6U   $	��Top=�6j   $��15(�6�   $	��190��6�   6�   �� 5   
   -   5        $ Sumar��5      $��
Sumar todo��6    $
��Left=�65   $��331,594,0,0q�6P   $	��Top=�6e   $��15(�6}   $	��190��6�   6�   �� 5   
   -   5        $ Sumat��5      $�� ��6   $
��Left=�6*   $��
36,564,0,0q�6E   $	��Top=�6Y   $��2��6q   $	��195��6�   
�������6�   �� 5   
   -   5        $ 
btnOrdenar��5      $��Ordenar��6%   $
��Left=�67   $��467,240,0,0q�6R   $	��Top=�6g   $��35��6   $��67��6�   6�   5      5      