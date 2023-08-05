import socket
import pickle

# Configuración de red
SERVER_IP = '192.168.56.1'  # Cambia esto con la dirección IP del servidor
SERVER_PORT = 8888 #8888
MAX_CONNECTIONS = 2

# Función para verificar si se ha alcanzado un estado de victoria
def check_winner(board):
    # Verificar filas
    for row in board:
        if row.count(row[0]) == len(row) and row[0] != ' ':
            return True

    # Verificar columnas
    for col in range(len(board[0])):
        if all(board[row][col] == board[0][col] and board[0][col] != ' ' for row in range(len(board))):
            return True

    # Verificar diagonales
    if board[0][0] == board[1][1] == board[2][2] != ' ':
        return True
    if board[0][2] == board[1][1] == board[2][0] != ' ':
        return True

    return False

# Función para enviar el estado actual del tablero a los clientes
def send_board(sockets, board):
    data = pickle.dumps(board)
    for socket in sockets:
        try:
            socket.sendall(data)
        except socket.error as e:
            print(f"Error al enviar el estado del tablero: {e}")

# Función principal del servidor
def run_server():
    # Creación del socket del servidor
    server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

    # Vinculación del socket del servidor a una dirección IP y puerto
    try:
        server_socket.bind((SERVER_IP, SERVER_PORT))
    except socket.error as e:
        print(f"Error al vincular el socket del servidor: {e}")
        exit(1)

    # Escucha de conexiones entrantes
    server_socket.listen(MAX_CONNECTIONS)
    print("Servidor en ejecución. Esperando conexiones...")

    # Aceptación de las conexiones de los clientes
    client_sockets = []
    for _ in range(MAX_CONNECTIONS):
        client_socket, address = server_socket.accept()
        client_sockets.append(client_socket)
        print(f"Cliente conectado: {address}")

    # Inicialización del tablero
    board = [[' ' for _ in range(3)] for _ in range(3)]

    # Bucle principal del juego
    game_over = False
    turn = 'X'
    while not game_over:
        for i, client_socket in enumerate(client_sockets):
            if turn == 'X' and i == 0:
                send_board(client_sockets, board)
                move = client_socket.recv(4096)
                row, col = pickle.loads(move)
                if board[row][col] == ' ':
                    board[row][col] = 'X'
                    if check_winner(board):
                        print("¡Jugador X ha ganado!")
                        game_over = True
                    elif all(board[row][col] != ' ' for row in board for col in row):
                        print("¡Empate!")
                        game_over = True
                    send_board(client_sockets, board)
                    turn = 'O'
            elif turn == 'O' and i == 1:
                send_board(client_sockets, board)
                move = client_socket.recv(4096)
                row, col = pickle.loads(move)
                if board[row][col] == ' ':
                    board[row][col] = 'O'
                    if check_winner(board):
                        print("¡Jugador O ha ganado!")
                        game_over = True
                    elif all(board[row][col] != ' ' for row in board for col in row):
                        print("¡Empate!")
                        game_over = True
                    send_board(client_sockets, board)
                    turn = 'X'

    # Cierre de los sockets cliente y servidor
    for client_socket in client_sockets:
        client_socket.close()
    server_socket.close()

# Ejecución del servidor
run_server()
