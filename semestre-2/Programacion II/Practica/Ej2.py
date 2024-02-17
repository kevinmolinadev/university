#Importamos las librerias necesarias
import pandas as pd #Panda nos ayudara para el ordenamiento 
import numpy as np  #Numpy nos ayudara para el ordenamiento  con excepciones 
#Archivo1
archivo = pd.read_csv("Practica/libro.csv")
print("-------LIBRO-------")
"""print('Ordenado')
print(archivo.sort_values(['A']))
print('Ordenado + indice') """
salida=pd.DataFrame(np.sort(archivo.values ,axis=0), index=archivo.index, columns=archivo.columns)
print(salida)
nuevo_archivo=open(f"libro_ordenado.csv",'w')
nuevo_archivo.write(str(salida))
nuevo_archivo.close()

#Archivo2
archivo2 = pd.read_csv("Practica/libro2.csv")
print("-------LIBRO2------")
"""print('Ordenado')
print(archivo2.sort_values(['D']))
print('Ordenado + indice') """
salida2=pd.DataFrame(np.sort(archivo2.values ,axis=0), index=archivo2.index, columns=archivo2.columns)
print(salida2)
nuevo_archivo2=open(f"libro2_ordenado.csv",'w')
nuevo_archivo2.write(str(salida2))
nuevo_archivo2.close()

#Archivo Unido
archivo_final=pd.concat([salida,salida2],ignore_index=True)
salida_final=pd.DataFrame(np.sort(archivo_final.values ,axis=0), index=archivo_final.index, columns=archivo_final.columns)
print('----LIBRO FINAL----')
print(salida_final)
nuevo_archivo_final=open(f"Libro_final.csv",'w')
nuevo_archivo_final.write(str(salida_final))
nuevo_archivo_final.close()




