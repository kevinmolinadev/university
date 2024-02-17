import socket

# Crear un objeto socket
cliente = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Obtener el nombre de host y el número de puerto del servidor
host = socket.gethostname()
puerto = 12345

# Conectar al servidor
cliente.connect((host, puerto))

while True:
    # Leer el mensaje desde la consola
    mensaje = input("Ingrese un mensaje ('x' para salir): ")

    # Enviar el mensaje al servidor
    cliente.send(mensaje.encode('utf-8'))

    if mensaje == 'x':
        break

    # Recibir la respuesta del servidor
    respuesta = cliente.recv(1024)
    print('Respuesta del servidor:', respuesta.decode('utf-8'))

# Cerrar la conexión con el servidor
cliente.close()
