class Login:
    __instance = None

    def __init__(self):
        if Login.__instance != None:
            raise Exception("Instancia Creada")
        else:
            Login.__instance = self
        self.datos="admin"

    @staticmethod
    def getInstance():
        if Login.__instance == None:
            Login()
        return Login.__instance

    def autenticar(self, usuario, contrasena):
        info = self.datos
        if usuario != info or contrasena != info:
            return False
        return True
