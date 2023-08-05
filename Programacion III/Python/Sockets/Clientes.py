import pygame
import socket
import pickle

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

# Inicialización de Pygame
pygame.init()
screen = pygame.display.set_mode((WIDTH, HEIGHT))
clock = pygame.time.Clock()

# Función para dibujar la cuadrícula del tablero
def draw_grid():
    for x in range(0, WIDTH, SQUARE_SIZE):
        pygame.draw.line(screen, (255, 255, 255), (x, 0), (x, HEIGHT), LINE_WIDTH)
    for y in range(0, HEIGHT, SQUARE_SIZE):
        pygame.draw.line(screen, (255, 255, 255), (0, y), (WIDTH, y), LINE_WIDTH)

# Función para dibujar las fichas
def draw_pieces(board):
    for row in range(BOARD_SIZE):
        for col in range(BOARD_SIZE):
            x = col * SQUARE_SIZE + SQUARE_SIZE // 2
            y = row * SQUARE_SIZE + SQUARE_SIZE // 2
            if board[row][col] == 'X':
                pygame.draw.line(screen, (255, 0, 0), (x - SQUARE_SIZE // 4, y - SQUARE_SIZE // 4),
                                 (x + SQUARE_SIZE // 4, y + SQUARE_SIZE // 4), LINE_WIDTH)
                pygame.draw.line(screen, (255, 0, 0), (x + SQUARE_SIZE // 4, y - SQUARE_SIZE // 4),
                                 (x - SQUARE_SIZE // 4, y + SQUARE_SIZE // 4), LINE_WIDTH)
            elif board[row][col] == 'O':
                pygame.draw.circle(screen, (0, 0, 255), (x, y), SQUARE_SIZE // 4, LINE_WIDTH)

# Función para enviar el movimiento al servidor
def send_move(move):
    try:
        client_socket.sendall(pickle.dumps(move))
    except socket.error as e:
        print(f"Error al enviar el movimiento: {e}")
        return False
    return True

# Función para recibir el estado actual del tablero desde el servidor
def receive_board():
    try:
        data = client_socket.recv(4096)
        return pickle.loads(data)
    except socket.error as e:
        print(f"Error al recibir el estado del tablero: {e}")
        return None

# Función principal del juego
def game():
    game_over = False
    turn = 'X'
    board = [[' ' for _ in range(BOARD_SIZE)] for _ in range(BOARD_SIZE)]

    while not game_over:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                game_over = True
            elif event.type == pygame.MOUSEBUTTONDOWN:
                if turn == 'X':
                    mouse_pos = pygame.mouse.get_pos()
                    col = mouse_pos[0] // SQUARE_SIZE
                    row = mouse_pos[1] // SQUARE_SIZE
                    if board[row][col] == ' ':
                        board[row][col] = 'X'
                        draw_pieces(board)
                        pygame.display.flip()
                        send_move((row, col))
                        turn = 'O'
                        board = receive_board()
                        if not board:
                            game_over = True
                        draw_grid()
                        draw_pieces(board)
                        pygame.display.flip()

        screen.fill((0, 0, 0))
        draw_grid()
        draw_pieces(board)
        pygame.display.flip()
        clock.tick(FPS)

    pygame.quit()

# Creación del socket cliente
client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Conexión al servidor
try:
    client_socket.connect((SERVER_IP, SERVER_PORT))
except socket.error as e:
    print(f"Error al conectar con el servidor: {e}")
    exit(1)

# Ejecución del juego
game()

# Cierre del socket cliente
client_socket.close()
