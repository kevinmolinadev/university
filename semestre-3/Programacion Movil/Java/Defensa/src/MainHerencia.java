public class MainHerencia {
    public static void main(String[] args) {
        Figura figura=new Figura("Cafe",5);
        Circulo circulo=new Circulo("rojo",2);
        circulo.setColor("lila");
        circulo.setRadio(3);
        Figura cuadrado =new Cuadrado("amarillo",2);
        Figura triangulo=new Triangulo("verde",2);

        System.out.println(figura.toString());
        System.out.println(circulo.toString());
        System.out.println(cuadrado.toString());
        System.out.println(triangulo.toString());
    }
}
