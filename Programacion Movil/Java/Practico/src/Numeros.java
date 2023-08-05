public class Numeros {
    private int numero;

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }
    public void par(){
        int limite=this.numero;
        if(limite%2!=0){
            System.out.println(limite+" Es un numero inpar");
        }else {
            for(int i=1;i<=limite;i++) {
                if (i % 2 == 0) {
                    System.out.println(i);
                }
            }
        }
    }
    public void inpar(){
        int limite=this.numero;
        if(limite%2==0){
            System.out.println(limite+" Es un numero par");
        }else {
            for(int i=1;i<=limite;i++) {
                if (i % 2 != 0) {
                    System.out.println(i);
                }
            }
        }
    }
}
