import socket
import pickle
import threading

# Configuración de red
SERVER_IP = '192.168.56.1'  # Cambia esto con la dirección IP del servidor
SERVER_PORT = 8888
MAX_CONNECTIONS = 2

# Clase para manejar cada conexión de cliente
class ClientHandler(threading.Thread):
    def __init__(self, client_socket, player_id):
        threading.Thread.__init__(self)
        self.client_socket = client_socket
        self.player_id = player_id
        self.board = [[' ' for _ in range(3)] for _ in range(3)]
        self.turn = 'X' if player_id == 0 else 'O'

    def run(self):
        self.send_board()
        while True:
            move = self.receive_move()
            if move:
                row, col = move
                if self.board[row][col] == ' ' and self.turn == 'X' and self.check_valid_turn():
                    self.board[row][col] = self.turn
                    if self.check_winner():
                        print(f"¡Jugador {self.turn} ha ganado!")
                        self.send_board()
                        self.send_game_over()
                        break
                    elif self.check_draw():
                        print("¡Empate!")
                        self.send_board()
                        self.send_game_over()
                        break
                    self.send_board()
                    self.change_turn()

    def send_board(self):
        data = pickle.dumps(self.board)
        try:
            self.client_socket.sendall(data)
        except socket.error as e:
            print(f"Error al enviar el estado del tablero: {e}")

    def receive_move(self):
        try:
            data = self.client_socket.recv(4096)
            return pickle.loads(data)
        except socket.error as e:
            print(f"Error al recibir el movimiento: {e}")
            return None

    def send_game_over(self):
        try:
            self.client_socket.sendall(pickle.dumps("GAME_OVER"))
        except socket.error as e:
            print(f"Error al enviar el fin del juego: {e}")

    def check_valid_turn(self):
        for row in self.board:
            if row.count('X') > row.count('O'):
                return False
        return True

    def check_winner(self):
        for row in self.board:
            if row.count(row[0]) == len(row) and row[0] != ' ':
                return True
        for col in range(len(self.board[0])):
            if all(self.board[row][col] == self.board[0][col] and self.board[0][col] != ' ' for row in range(len(self.board))):
                return True
        if self.board[0][0] == self.board[1][1] == self.board[2][2] != ' ':
            return True
        if self.board[0][2] == self.board[1][1] == self.board[2][0] != ' ':
            return True
        return False

    def check_draw(self):
        return all(self.board[row][col] != ' ' for row in self.board for col in row)

    def change_turn(self):
        self.turn = 'O' if self.turn == 'X' else 'X'


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

    # Lista para almacenar las conexiones de los clientes
    client_handlers = []

    # Aceptación de las conexiones de los clientes
    for player_id in range(MAX_CONNECTIONS):
        client_socket, address = server_socket.accept()
        client_handler = ClientHandler(client_socket, player_id)
        client_handler.start()
        client_handlers.append(client_handler)
        print(f"Cliente conectado: {address}")

    # Esperar a que todos los hilos de los clientes terminen
    for client_handler in client_handlers:
        client_handler.join()

    # Cierre del socket servidor
    server_socket.close()

# Ejecución del servidor
run_server()
