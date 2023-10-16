import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'dart:convert' as convert;

class GameOfThrones extends StatefulWidget {
  const GameOfThrones({super.key});
  @override
  State<GameOfThrones> createState() => _GameOfThrone();
}

class _GameOfThrone extends State<GameOfThrones> {
  List<dynamic> data = [];
  @override
  void initState() {
    super.initState();
    if (mounted) {
      fetchData();
    }
  }

  fetchData() async {
    final response =
        await http.get(Uri.parse('https://thronesapi.com/api/v2/Characters'));
    if (response.statusCode == 200) {
      final dataItems = convert.jsonDecode(response.body);
      setState(() {
        data = dataItems;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Container(
        color: Colors.white,
        alignment: Alignment.center,
        child: data.isEmpty
            ? const Text("Cargado...")
            : ListView.builder(
                itemCount: data.length,
                padding:
                    const EdgeInsets.symmetric(horizontal: 15, vertical: 20),
                itemBuilder: (BuildContext context, int index) {
                  return item(data[index]);
                }));
  }

  Widget item(Map<String, dynamic> element) {
    return Card(
      margin: const EdgeInsets.symmetric(vertical: 10),
      child: Row(
        children: [
          ClipRRect(
            borderRadius: const BorderRadius.only(
                bottomLeft: Radius.circular(10), topLeft: Radius.circular(10)),
            child: SizedBox(
              width: 100,
              height: 100,
              child: Image.network(
                element["imageUrl"],
                fit: BoxFit.cover,
              ),
            ),
          ),
          Expanded(
              child: Column(
            children: [
              Align(
                alignment: Alignment.center,
                child: Text(
                  element["fullName"],
                  style: const TextStyle(
                      fontWeight: FontWeight.bold, fontSize: 18),
                ),
              ),
              Align(
                child: Text("Titulo: ${element["title"]}"),
              ),
              Align(
                child: Text("Familia: ${element["family"]}"),
              ),
            ],
          )),
          const Padding(
            padding: EdgeInsets.only(right: 10),
            child: Icon(Icons.favorite),
          )
        ],
      ),
    );
  }
}
