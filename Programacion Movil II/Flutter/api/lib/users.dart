import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'dart:convert' as convert;

class Users extends StatefulWidget {
  const Users({super.key});

  @override
  State<Users> createState() => _UsersPageState();
}

class _UsersPageState extends State<Users> {
  List<dynamic> data = [];

  Future<void> fetchData() async {
    final response =
        await http.get(Uri.parse('https://jsonplaceholder.typicode.com/users'));

    if (response.statusCode == 200) {
      setState(() {
        data = convert.jsonDecode(response.body);
      });
    } else {
      throw Exception('Failed to load data');
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('API Example'),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            ElevatedButton(
              onPressed: fetchData,
              child: const Text('Cargar Usuarios'),
            ),
            const SizedBox(height: 20),
            Expanded(
              child: ListView.builder(
                itemCount: data.length,
                itemBuilder: (BuildContext context, int index) {
                  return ListTile(
                    title: ViewItem(data[index]['name'], data[index]['email'], data[index]['address']['street'], data[index]['address']['zipcode'], data[index]['company']['name']),
                  );
                },
              ),
            ),
          ],
        ),
      ),
    );
  }

  Widget ViewItem(String name, String email, String street, String code, String company) {
    return Card(
        child: ClipRRect(
      borderRadius: BorderRadius.circular(20),
      child: Padding(padding: EdgeInsets.all(20),
      child: Column(
        children: [
          Align(
            alignment: Alignment.centerLeft,
            child: Text(name,
              style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
            ),
          ),
          Align(
            alignment: Alignment.centerLeft,
            child: Text(email,
              style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
            ),
          ),
          Align(
            alignment: Alignment.centerRight,
            child: Text(street,
              style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
            ),
          ),
          Align(
            alignment: Alignment.centerRight,
            child: Text(code,
              style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
            ),
          ),
          Align(
            alignment: Alignment.center,
            child: Text(company,
              style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
            ),
          ),
        ],
      ),),
    ));
  }
}
