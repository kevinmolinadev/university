import re
import datetime
from conexion_sql import SQL
db=SQL()

def conciertos(concierto):
    print("\nCONCIERTOS DISPONIBLES: \n")
    contador = 1
    for c in concierto:
        datos = "Código:{0} | Nombre:{1}    Capacidad Personas:{2}    Ubicacion:{3}"
        print(str(contador) + ". " + datos.format(c[0], c[1], c[2], c[3]))
        contador = contador + 1
    print(" ")

def ventas(venta):
    numeroVentas=len(db.ventas())
    print("\nVENTAS TOTALES:"+str(numeroVentas)+"\n")
    contador = 1
    for v in venta:
        datos = "Código:{0} | Nombre:{1}    Apellido:{2}    Boleto:{3}    Metodo de Pago:{4}    Precio Boleto:${5}    Descuento:${6}    Total:${7}    Nombre Concierto:{8}    Ubicacion:{9}"
        print(str(contador) + ". " + datos.format(v[0], v[1], v[2], v[3],v[4],v[5],v[6],v[7],v[8],v[9]))
        contador = contador + 1
    print(" ")

def registroConcierto():
    nombre=input("Ingrese el nombre del concierto: ")
    while nombre is None or nombre =="":
        print("Campo obligatorio")
        nombre=input("Ingrese el nombre del concierto: ")
    validadr_cpersonas=False
    while (not validadr_cpersonas):
        cPersonas=input("Ingrese la cantidad maxima de personas que soporat el concierto: ")
        if cPersonas.isnumeric():
            validadr_cpersonas=True
            cPersonas=int(cPersonas)
        else:
            print("Ingrese numeros enteros")

    ubicacion=input("Ingrese la ubicacion del concierto: ")
    while ubicacion is None or ubicacion =="":
        print("Campo obligatorio")
        ubicacion=input("Ingrese la ubicacion del concierto: ")

    newConcierto=(nombre,cPersonas,ubicacion)
    return newConcierto

def registroVenta():
    nombre=input("Nombre: ")
    while nombre is None or nombre =="":
        print("Campo obligatorio")
        nombre=input("Nombre: ")

    apellido=input("Apellido: ")
    while apellido is None or apellido =="":
        print("Campo obligatorio")
        apellido=input("Apellido: ")

    fecha_nacimiento = input("Ingrese la fecha de nacimiento en formato YYYY-MM-DD: ")
    while not re.match(r'^\d{4}-\d{2}-\d{2}$', fecha_nacimiento):
        print("El formato de fecha es incorrecto. Por favor ingrese la fecha en el formato correcto.")
        fecha_nacimiento = input("Ingrese la fecha de nacimiento en formato YYYY-MM-DD: ")

    newVenta=(nombre,apellido,fecha_nacimiento)
    return newVenta


def detalleRegistro():
    numeroConciertos=len(db.conciertos())

    metodo = input("Ingrese el metodo de pago: ")
    while metodo is None or metodo =="":
        print("Campo obligatorio")
        metodo = input("Ingrese el metodo de pago: ")

    precio=0
    opcionCorrecta = False
    while(not opcionCorrecta):
        print("Tipo Boleto")
        print("   1. Vip $100")
        print("   2. Estandar $50")
        print("   3. Bronce $25")
        boleto=int(input("Ingrese una opcion: "))
        if boleto==1:
            precio=100
            opcionCorrecta=True
        elif boleto==2:
            precio=50
            opcionCorrecta=True
        elif boleto==3:
            precio=25
            opcionCorrecta=True
        else:
            print("Opción incorrecta, ingrese nuevamente")
    print("El descuento maximo que se puede ingresar en 10$")
    descuento = int(input("Descuento: "))
    while descuento < 0 or descuento > 10:
        print("El descuento debe ser mayor 0  y menor a 10")
        descuento = int(input("Descuento: ")) 
    total=precio-descuento

    valido = False
    while(not valido):
        conciertos(db.conciertos())
        id_concierto=int(input("Ingrese el codigo del concierto: "))
        if id_concierto < 1 or id_concierto > numeroConciertos or id_concierto==False:
            print("Opción incorrecta, ingrese nuevamente")
        else:
            valido=True
            
    numeroVentas=len(db.ventas())
    id_usuario=numeroVentas+1
    fecha_venta = datetime.date.today()
    newRegistro=(fecha_venta,metodo,boleto,descuento,total,id_usuario,id_concierto)
    return newRegistro

            