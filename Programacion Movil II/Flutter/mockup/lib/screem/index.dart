import 'package:flutter/material.dart';
import 'package:carousel_slider/carousel_slider.dart';

class Mockup extends StatelessWidget {
  const Mockup({super.key});
  @override
  Widget build(BuildContext context) {
    final List<Map<String, dynamic>> lista = [
      {
        "title": "Canguro de tela",
        "price": 40,
        "img":
            "https://invain.imgix.net/uploads/2019/02/canguro-carhatt-tendencia-naranja-persimmon.jpg?auto=format%2Ccompress&ixlib=php-3.3.0&w=500"
      },
      {
        "title": "Polera",
        "price": 45,
        "img":
            "https://static.vecteezy.com/system/resources/previews/008/533/978/original/black-t-shirt-mockup-cutout-file-png.png"
      },
      {
        "title": "Tenis",
        "price": 45,
        "img":
            "https://intn24.lalr.co/old/su19_jd_theones_nikenews_aj1_low_gymred_rectangle_1600.jpg?w=480"
      },
      {
        "title": "Bolso de mano",
        "price": 35,
        "img":
            "https://e7.pngegg.com/pngimages/388/467/png-clipart-handbag-tote-bag-messenger-bags-satchel-michael-kors-luggage-bags-orange.png"
      },
      {
        "title": "Camisa de algodon",
        "price": 75,
        "img":
            "https://img.lovepik.com/free-png/20220126/lovepik-shirt-png-image_401792549_wh1200.png"
      }
    ];
    List<Widget> listWidget = lista.map((item) {
      return Card(
        shape: RoundedRectangleBorder(
          borderRadius: BorderRadius.circular(20),
        ),
        child: Container(
          width: 270,
          child: Column(
            children: [
              ClipRRect(
                  borderRadius: BorderRadius.only(
                      topLeft: Radius.circular(20),
                      topRight: Radius.circular(20)),
                  child: SizedBox(
                    width: double.infinity,
                    height: 191,
                    child: Image.network(item["img"], fit: BoxFit.fitWidth),
                  )),
              Padding(
                  padding: EdgeInsets.symmetric(vertical: 5, horizontal: 10),
                  child: Column(
                    children: [
                      Align(
                        alignment: Alignment.centerLeft,
                        child: Text(
                          item["title"],
                          style: TextStyle(
                              fontWeight: FontWeight.bold, fontSize: 16),
                        ),
                      ),
                      Align(
                        alignment: Alignment.centerLeft,
                        child: Text(
                          "${item["price"].toString()}Bs",
                          style: TextStyle(
                              fontWeight: FontWeight.bold, fontSize: 15),
                        ),
                      )
                    ],
                  )),
            ],
          ),
        ),
      );
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
