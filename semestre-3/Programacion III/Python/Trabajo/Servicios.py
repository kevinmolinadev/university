"USO DEL PATRON DECORATOR"
# CLASE BASE PARA LOS TIPOS DE PLANES 
class PlanBase:
    def __init__(self):
        self.internet = "30 Megas de velocidad"
        self.tv_cable = "100 Canales"

    def descripcion(self):
        return f"PLAN CONTRATADO\nTigo Hogar basico\nSERVICIOS CONTRATADOS\nInternet: {self.internet}\nTV: {self.tv_cable}"
    
    def costo(self):
        return 50

class ServiciosAdicionales(PlanBase):
    def __init__(self, servicio):
        self.servicio = servicio
        self.serviciosAdicionales = []
    
    def agregar_aplicacion(self, aplicacion):
        self.serviciosAdicionales.append(aplicacion)
    
    def mostrar_apliaciones(self):
        lista=""
        if(len(self.serviciosAdicionales)==0):
            lista="\nNo se contrataron servicios adicionales"
        else:
            for a in self.serviciosAdicionales:
                lista+=f"\n* {a}"
        return lista
    def descripcion(self):
        return f"{self.servicio.descripcion()}\nSERVICIOS ADICIONALES{self.mostrar_apliaciones()}"
    
    def costo(self):
        return self.servicio.costo() + (10 * len(self.serviciosAdicionales))
    
class PlanIntermedio(ServiciosAdicionales):
    def __init__(self, servicio: ServiciosAdicionales):
        self.servicio = servicio
        self.servicio.internet="50 Megas de velocidad"
        self.servicio.tv_cable = "200 canales"
    
    def descripcion(self):
        return f"PLAN CONTRATADO\nTigo Hogar Intermedio\nSERVICIOS CONTRATADOS\nInternet: {self.servicio.internet}\nTV: {self.servicio.tv_cable}"
    
    def costo(self):
        return self.servicio.costo() + 20

class PlanAvanzado(ServiciosAdicionales):
    def __init__(self, servicio: ServiciosAdicionales):
        self.servicio = servicio
        self.servicio.internet="100 Megas de velocidad"
        self.servicio.tv_cable = "300 canales"
    
    def descripcion(self):
        return f"PLAN CONTRATADO\nTigo Hogar Avanzado\nSERVICIOS CONTRATADOS\nInternet: {self.servicio.internet}\nTV: {self.servicio.tv_cable}"
    
    def costo(self):
        return self.servicio.costo() + 40

