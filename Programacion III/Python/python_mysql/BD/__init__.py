valido = False
while(not valido):
    id_concierto=int(input("Ingrese el codigo del concierto: "))
    if id_concierto < 1 or id_concierto > 3:
        print("Opción incorrecta, ingrese nuevamente...")
    else:
        valido=True
print(id_concierto)