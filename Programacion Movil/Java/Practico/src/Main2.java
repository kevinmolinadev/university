public class Main2 {
    public static void main(String[] args) {
        NumericScales serie = new NumericScales();
        Summations sumatoria = new Summations();

        System.out.println("Hello world!");
        System.out.println("Serie # 1");
        System.out.println(        serie.getSerie1(10));
        System.out.println("Serie # 3");
        serie.getSerie3(10);
        System.out.println("Serie # 5");
        serie.getSerie5(10);
        System.out.println("Serie # 7");
        serie.getSerie7(10);
        System.out.println("Serie # 9");
        serie.getSerie9(10);
        System.out.println("Serie # 11: " + serie.getSerie11(10));
        serie.serie13(10);
        serie.serie15(10);
        serie.serie17(10,5);
        serie.serie19(10);
        serie.getSerie21(30);
        serie.getSerie23(10);
        System.out.println("Serie # 25: " + serie.serie25(10));
        serie.getSerie27(10);
        serie.getSerie29(10);
        serie.getSerie31(10);
        serie.getSerie33(10);
        serie.getSerie35(10);
        serie.getSerie37(10);

        System.out.println("Sumatoria # 1= " + sumatoria.ejercicio1(5));
        System.out.println("Sumatoria # 3= " + sumatoria.ejercicio3(5));
        System.out.println("Sumatoria # 5= " + sumatoria.ejercicio5(5));
        System.out.println("Sumatoria # 7= " + sumatoria.getSumatoria7(5));
        System.out.println("Sumatoria # 9= " + sumatoria.getSumatoria9(5,2));
        System.out.println("Sumatoria # 11= " + sumatoria.getSumatoria11(4));
        System.out.println("Sumatoria # 13= " + sumatoria.getSumatoria13(4));
        System.out.println("Sumatoria # 15= " + sumatoria.getSumatoria15(5));
    }
}