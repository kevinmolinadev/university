# Creamos la clase Mediator que define la interfaz para la comunicación entre objetos
class Mediator:
    def notify(self, sender, event):
        pass
    
# Creamos la clase ConcreteMediator que implementa la interfaz Mediator y gestiona la comunicación entre objetos
class ConcreteMediator(Mediator):
    def __init__(self):
        self.colleague1 = ConcreteColleague1(self)
        self.colleague2 = ConcreteColleague2(self)

    def notify(self, sender, event):
        if sender == self.colleague1:
            self.colleague2.handle_event(event)
        else:
            self.colleague1.handle_event(event)

# Creamos la clase Colleague que define la interfaz para los objetos que participimage.pngan en la comunicación a través del Mediator
class Colleague:
    def __init__(self, mediator):
        self.mediator = mediator

    def do_something(self):
        pass

    def handle_event(self, event):
        pass

# Creamos las clases ConcreteColleague  que implementa la interfaz Colleague y envía eventos al Mediator
class ConcreteColleague1(Colleague):
    def do_something(self):
        event = "Evento desde ConcreteColleague1"
        self.mediator.notify(self, event)

    def handle_event(self, event):
        print(f"ConcreteColleague1 maneja el evento: {event}")

class ConcreteColleague2(Colleague):
    def do_something(self):
        event = "Evento desde ConcreteColleague2"
        self.mediator.notify(self, event)

    def handle_event(self, event):
        print(f"ConcreteColleague2 maneja el evento: {event}")

# Creamos un objeto ConcreteMediator y lo utilizamos para comunicar dos objetos ConcreteColleague
mediator = ConcreteMediator()
mediator.colleague1.do_something()
mediator.colleague2.do_something()

#Salida 
""" ConcreteColleague2 maneja el evento: Evento desde ConcreteColleague1 """
""" ConcreteColleague1 maneja el evento: Evento desde ConcreteColleague2 """

