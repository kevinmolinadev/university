public class NumericScales {

    public String getSerie1(int number){
        int [] num = {1,4};
        int resultado = 4;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < number; i++) {
            num[1] = resultado;
            sb.append(resultado).append(",");
            resultado = num[0] + num[1];
            num[0] = num[1];
        }
        return sb.toString();
    }
    public void getSerie3(int number){
        int [] num = {1,1};
        int resultado =0;
        for (int i = 0; i < number ; i++) {
            num[1] = resultado;
            resultado =  num[0] + num[1];
            num[0] = num[1];
            System.out.println(resultado);
        }
    }

    public void getSerie5(int number){
        int resultado,numero =0;
        for (int i = 0; i < number; i++) {
            System.out.println((numero+=i)*2);
        }
    }

// Genera la siguiente cadena 1,2,3,5,7,11,13,17...
    public  String getSerie7(int number){
        String numero = ""; int num = 1;
        int printedCount = 0; // El número de números primos que se han impreso


        while (printedCount < number) {
            boolean isPrime = true; // Un indicador para almacenar si el número es primo o no

            // Verificar si el número es primo
            for (int i = 2; i <= Math.sqrt(num); i++) {
                if (num % i == 0) {
                    isPrime = false;
                    break;
                }
            }
            // Imprimir el número si es primo
            if (isPrime) {
                System.out.print(num + ",");
                printedCount++;
            }
            num++;
        }
        return numero;
    }
    //Generea 1,2,4,5,10,11,22
    public String getSerie9(int number){
        String numeros = ""; int num=1;
        for (int i = 0; i < number; i++) {
            numeros+= String.valueOf(num) +"," ;
            num = (i % 2 != 0) ? num*2 : num+1;
        }
        return numeros;


    }

    //Generar 1,1,2,1,2,3,1,2,3,4,1,2,3,4,5,1,2,3,4,5,6
    public String getSerie11(int number){
        String Numeros = "";
        int num=0,limite =1;
        for (int i = 0; i < number; i++){
            if (num==limite){
                limite +=1;
                num=1;
            }else{
                num+=1;
            }
            Numeros+= String.valueOf(num) +"," ;
        }
        return  Numeros;
    }

    //Parte de Kevin

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

    public void getSerie21(int number){
        int num=0,limite =5,x=5;
        boolean dirreccion = true;
        for (int i = 0; i < number; i++){
            if (num==limite){
                limite =(dirreccion)? 1 : x-1;
                dirreccion=!dirreccion;
            }else{
                num = (dirreccion) ? num+1 : num-1;
            }
            System.out.println(num);
        }
    }

    public void getSerie23(int elementos) {
        System.out.println("Serie #23");
        int numero = 1;
        for (int i = 1; i <= elementos; i++) {
            if ( i % 2 != 0) {
                numero = numero + 2;
            }
            else {
                numero = numero * 2;
            }
            System.out.println(numero);
        }
    }

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

    public void getSerie27(int elementos) {
        System.out.println("Serie #27");
        int auxiliar = 1;
        for (int i = 1; i <= elementos; i++) {
            for (int j = 1; j <= i; j++) {
                System.out.println("Elmento nro" + (auxiliar) + ": " + j);
                auxiliar++;
                if (auxiliar > elementos) {
                    break;
                }
            }
            if (auxiliar > elementos) {
                break;
            }
        }

        /*for (int i = 1; i < elementos; i++) {
            for (int j = 1; j < i; j++) {
                System.out.println(j);
            }
        }*/
    }

    public void getSerie29(int elementos) {
        System.out.println("Serie #29");
        int numero = 8;
        for (int i = 0; i < elementos; i++) {
            numero = numero + i;
            System.out.println("Elmento nro" + (i + 1) + ": " +numero);
        }
    }

    public void getSerie31(int elementos) {
        System.out.println("Serie #31");
        for (int i = 1; i <= elementos; i++) {
            if (i == 1) {
                System.out.println("Elmento nro" + 1 + ": " + 1);
            }
            else {
                int numero = 7;
                numero = numero * (i - 1);
                System.out.println("Elmento nro" + i + ": " + numero);
            }
        }
    }

    public void getSerie33(int elementos) {
        System.out.println("Serie #33");
        int numero = 8;
        for (int i = 1; i <= elementos ; i++) {
            System.out.println("Elmento nro" + i + ": " + numero);
            numero = numero + (5 * i);
        }
    }

    public void getSerie35(int elementos) {
        System.out.println("Serie #35");
        int numero = 8;
        for (int i = 1; i < elementos; i++) {
            if (i % 2 != 0){
                numero = numero * 3;
            }
            else {
                numero = numero / 2;
            }
            System.out.println("Elmento nro" + i + ": " + numero);
        }
    }

    public void getSerie37(int elementos) {
        System.out.println("Serie #37");
        System.out.println("La serie: 1, 1, 2, 4, 2, 6, 9, 6, 12, 16, 24, 24,25,120,48...n, no tiene coherencia");
    }

}
