import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Widgets',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
        useMaterial3: true,
      ),
      home: const MyHomePage(title: 'Uso de widgets'),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key, required this.title});
  final String title;
  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  int _counter = 0;
  void _incrementCounter() {
    setState(() {
      _counter++;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          backgroundColor: Theme.of(context).colorScheme.inversePrimary,
          title: Text(widget.title),
        ),
        body: Column(
          children: [
            Text("Column: Ordena a sus hijos de forma vertical."),
            Column(
              children: [
                Text("Align: Alinea su hijo dentro de si mismo"),
                Container(
                  height: 150.0,
                  width: 150.0,
                  color: Colors.blue[50],
                  child: const Align(
                    alignment: Alignment.center,
                    child: FlutterLogo(
                      size: 80,
                    ),
                  ),
                ),
                Text("Row: Ordena a sus hijos de forma horizontal."),
                Center(
                  child: Row(
                    children: [
                      Container(
                        height: 150.0,
                        width: 150.0,
                        color: Colors.blue[50],
                      ),
                      Container(
                        height: 150.0,
                        width: 150.0,
                        color: Colors.red[50],
                      )
                    ],
                  ),
                ),
              ],
            )
          ],
        ));
  }
}
