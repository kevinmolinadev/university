from queue import PriorityQueue

class Proceso:
    def __init__(self, nombre, prioridad):
        self.nombre = nombre
        self.prioridad = prioridad
    
    def __lt__(self, otro):
        return self.prioridad < otro.prioridad

    def __str__(self):
        return self.nombre

cola_prioridad = PriorityQueue()

cola_prioridad.put(Proceso("Proceso A", 3))
cola_prioridad.put(Proceso("Proceso B", 1))
cola_prioridad.put(Proceso("Proceso C", 2))

while not cola_prioridad.empty():
    proceso_actual = cola_prioridad.get()
    print(f"Ejecutando proceso: {proceso_actual}")
