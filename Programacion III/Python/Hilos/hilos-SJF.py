import heapq
class Hilo:
    def __init__(self, id,arrival_time, burst_time):
        self.id = id
        self.arrival_time = arrival_time
        self.burst_time = burst_time

    def __lt__(self, other):
        return self.burst_time < other.burst_time

    def __repr__(self):
        return self.id

def sjf_no_expropiativo(hilos):
    hilos_ordenados = []
    tiempo_transcurrido = 0
    tiempo_espera_total = 0
    print("Proceso\t  Tiempo de ejecucion\tTiempo de espera\tTiempo de respuesta")
    while hilos or hilos_ordenados:
        while hilos and hilos[0].burst_time >= tiempo_transcurrido:
            hilo = heapq.heappop(hilos)
            heapq.heappush(hilos_ordenados, hilo)
        if hilos_ordenados:
            hilo_actual = heapq.heappop(hilos_ordenados)
            tiempo_transcurrido += hilo_actual.burst_time
            print(f"{hilo_actual.id}\t  {hilo_actual.burst_time}\t\t\t{tiempo_espera_total}\t\t\t{tiempo_transcurrido}")
            tiempo_espera_total += hilo_actual.burst_time
    return tiempo_transcurrido
hilos = [
    Hilo(1, 0, 10),    
    Hilo(2, 1, 5),
    Hilo(3, 2, 7),    
    Hilo(4, 3, 12),    
    Hilo(5, 4, 3)
]
print('Tiempo total: ', sjf_no_expropiativo(hilos))
