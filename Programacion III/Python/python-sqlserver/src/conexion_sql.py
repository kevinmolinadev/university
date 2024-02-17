import pyodbc

# Conexión a la base de datos
server = 'DESKTOP-30G6JTF' #En server debe poner el nombre de su servidor de datos de SQL Server
class SQL():
    def __init__(self):
        try:
            self.conexion = pyodbc.connect('Driver={SQL Server};'
                      'Server=' + server + ';'
                      'Database=concierto;'
                      'Trusted_Connection=yes;')
        except Exception as ex:
            print("Error al intentar la conexión: {0}".format(ex))

    def conciertos(self):
        if not self.conexion.closed:
            try:
                cursor = self.conexion.cursor()
                """ cursor.execute("SELECT * FROM Concierto ORDER BY nombre ASC") """
                cursor.execute("SELECT * FROM Concierto")
                resultados = cursor.fetchall()
                return resultados
            except Exception as ex:
                print("Error al intentar la conexión: {0}".format(ex))
        else:
            print("La conexión está cerrada")
           
    def ventas(self):
        if not self.conexion.closed:
            try:
                cursor = self.conexion.cursor()
                cursor.execute("SELECT Detalle_Compra_boleto.id,Cliente.nombre,Cliente.apellido,Boleto.tipo_boleto,Detalle_Compra_Boleto.metodo_pago,Boleto.precio_boleto,Detalle_Compra_Boleto.descuento,Detalle_Compra_Boleto.total,Concierto.nombre,Concierto.ubicacion FROM Detalle_Compra_Boleto,Cliente,Boleto,Concierto WHERE Detalle_Compra_Boleto.id_cliente=Cliente.id and Detalle_Compra_Boleto.id_boleto=Boleto.id and Detalle_Compra_Boleto.id_concierto=Concierto.id")
                resultados = cursor.fetchall()
                return resultados
            except Exception as ex:
                print("Error al intentar la conexión: {0}".format(ex))
        else:
            print("La conexión está cerrada")

    def agregarConcierto(self, concierto):
        if not self.conexion.closed:
            try:
                cursor = self.conexion.cursor()
                consulta= "INSERT INTO Concierto (nombre, capacidad_personas, ubicacion) VALUES ('{0}', {1}, '{2}')"
                cursor.execute(consulta.format(concierto[0],concierto[1],concierto[2]))
                self.conexion.commit()
                print("¡Concierto Agregado exitosamente!\n")
            except Exception as ex:
                print("Error al intentar la conexión: {0}".format(ex))
        else:
            print("La conexión está cerrada")

    def agregarCliente(self, cliente):
        if not self.conexion.closed:
            try:
                cursor = self.conexion.cursor()
                consultaCliente= "INSERT INTO Cliente (nombre, apellido, fecha_nacimiento) VALUES ('{0}', '{1}', '{2}')"
                cursor.execute(consultaCliente.format(cliente[0],cliente[1],cliente[2]))
                self.conexion.commit()
            except Exception as ex:
                print("Error al intentar la conexión: {0}".format(ex))
        else:
            print("La conexión está cerrada")
    
    def detalleVenta(self, detalle):
        if not self.conexion.closed:
            try:
                cursor = self.conexion.cursor()
                consultaDetalle= "INSERT INTO	Detalle_Compra_Boleto (fecha,metodo_pago,id_boleto,descuento,total,id_cliente,id_concierto) VALUES ('{0}','{1}',{2},{3},{4},{5},{6})"
                cursor.execute(consultaDetalle.format(detalle[0],detalle[1],detalle[2],detalle[3],detalle[4],detalle[5],detalle[6]))
                self.conexion.commit()
                print("¡Venta realizada exitosamente!\n")
            except Exception as ex:
                print("Error al intentar la conexión: {0}".format(ex))
        else:
            print("La conexión está cerrada")