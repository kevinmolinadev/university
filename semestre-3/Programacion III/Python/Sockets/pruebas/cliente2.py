import pygame
import socket
import pickle
import threading

# Configuración del juego
WIDTH = 400
HEIGHT = 400
FPS = 30
LINE_WIDTH = 10
BOARD_SIZE = 3
SQUARE_SIZE = WIDTH // BOARD_SIZE

# Configuración de red
SERVER_IP = '192.168.56.1'  # Cambia esto con la dirección IP del servidor
SERVER_PORT = 8888

# Clase para manejar la conexión del cliente
class Client:
    def __init__(self):
        self.board = [[' ' for _ in range(BOARD_SIZE)] for _ in range(BOARD_SIZE)]
        self.turn = None
        self.game_over = False

        self.client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        try:
            self.client_socket.connect((SERVER_IP, SERVER_PORT))
        except socket.error as e:
            print(f"Error al conectar con el servidor: {e}")
            exit(1)

        self.receive_thread = threading.Thread(target=self.receive_board)
        self.receive_thread.start()

    def send_move(self, move):
        try:
            self.client_socket.sendall(pickle.dumps(move))
        except socket.error as e:
            print(f"Error al enviar el movimiento: {e}")

    def receive_board(self):
        while True:
            try:
                data = self.client_socket.recv(4096)
                if data:
                    self.board = pickle.loads(data)
                    if self.board == "GAME_OVER":
                        self.game_over = True
                        break
                    self.draw_board()
            except socket.error as e:
                print(f"Error al recibir el estado del tablero: {e}")
                break

    def draw_board(self, screen):
        screen.fill((0, 0, 0))
        draw_grid(screen)
        draw_pieces(screen)
        pygame.display.flip()

    def run_game(self):
        pygame.init()
        screen = pygame.display.set_mode((WIDTH, HEIGHT))
        clock = pygame.time.Clock()

        while not self.game_over:
            for event in pygame.event.get():
                if event.type == pygame.QUIT:
                    self.game_over = True
                elif event.type == pygame.MOUSEBUTTONDOWN and self.turn == 'X':
                    mouse_pos = pygame.mouse.get_pos()
                    col = mouse_pos[0] // SQUARE_SIZE
                    row = mouse_pos[1] // SQUARE_SIZE
                    if self.board[row][col] == ' ':
                        self.board[row][col] = 'X'
                        self.draw_board(screen)
                        self.send_move((row, col))

            clock.tick(FPS)

        pygame.quit()


# Función para dibujar la cuadrícula del tablero
def draw_grid(screen):
    for x in range(0, WIDTH, SQUARE_SIZE):
        pygame.draw.line(screen, (255, 255, 255), (x, 0), (x, HEIGHT), LINE_WIDTH)
    for y in range(0, HEIGHT, SQUARE_SIZE):
        pygame.draw.line(screen, (255, 255, 255), (0, y), (WIDTH, y), LINE_WIDTH)

# Función para dibujar las fichas
def draw_pieces(screen):
    for row in range(BOARD_SIZE):
        for col in range(BOARD_SIZE):
            x = col * SQUARE_SIZE + SQUARE_SIZE // 2
            y = row * SQUARE_SIZE + SQUARE_SIZE // 2
            if client.board[row][col] == 'X':
                pygame.draw.line(screen, (255, 0, 0), (x - SQUARE_SIZE // 4, y - SQUARE_SIZE // 4),
                                 (x + SQUARE_SIZE // 4, y + SQUARE_SIZE // 4), LINE_WIDTH)
                pygame.draw.line(screen, (255, 0, 0), (x + SQUARE_SIZE // 4, y - SQUARE_SIZE // 4),
                                 (x - SQUARE_SIZE // 4, y + SQUARE_SIZE // 4), LINE_WIDTH)
            elif client.board[row][col] == 'O':
                pygame.draw.circle(screen, (0, 0, 255), (x, y), SQUARE_SIZE // 4, LINE_WIDTH)


# Creación del cliente
client = Client()
client.run_game()
client.client_socket.close()
