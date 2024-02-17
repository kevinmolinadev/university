import socket
import threading

clientes = []

# Función para manejar la conexión de un cliente
def manejar_cliente(cliente, direccion):
    print('Conexión establecida desde:', direccion)
    i=0
    while True:
        # Recibir datos del cliente
        datos = cliente.recv(1024)
        mensaje = datos.decode('utf-8')

        if mensaje == 'x':
            print(f"El cliente cerro la conexion")
            break

        # Enviar el mensaje a todos los otros clientes
        enviar_a_todos(mensaje, cliente)

    # Cerrar la conexión con el cliente
    cliente.close()
    clientes.remove(cliente)

# Función para enviar un mensaje a todos los clientes excepto al remitente
def enviar_a_todos(mensaje, remitente):
    for cliente in clientes:
        if cliente != remitente:
            cliente.send(mensaje.encode('utf-8'))

# Crear un objeto socket
servidor = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Obtener el nombre de host y el número de puerto
host = socket.gethostname()
puerto = 12345

# Enlazar el socket al host y al puerto
servidor.bind((host, puerto))

# Esperar por conexiones entrantes
servidor.listen(5)
print('Servidor escuchando en', host, ':', puerto)

while True:
    # Aceptar una conexión entrante
    cliente, direccion = servidor.accept()
    clientes.append(cliente)

    # Iniciar un hilo para manejar la conexión del cliente
    cliente_thread = threading.Thread(target=manejar_cliente, args=(cliente, direccion))
    cliente_thread.start()
