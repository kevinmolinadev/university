public class Main {
    public static void main(String[] args) {

        Perro perro1 = new Perro("Furro",15, "Pastor aleman", 90);
        Gato gato1 = new Gato("Martin", 2, "Negro Blanco", 9);
        Pato pato1 = new Pato("Xi", 5, "Chino", false);

        iPhone iphone = new iPhone("777","557412","iOS",11);
        Samsung samsung = new Samsung("555","712568","S7",85);
        Huawei huawei = new Huawei("333","84268","2012",false);

        Mexicana mexicana = new Mexicana("Taco", 2,true,true);
        Italiana italiana = new Italiana("Pizza",1,true,true);
        China china = new China("Chop suey",3, true, true);

        Tierra tierra1 = new Tierra("Tierra", "2", 90,true);
        Marte marte1 = new Marte("Marte", "2", "50", 0);
        Jupiter jupiter1 = new Jupiter("Jupiter", "2", 110,true);


        System.out.println("Tarea POO");

        System.out.println(perro1.toString());
        perro1.tuMascotaTeAcompanha();
        System.out.println(perro1.AlturaPeso());

        System.out.println(gato1.toString());
        gato1.tuMascotaTeAcompanha();
        System.out.println(gato1.menosVidas());
        gato1.metodoDeInterfaz();

        System.out.println(pato1.toString());
        pato1.tuMascotaTeAcompanha();
        pato1.huyeCazador();

        System.out.println(iphone.toString());
        iphone.recibirLlamada();
        iphone.seMuere();

        System.out.println(samsung.toString());
        samsung.recibirLlamada();
        System.out.println(samsung.menosBateria());

        System.out.println(huawei.toString());
        huawei.recibirLlamada();
        huawei.UsarGoogle();
        huawei.metodoDeInterfaz();

        System.out.println(mexicana.toString());
        mexicana.disfrutar();
        mexicana.esMexicanaNot();

        System.out.println(italiana.toString());
        italiana.disfrutar();
        italiana.esComidaItaliana();

        System.out.println(china.toString());
        china.disfrutar();
        china.votosChinos();
        china.metodoDeInterfaz();

        System.out.println(tierra1.toString());
        tierra1.girar();
        tierra1.extensionEntrePoblacion(50);

        System.out.println(marte1.toString());
        marte1.girar();
        marte1.taFuerte();

        System.out.println(jupiter1.toString());
        jupiter1.girar();
        jupiter1.muchosMetodos();
        jupiter1.metodoDeInterfaz();
    }
}