class Cliente:
     def __init__(self, nombre,apellido,CI):
          self.nombre=nombre
          self.apellido=apellido
          self.CI=CI

     def descripcionCliente(self):
          return f"INFORMACION PERSONAL\nNombre: {self.nombre}\nApellidos: {self.apellido}\nCI: {self.CI}"
     