public class China extends TipoDeComida implements IMetodos {

    boolean apoyasXiJinping = true;
    boolean apoyasDengXiaoping = true;

    public China(String nombreComida, int peso, boolean apoyasXiJinping, boolean apoyasDengXiaoping) {
        super(nombreComida, peso);
        this.apoyasXiJinping = apoyasXiJinping;
        this.apoyasDengXiaoping = apoyasDengXiaoping;
    }

    public void votosChinos() {
        if (apoyasDengXiaoping == true) {
            System.out.println("Ta bueno, compa, que apoyes a Deng Xiaoping");
        }
        else {
            System.out.println("¿Liberal o sectario?");
        }
    }

    @Override
    public String toString() {
        return "China{" +
                "apoyasXiJinping=" + apoyasXiJinping +
                ", apoyasDengXiaoping=" + apoyasDengXiaoping +
                ", nombreComida='" + nombreComida + '\'' +
                ", peso=" + peso +
                '}';
    }

    @Override
    public void metodoDeInterfaz() {
        System.out.println("Este es el metodo por interfaz");
    }
}
