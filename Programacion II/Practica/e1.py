with open(f"Practica/text.fasta",'r') as archivo:
    for i in archivo:
        for j in archivo:
            nuevo=open(f"hola.fasta",'w')
            nuevo.write(str(j))
            nuevo.close()
            print(j)
