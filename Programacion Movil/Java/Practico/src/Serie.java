public class Serie {
    //Serie 13
    public String  serie13(int indice){
        //3, 8, 13, 18, 23, 28, 33, 38
        int resultado = 3;
        int integracion = 5;
        StringBuilder serie = new StringBuilder();
        serie.append(resultado);
        for (int i = 1; i < indice; i++) {
            resultado += integracion;
            serie.append(", ");
            serie.append(resultado);
            //forma simplificada serie.append(", ").append(resultado);
        }
        return serie.toString();
    }

    //Serie 15
    public String serie15(int indice) {
        //1, 8, 27, 64, 125, 216, 343, 512, 729
        StringBuilder serie = new StringBuilder();
        for (int i = 1; i <= indice; i++) {
            int resultado = i*i*i;
            serie.append(resultado);
            if (i < indice) {
                serie.append(", ");
            }
        }
        return serie.toString();
    }

    //serie 17
    public String serie17(int numero,int indice) {
        //si n = 8 generar 8, 1, 7, 2, 6, 3,5, 4
        StringBuilder serie = new StringBuilder();
        int integracion=1;
        int inicio=1;
        for (int i = 0; i < indice/2; i++) {
            if (numero%2==0) {
                serie.append(numero).append(", ");
                numero -= integracion;
                serie.append(inicio).append(", ");
                inicio+=integracion;
            }else {
                serie.append(numero).append(", ");
                numero -=integracion;
                serie.append(inicio).append(", ");
                inicio+=integracion;
            }

        }
        if(indice%2!=0){
            serie.append(numero);
        }
        return serie.toString();
    }

    //serie 19
    public String serie19(int indice){
        //1, 20, 3, 18, 5, 16, 7, 14, 9, 12, 11, 10, 13, 8, 15, 6, 17, 4, 19, 2, 21, 0
        StringBuilder serie = new StringBuilder();
        int integracion=2;
        int numero=20;
        int inicio=1;
        for (int i = 0; i < indice/2; i++) {
            if (numero%2==0) {
                serie.append(inicio).append(", ");
                inicio+=integracion;
                serie.append(numero).append(", ");
                numero -= integracion;
            }else {
                serie.append(inicio).append(", ");
                inicio+=integracion;
                serie.append(numero).append(", ");
                numero -=integracion;
            }

        }
        if(indice%2!=0){
            serie.append(inicio);
        }
        return serie.toString();
    }

    //serie 24

    //serie 25
    public String serie25(int indice) {
        //1, 10, 100, 1000.....
        StringBuilder serie = new StringBuilder();
        int resultado = 1;
        serie.append(resultado).append(", ");
        for (int i = 1; i < indice; i++) {
            resultado *= 10;
            serie.append(resultado);
            if (i < indice-1) {
                serie.append(", ");
            }
        }
        return serie.toString();
    }
}
