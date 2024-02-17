import socket

# Crear un socket de flujo (TCP)
socket_servidor = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Vincular el socket al puerto 8000 y escuchar las solicitudes entrantes
socket_servidor.bind(('localhost', 8000))
socket_servidor.listen(1)

# Aceptar una conexión entrante
socket_cliente, direccion_cliente = socket_servidor.accept()

# Recibir datos del cliente
datos = socket_cliente.recv(1024)

# Enviar una respuesta al cliente
socket_cliente.sendall(b'Hola, mundo!')

# Cerrar la conexión
socket_cliente.close()
