from conexion_sql import SQL
import metodos

def menuPrincipal():
    continuar = True
    while(continuar):
        opcionCorrecta = False
        while(not opcionCorrecta):
            print("==================== MENÚ PRINCIPAL ====================")
            print("1 Conciertos Disponibles")
            print("2 Registro de ventas")
            print("3 Registrar un concierto")
            print("4 Vender boleto")
            print("5 Salir")
            print("========================================================")
            opcion = int(input("Seleccione una opción: "))

            if opcion < 1 or opcion > 5:
                print("Opción incorrecta, ingrese nuevamente...")
            elif opcion == 5:
                continuar = False
                print("¡Gracias por usar este sistema!")
                break
            else:
                opcionCorrecta = True
                ejecutarOpcion(opcion) 

def ejecutarOpcion(opcion):
    db = SQL()

    if opcion == 1:
        try:
            conciertos = db.conciertos()
            if len(conciertos) > 0:
                metodos.conciertos(conciertos)
            else:
                print("No hay conciertos disponibles")
        except Exception as ex:
            print("Ocurrió un error: {0}".format(ex))

    elif opcion==2:
        try:
            ventas=db.ventas()
            if len(ventas)> 0:
                metodos.ventas(ventas)
            else:
                print("No se realizo niguna venta")
        except Exception as ex:
            print("Ocurrió un error: {0}".format(ex))
    elif opcion==3:
        concierto=metodos.registroConcierto()
        try:
            db.agregarConcierto(concierto)
        except Exception as ex:
            print("Ocurrió un error: {0}".format(ex))
    elif opcion==4:
        venta=metodos.registroVenta()
        detalle=metodos.detalleRegistro()
        try:
            db.agregarCliente(venta)
            db.detalleVenta(detalle)
        except Exception as ex:
            print("Ocurrió un error: {0}".format(ex))

menuPrincipal()

