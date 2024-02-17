class Handler:
    def __init__(self):
        self.successor=None

    def set_successor(self, successor):
        self.successor=successor

    def handle_request(self, request):
        pass

class ConcreteHandler1(Handler):
    def handle_request(self, request):
        if 0 <= request <10:
            print(f"{self.__class__.__name__} Handled request {request}")
        elif self.successor is not None:
            self.successor.handle_request(request)

class ConcreteHandler2(Handler):
    def handle_request(self, request):
        if 10 <= request <20:
            print(f"{self.__class__.__name__} Handled request {request}")
        elif self.successor is not None:
            self.successor.handle_request(request)

class ConcreteHandler3(Handler):
    def handle_request(self, request):
        if 20 <= request <30:
            print(f"{self.__class__.__name__} Handled request {request}")
        elif self.successor is not None:
            self.successor.handle_request(request)


if __name__ == "__main__":
    h1=ConcreteHandler1()
    h2=ConcreteHandler2()
    h3=ConcreteHandler3()

    h1.set_successor(h2)
    h2.set_successor(h3)

    requests=[2,5,14,22,18,3,27,20]
    for request in requests:
        h1.handle_request(request)