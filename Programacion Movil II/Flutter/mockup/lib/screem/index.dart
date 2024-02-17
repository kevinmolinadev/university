import 'package:flutter/material.dart';
import 'package:carousel_slider/carousel_slider.dart';
import 'package:mockup/screem/card_item.dart';

class Mockup extends StatelessWidget {
  const Mockup({super.key});
  @override
  Widget build(BuildContext context) {
    final List<Map<String, dynamic>> lista = [
      {
        "title": "Canguro de tela",
        "price": 40,
        "img":
            "https://invain.imgix.net/uploads/2019/02/canguro-carhatt-tendencia-naranja-persimmon.jpg?auto=format%2Ccompress&ixlib=php-3.3.0&w=500",
        "description":
            "Canguro de tela de alta calidad con diseño moderno y cómodo. Perfecto para actividades al aire libre y uso diario."
      },
      {
        "title": "Polera",
        "price": 45,
        "img":
            "https://static.vecteezy.com/system/resources/previews/008/533/978/original/black-t-shirt-mockup-cutout-file-png.png",
        "description":
            "Polera clásica de algodón suave y transpirable. Ideal para combinar con cualquier estilo y ocasión."
      },
      {
        "title": "Tenis",
        "price": 45,
        "img":
            "https://intn24.lalr.co/old/su19_jd_theones_nikenews_aj1_low_gymred_rectangle_1600.jpg?w=480",
        "description":
            "Tenis deportivos de alta calidad con suela resistente y amortiguación cómoda. Diseñados para brindar máximo rendimiento y comodidad durante el ejercicio."
      },
      {
        "title": "Bolso de mano",
        "price": 35,
        "img":
            "https://e7.pngegg.com/pngimages/388/467/png-clipart-handbag-tote-bag-messenger-bags-satchel-michael-kors-luggage-bags-orange.png",
        "description":
            "Bolso de mano elegante y funcional, perfecto para llevar tus objetos personales de forma segura y organizada. Fabricado con materiales duraderos y de alta calidad."
      },
      {
        "title": "Camisa de algodon",
        "price": 75,
        "img":
            "https://img.lovepik.com/free-png/20220126/lovepik-shirt-png-image_401792549_wh1200.png",
        "description":
            "Camisa de algodón premium con un corte moderno y elegante. Ideal para ocasiones formales y casuales. Se siente suave y cómoda contra la piel."
      },
      {
        "title": "Pantalones vaqueros",
        "price": 55,
        "img":
            "https://www.pngfind.com/pngs/m/348-3482430_blue-jeans-png-photo-png-image-jeans.png",
        "description":
            "Pantalones vaqueros clásicos con un ajuste cómodo y moderno. Hechos de denim resistente y duradero. Perfectos para un look casual y versátil."
      },
      {
        "title": "Zapatillas de deporte",
        "price": 50,
        "img": "https://pngimg.com/uploads/sneakers/sneakers_PNG10462.png",
        "description":
            "Zapatillas deportivas ligeras y transpirables diseñadas para ofrecer un soporte óptimo durante las actividades físicas. Ideales para correr, hacer ejercicio o simplemente para un estilo casual."
      }
    ];
    List<Widget> listWidget = lista.map((item) {
      return CardItem(item);
    }).toList();
    return Scaffold(
      backgroundColor: Color.fromARGB(255, 238, 238, 238),
      appBar: AppBar(
          backgroundColor: Color.fromARGB(255, 238, 238, 238),
          title: const Align(
            alignment: Alignment.center,
            child: Text("FEARD OF GOOD",
                style: TextStyle(fontWeight: FontWeight.w900, fontSize: 32)),
          )),
      body: Padding(
        padding: EdgeInsets.symmetric(horizontal: 20),
        child: Column(
          children: [
            const SearchBar(
              padding: MaterialStatePropertyAll(
                  EdgeInsets.symmetric(horizontal: 15)),
              leading: Icon(
                Icons.search,
                size: 30,
              ),
              hintText: "Ingrese el producto a buscar",
              backgroundColor:
                  MaterialStatePropertyAll(Color.fromARGB(255, 255, 255, 255)),
              shadowColor:
                  MaterialStatePropertyAll(Color.fromARGB(255, 255, 255, 255)),
              overlayColor:
                  MaterialStatePropertyAll(Color.fromARGB(255, 255, 255, 255)),
              surfaceTintColor:
                  MaterialStatePropertyAll(Color.fromARGB(255, 255, 255, 255)),
            ),
            Card(
                margin: EdgeInsets.symmetric(vertical: 30),
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(30),
                ),
                child: ClipRRect(
                  borderRadius: BorderRadius.circular(30),
                  child: SizedBox(
                      width: double.infinity,
                      height: 380,
                      child:
                          Image.asset('assets/banner.png', fit: BoxFit.cover)),
                )),
            const Align(
              alignment: Alignment.centerLeft,
              child: Text("Productos",
                  style: TextStyle(fontWeight: FontWeight.w900, fontSize: 20)),
            ),
            Carousel(listWidget),
          ],
        ),
      ),
      bottomNavigationBar: const BottomAppBar(
        surfaceTintColor: Color.fromARGB(0, 0, 0, 0),
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceAround,
          children: [
            Column(
              children: [Icon(Icons.home), Text("HOME")],
            ),
            Column(
              children: [Icon(Icons.newspaper), Text("CATEGORIAS")],
            ),
            Column(
              children: [Icon(Icons.settings), Text("CONFIGURACION")],
            ),
          ],
        ),
      ),
    );
  }

  Widget Carousel(List<Widget> lista) {
    return Container(
        margin: EdgeInsets.symmetric(vertical: 20),
        child: CarouselSlider(
          items: lista,
          options: CarouselOptions(autoPlay: true),
        ));
  }
}
