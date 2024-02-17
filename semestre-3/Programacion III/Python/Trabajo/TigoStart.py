import Servicios
import Login
import Cliente
import tkinter as tk
from tkinter import messagebox

class InterfazCliente:
    def __init__(self, master):
        self.master = master
        self.bg_color="#F1C40F"
        self.widgetsApp=[]
        self.crearInterfaz(self.master)

    def crearInterfaz(self, master):
        master.title("TigoStart")
        master.geometry("800x500")
        master.configure(bg=self.bg_color)
        titulo = tk.Label(master, text="Tigo Start", font=("Calibri", 30), bg=self.bg_color)
        titulo.pack()
        self.login(master)

    def login(self, master):
        self.datos="admin"
        self.widgets = []
        self.loginTitle = tk.Label(master, text="LOGIN", font=("Calibri", 25), bg=self.bg_color)
        self.loginTitle.pack()
        self.login_label = tk.Label(master, text="Usuario:", bg=self.bg_color,font=("Calibri", 12))
        self.login_label.place(x=260, y=180)
        self.login_entry = tk.Entry(master,font=("Calibri", 12))
        self.login_entry.place(x=360, y=180)
        self.password_label = tk.Label(master, text="Contraseña:", bg=self.bg_color,font=("Calibri", 12))
        self.password_label.place(x=260, y=230)
        self.password_entry = tk.Entry(master,font=("Calibri", 12),show="*")
        self.password_entry.place(x=360, y=230)
        self.login_button = tk.Button(master, text="ENTRAR", command=self.login_datos, width=20, font=("Calibri", 12))
        self.login_button.place(x=350, y=280)
        #self.Mensaje_label = tk.Label(master, text=f"Usuario:{self.datos}\nContraseña: {self.datos}", bg=self.bg_color,font=("Calibri", 12),justify="left")
        #self.Mensaje_label.place(x=50, y=420)

        self.widgets.append(self.loginTitle)
        self.widgets.append(self.login_label)
        self.widgets.append(self.login_entry)
        self.widgets.append(self.password_label)
        self.widgets.append(self.password_entry)
        self.widgets.append(self.login_button)

    def login_datos(self):
        username = self.login_entry.get()
        password = self.password_entry.get()
        if not username or not password:
            messagebox.showerror("Error", "Debe completar ambos campos.")
            return
        LOGIN=Login.Login()
        login = LOGIN.getInstance()
        if not login.autenticar(username, password):
            messagebox.showerror("Error", "Datos Incorectos.")
            self.login_entry.delete(0, tk.END)
            self.password_entry.delete(0, tk.END)
            return
        for widget in self.widgets:
            widget.destroy()
        master=self.master
        self.registroCliente(master)
        self.planes(master)
        self.serviciosAdicionales(master)
        self.botones(master)
        self.salida()

    
    def cerrar_login(self):
        for widget in self.widgetsApp:
            widget.destroy()
        self.login(self.master)

    def registroCliente(self, master):
        self.Seccion = tk.Label(master, text="Registro De Cliente", font=("Calibri", 20), bg=self.bg_color)
        self.Seccion.place(x=50, y=50)
        self.nombre_label = tk.Label(master, text="Nombre:" ,bg=self.bg_color)
        self.nombre_label.place(x=50, y=100)
        self.nombre_entry = tk.Entry(master)
        self.nombre_entry.place(x=150, y=100)
        self.apellido_label = tk.Label(master, text="Apellido:",bg=self.bg_color)
        self.apellido_label.place(x=50, y=125)
        self.apellido_entry = tk.Entry(master)
        self.apellido_entry.place(x=150, y=125)
        self.ci_label = tk.Label(master, text="CI:",bg=self.bg_color)
        self.ci_label.place(x=50, y=150)
        self.ci_entry = tk.Entry(master)
        self.ci_entry.place(x=150, y=150)
        #Verificamos las entradas
        self.nombre_entry.insert(0, "")
        self.nombre_entry.bind("<KeyRelease>", self.verificar_entry)
        self.apellido_entry.insert(0, "")
        self.apellido_entry.bind("<KeyRelease>", self.verificar_entry)
        self.ci_entry.insert(0, "")
        self.ci_entry.bind("<KeyRelease>", self.verificar_entry)

        self.widgetsApp.append(self.Seccion)
        self.widgetsApp.append(self.nombre_entry)
        self.widgetsApp.append(self.nombre_label)
        self.widgetsApp.append(self.apellido_entry)
        self.widgetsApp.append(self.apellido_label)
        self.widgetsApp.append(self.ci_entry)
        self.widgetsApp.append(self.ci_label)

    def planes(self, master ):
        self.Plan = tk.Label(master, text="Planes Disponibles:",font=("Calibri", 20),bg=self.bg_color)
        self.Plan.place(x=300, y=50)
        self.servicio_seleccionado = tk.StringVar()
        self.basico_button = tk.Radiobutton(master, text="Plan Básico", variable=self.servicio_seleccionado, value="basico",bg=self.bg_color)
        self.basico_button.place(x=300, y=100)
        self.intermedio_button = tk.Radiobutton(master, text="Plan Intermedio", variable=self.servicio_seleccionado, value="intermedio",bg=self.bg_color)
        self.intermedio_button.place(x=300, y=125)
        self.avanzado_button = tk.Radiobutton(master, text="Plan Avanzado", variable=self.servicio_seleccionado, value="avanzado",bg=self.bg_color)
        self.avanzado_button.place(x=300, y=150)
        self.costoslabel = tk.Label(master, text="COSTOS:\nPlan Hogar basico = $50\nPlan Hogar intermedio = $70\nPlan Hogar avanzado = $90\nLos servicios adicionales tienen un costo de $10 por servicio adicionado",font=("Calibri", 10),bg=self.bg_color,justify="left", anchor="w" )
        self.costoslabel.place(x=25, y=400)

        self.widgetsApp.append(self.Plan)
        self.widgetsApp.append(self.basico_button)
        self.widgetsApp.append(self.intermedio_button)
        self.widgetsApp.append(self.avanzado_button)
        self.widgetsApp.append(self.costoslabel)

    def serviciosAdicionales(self, master):
        self.servicios_adicionales_label = tk.Label(master, text="Servicios Adicionales:",font=("Calibri", 20),bg=self.bg_color)
        self.servicios_adicionales_label.place(x=540, y=50)
        self.servicio1_checked = tk.BooleanVar()
        self.servicio2_checked = tk.BooleanVar()
        self.servicio3_checked = tk.BooleanVar()
        self.servicio4_checked = tk.BooleanVar()
        self.servicio5_checked = tk.BooleanVar()
        self.servicio1_checkbutton = tk.Checkbutton(master, text="Amazon", bg=self.bg_color, variable=self.servicio1_checked)
        self.servicio1_checkbutton.place(x=540, y=100)
        self.servicio2_checkbutton = tk.Checkbutton(master, text="Hbo Max", bg=self.bg_color, variable=self.servicio2_checked)
        self.servicio2_checkbutton.place(x=540, y=125)
        self.servicio3_checkbutton = tk.Checkbutton(master, text="Netflix", bg=self.bg_color, variable=self.servicio3_checked)
        self.servicio3_checkbutton.place(x=540, y=150)
        self.servicio4_checkbutton = tk.Checkbutton(master, text="Nextory", bg=self.bg_color, variable=self.servicio4_checked)
        self.servicio4_checkbutton.place(x=540, y=175)
        self.servicio5_checkbutton = tk.Checkbutton(master, text="Sekiro GOTY", bg=self.bg_color, variable=self.servicio5_checked)
        self.servicio5_checkbutton.place(x=540, y=200)

        self.widgetsApp.append(self.servicios_adicionales_label)
        self.widgetsApp.append(self.servicio1_checkbutton)
        self.widgetsApp.append(self.servicio2_checkbutton)
        self.widgetsApp.append(self.servicio3_checkbutton)
        self.widgetsApp.append(self.servicio4_checkbutton)
        self.widgetsApp.append(self.servicio5_checkbutton)

    def guardar_servicios(self, plan):
        servicios = Servicios.ServiciosAdicionales(plan)
        if self.servicio1_checked.get():
            servicios.agregar_aplicacion("Amazon")
        if self.servicio2_checked.get():
            servicios.agregar_aplicacion("Hbo Max")
        if self.servicio3_checked.get():
            servicios.agregar_aplicacion("Netflix")
        if self.servicio4_checked.get():
            servicios.agregar_aplicacion("Nextory")
        if self.servicio5_checked.get():
            servicios.agregar_aplicacion("Sekiro GOTY")
        self.info_plan=servicios.descripcion()
        self.info_costo=f"Costo Total: ${servicios.costo()}"

    def botones(self, master):
        self.guardar_button = tk.Button(master, text="Guardar", command=self.guardar_datos, width=20,font=("Calibri", 12),state="disabled")
        self.guardar_button.place(x=100, y=190)
        self.mostrar_button = tk.Button(master, text="Mostrar Informacion", command=self.mostrar_datos, width=20,font=("Calibri", 12),state="disabled")
        self.mostrar_button.place(x=300, y=190)
        self.cerrar_button = tk.Button(master, text="Cerrar Sesion", command=self.cerrar_login, width=20,font=("Calibri", 12))
        self.cerrar_button.place(x=600, y=440)
        self.widgetsApp.append(self.guardar_button)
        self.widgetsApp.append(self.mostrar_button)
        self.widgetsApp.append(self.cerrar_button)

    def salida(self):
        self.info_cliente=""
        self.info_costo=""
        self.info_plan=""
        self.Informacion_cliente = tk.Label(self.master, text="", font=("Calibri", 10), bg=self.bg_color, justify="left", anchor="w")
        self.Informacion_cliente.place(x=180, y=250)
        self.Informacion_costo = tk.Label(self.master, text="", font=("Calibri", 12), bg=self.bg_color, justify="left", anchor="w")
        self.Informacion_costo.place(x=180, y=320)
        self.Informacion_plan = tk.Label(self.master, text="", font=("Calibri", 10), bg=self.bg_color, justify="left", anchor="w")
        self.Informacion_plan.place(x=400, y=250)
        self.widgetsApp.append(self.Informacion_cliente)
        self.widgetsApp.append(self.Informacion_costo)
        self.widgetsApp.append(self.Informacion_plan)

    def verificar_entry(self, event):
        if self.nombre_entry.get() != "" and self.apellido_entry.get() != "" and self.ci_entry.get() != "" :
            self.guardar_button.config(state="normal")
        else:
            self.guardar_button.config(state="disabled")

    def guardar_datos(self):
        #reseteamos el boton y limpiamos las salidas 
        self.mostrar_button.config(state="normal")
        self.Informacion_cliente.config(text="")
        self.Informacion_costo.config(text="")
        self.Informacion_plan.config(text="")
        # Obtener los valores ingresados por el usuario
        plan=Servicios.PlanBase()
        nombre = self.nombre_entry.get()
        apellido = self.apellido_entry.get()
        ci = self.ci_entry.get()
        servicio = self.servicio_seleccionado.get()
        if(servicio=="basico"):
            plan=Servicios.PlanBase()
        elif(servicio=="intermedio"):
            plan=Servicios.PlanIntermedio(plan)
        elif(servicio=="avanzado"):
            plan=Servicios.PlanAvanzado(plan)
        cliente = Cliente.Cliente(nombre, apellido, ci)
        self.info_cliente = f"{cliente.descripcionCliente()}\n"
        self.guardar_servicios(plan)
        messagebox.showinfo("Mensaje", "¡INFORMACION GUARDADA EXITOSAMENTE!")

        # Borrar el contenido de las entradas
        self.nombre_entry.delete(0, tk.END)
        self.apellido_entry.delete(0, tk.END)
        self.ci_entry.delete(0, tk.END)
        self.guardar_button.config(state="disabled")

    def mostrar_datos(self):
        self.Informacion_cliente.config(text=self.info_cliente)
        self.Informacion_costo.config(text=self.info_costo)
        self.Informacion_plan.config(text=self.info_plan)
        self.guardar_button.config(state="disabled")
        
root = tk.Tk()
InterfazCliente(root)
root.mainloop()