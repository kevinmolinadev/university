public class Persona {
    private String Nombre;
    private int Edad;
    private String Direccion;
    private String Telefono;
    private String Correo;

    public Persona(String Nombre, int Edad, String Direccion, String Telefono, String Correo) {
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Direccion = Direccion;
        this.Telefono = Telefono;
        this.Correo = Correo;
    }

    public String getNombre() {
        return this.Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public int getEdad() {
        return this.Edad;
    }

    public void setEdad(int Edad) {
        this.Edad = Edad;
    }

    public String getDireccion() {
        return this.Direccion;
    }

    public void setDireccion(String Direccion) {
        this.Direccion = Direccion;
    }

    public String getTelefono() {
        return this.Telefono;
    }

    public void setTelefono(String Telefono) {
        this.Telefono = Telefono;
    }

    public String getCorreo() {
        return this.Correo;
    }

    public void setCorreo(String Correo) {
        this.Correo = Correo;
    }

    @Override
    public String toString() {
        return "Persona{" +
                "Nombre='" + this.Nombre + '\'' +
                ", Edad=" + this.Edad +
                ", Direccion='" + this.Direccion + '\'' +
                ", Telefono='" + this.Telefono + '\'' +
                ", Correo='" + this.Correo + '\'' +
                '}';
    }
}

