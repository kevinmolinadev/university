def Burbuja(miarray):
    length=len(miarray)-1
    for i in range (0,length):
        for j in range (0,length):
            if miarray[j]>miarray[j+1]:
                temp=miarray[j]
                miarray[j]=miarray[j+1]
                miarray[j+1]=temp
    return miarray

with open(f"Practica/libroej3.csv",'r') as miarray1:
    next(miarray1)
    for new in miarray1:
        new=new.rstrip("\n")
        nuevo=[new]
        salida=[]
        for i in nuevo :
            for j in range(0,len(i),2):
                    salida.append(i[j]) 
            for i in range(len(salida)):
                salida[i] = int(salida[i])       
        print('Sin ordenar\n',salida)
        print('Ordenado\n',Burbuja(salida))