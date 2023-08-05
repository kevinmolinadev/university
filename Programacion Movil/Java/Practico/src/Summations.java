public class Summations {

    public int  ejercicio1(int indice){
        //3 + 6 + 12 + 24 + 48.....
        int resultado=3;
        int aux=3;
        for (int i=0;i<indice-1;i++){
            aux=aux*2;
            resultado += aux;
        }
        return resultado;
    }
    //Ejercicio3
    public int  ejercicio3(int indice){
        //1 + 4 + 9 + 16 + 25.....
        int resultado=0;
        for (int i=1;i<=indice;i++){
            int aux=i*i;
            resultado += aux;
        }
        return resultado;
    }
    public int  ejercicio5(int indice){
        //1 + 2 – 3 + 4 – 5 + 6 – 7.....
        int resultado=0;
        int aux=0;
        for (int i = 1; i <= indice; i++) {
            aux++;
            if (i>1 && i%2!=0){
                resultado = resultado - aux;
            }else {
                resultado+=i;
            }
        }
        return resultado;
    }

    public  double getSumatoria7(int number){
        double resultado=0,numoperacion =1,resul;
        for (int i = 0; i < number; i++) {
            resultado+= (double) (numoperacion /(numoperacion +1));
            numoperacion+=1;
        }
        return resultado;
    }
    public int factorial(int numero){
        int resultado =1;
        for (int i = 1; i < numero+1; i++) {
            resultado*=i;
        }
        // resul = 1,2,6
        return resultado;
    }
    //F= x/1! + x^3/2! + x^5/3!
    public double getSumatoria9(int cantidad, int x){
        double resultado =0, y = 1;
        for (int i = 1; i < cantidad+1; i++) {
            resultado+=(double)(Math.pow(x,y))/factorial(i);
            y+=2;
        }
        return resultado;
    }

    public int getSumatoria11(int elementos) {
        int resultado = 0;
        int razon = 3;
        int auxiliar = 1;
        for (int i = 1; i <= elementos; i++) {
            resultado = resultado + (auxiliar * razon);
            auxiliar = razon;
            razon = razon + 2;
        }
        return resultado;
    }

    public int getSumatoria13(int elementos) {
        int resultado = 0;
        int auxiliar = 3;
        int razon = 1;
        for (int i = 1; i <= elementos ; i++) {
            resultado = resultado + (auxiliar * razon);
            razon = razon * (i + 1);
            auxiliar = auxiliar + 2;
        }
        return resultado;
    }

    public int getSumatoria15(int elementos) {
        int resultado = 0;
        int auxiliar = 1;
        int razon = 5;
        int cinco = 5;
        for (int i = 1; i <= elementos ; i++) {
            if (i == 2) {
                auxiliar = 5;
                razon = 4;
                cinco = 5;
            }
            resultado = resultado + (auxiliar * razon);
            auxiliar = razon;
            razon = razon + cinco;
            cinco = cinco + 2;
        }
        return resultado;
    }
}
