# Clase Iterator que define la interfaz para acceder a los elementos de la colección
class Iterator:
    def __init__(self, collection):
        self.collection = collection
        self.index = 0

    def has_next(self):
        return self.index < len(self.collection)

    def next(self):
        if self.has_next():
            item = self.collection[self.index]
            self.index += 1
            return item
        else:
            return None

# Clase Aggregate que define la interfaz para crear un objeto de tipo Iterator
class Aggregate:
    def __init__(self):
        self.collection = []

    def add(self, item):
        self.collection.append(item)

    def iterator(self):
        return Iterator(self.collection)

aggregate = Aggregate()
aggregate.add("elemento 1")
aggregate.add("elemento 2")
aggregate.add("elemento 3")
iterator = aggregate.iterator()
while iterator.has_next():
    item = iterator.next()
    print(item)
#Salida 
""" elemento 1 """
""" elemento 2 """
""" elemento 3 """