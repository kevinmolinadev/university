# Creamos la clase Command que define la interfaz para todos los comandos
class Command:
    def execute(self):
        pass
        
# Creamos la clase Receiver que es responsable de llevar a cabo las acciones solicitadas por los comandos
class Receiver:
    def action(self):
        print("hola")

# Creamos las clases de comando concretas que implementan la interfaz Command
class ConcreteCommand(Command):
    def __init__(self, receiver):
        self.receiver = receiver

    def execute(self):
        self.receiver.action()

# Creamos la clase Invoker que es responsable de enviar los comandos
class Invoker:
    def set_command(self, command):
        self.command = command

    def execute_command(self):
        self.command.execute()

receiver = Receiver() # Creamos un objeto Receiver
command = ConcreteCommand(receiver) # Creamos un objeto ConcreteCommand, pasamos el objeto Receiver como argumento
invoker = Invoker() # Creamos un objeto Invoker 
invoker.set_command(command) # le asignamos el objeto ConcreteCommand
invoker.execute_command() # Ejecutamos el comando

#Salida 
""" hola """


