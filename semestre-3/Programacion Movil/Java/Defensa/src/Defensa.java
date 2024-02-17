public class Defensa {
    //si n = 8 generar 8, 1, 7, 2, 6, 3,5, 4
    public String ejercicio17(int n, int indice){
        StringBuilder lista = new StringBuilder();
        int inicio=1;
        int integracion=1;
        for (int i=0;i<indice/2; i++){
            if(n%2==0){
                lista.append(n).append(", ");
                n-=integracion;
                lista.append(inicio).append(", ");
                inicio+=integracion;
            }else {
                lista.append(n).append(", ");
                n-=integracion;
                lista.append(inicio).append(", ");
                inicio+=integracion;
            }
            if (indice%2!=0){
                lista.append(n);
            }
        }
        return lista.toString();
    }
    //1, 2, 4, 5, 10, 11, 22
    public String ejercicio9(int indice){
        StringBuilder lista = new StringBuilder();
        int inicio=1;
        lista.append(inicio).append(", ");
        for (int i=0;i<indice-1; i++){
            if(inicio%2==0){
                inicio*=2;
                lista.append(inicio).append(", "); 
            }else {
                inicio+=1;
                lista.append(inicio).append(", ");
            }
        }
        return lista.toString();
    }
}
