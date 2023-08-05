def generar_primos(n):
    """
    Genera los n primeros números primos
    """
    primos = []
    num = 2
    while len(primos) < n:
        es_primo = True
        for i in range(2, int(num**(1/2))+1):
            if num % i == 0:
                es_primo = False
                break
        if es_primo:
            primos.append(num)
        num += 1
    return primos

# Ejemplo de uso
indice = int(input("Ingrese el indice: "))
primos = generar_primos(indice)
print(f"Los primeros {indice} números primos son: {primos}")

