import threading
import concurrent.futures
import time
import random
print('EJERCICIO 3')
def worker(n):
    print(f'Tarea {n} comienza a procesar')
    time.sleep(2)
    print(f'Tarea {n} Ha completado')
    return n
with concurrent.futures.ThreadPoolExecutor(max_workers=5) as executor:
    tareas=[executor.submit(worker, i) for i in range(10)]
    for tarea in concurrent.futures.as_completed(tareas):
        resultado=tarea.result()
        print(f'Resultado de la tarea {resultado}')
print('Todas las tareas han sido completadas')

