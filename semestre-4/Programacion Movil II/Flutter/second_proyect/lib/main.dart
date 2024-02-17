import 'package:flutter/material.dart';
import 'TaskList.dart';

void main() {
  runApp(MyApp());
}
class MyApp extends StatelessWidget{
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: "Listas",
      theme: ThemeData(
        primarySwatch: Colors.deepOrange
      ),
      home: TaskList(),
      debugShowCheckedModeBanner: false,
    );
  }
}

/* class TaskListScreem extends StatelessWidget{
    @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: ListView(
        children: [
          TaskList(),
          TaskList(),
          TaskList()
        ],
      ),
    );
  }
} */