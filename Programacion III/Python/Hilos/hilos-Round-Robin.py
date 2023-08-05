class Process:
    def __init__(self, id, arrival_time, burst_time):
        self.id = id
        self.arrival_time = arrival_time
        self.burst_time = burst_time
        self.remaining_time = burst_time

    def execute(self, quantum):
        if self.remaining_time <= quantum:
            time = self.remaining_time
            self.remaining_time = 0
        else:
            time = quantum
            self.remaining_time -= quantum
        return time

def round_robin(processes, quantum):
    time = 0
    queue = []
    print("\nPROCESOS\n")
    print("Proceso\t  Tiempo de ejecucion")
    for p in processes:
        queue.append(p)
        print(f"{p.id}\t  {p.burst_time}")
    print("\nEJECUCION\n")
    print("Proceso\t  Tiempo de ejecucion\tTiempo de respuesta")
    while queue:
        p = queue.pop(0)
        if p.remaining_time <= quantum:
            time += p.execute(p.remaining_time)
            print(f"{p.id}\t  {p.burst_time}\t\t\t{time}")
        else:
            time += p.execute(quantum)
            queue.append(p)
    return time

processes = [    
    Process(1, 0, 5),    
    Process(2, 1, 2),
    Process(3, 1, 10)
]
quantum = 2
total_time = round_robin(processes, quantum)
print("Tiempo total:", total_time)
