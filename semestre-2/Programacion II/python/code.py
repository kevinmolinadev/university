#Contar la cantidad de letras
#Kevin Molina
letras = { 
    'a':0,
    'b':0,
    'c':0,
    'd':0,
    'e':0,
    'f':0,
    'g':0,
    'h':0,
    'i':0,
    'j':0,
    'k':0,
    'l':0,
    'm':0,
    'n':0,
    'o':0,
    'p':0,
    'q':0,
    'r':0,
    's':0,
    't':0,
    'u':0,
    'v':0,
    'w':0,
    'x':0,
    'y':0,
    'z':0
}
archivo = "parrafo.txt"
with open(archivo,'r') as archivo_lectura:
    for linea in archivo_lectura:
        linea=linea.lower()
        for i in range(len(linea)):
            try:
                cantidad=letras.get(linea[i])
                letras.update({linea[i]:cantidad+1})
            except:
                continue
for letra,cantidad in letras.items():
    if cantidad == 0:
        continue
    else:
        print('Cantidad total de la letra '+letra + ' = '+ str(cantidad))
