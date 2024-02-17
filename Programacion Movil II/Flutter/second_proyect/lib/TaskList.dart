import 'package:flutter/material.dart';

class TaskList extends StatefulWidget {
  @override
  State<StatefulWidget> createState() {
    return _TaskListState();
  }
}

class _TaskListState extends State<TaskList> {
  List<Map<String, String>> taskList = [
    {
      'title': 'Title example',
      'img': 'Img example',
      'description': 'Description example'
    },
    {
      'title': 'Title example',
      'img': 'Img example',
      'description': 'Description example'
    },
  ];

  void addItem(String title, String img, String description) {
    setState(() {
      taskList.add({'title': title, 'img': img, 'description': description});
    });
  }

  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text("LISTADO")),
      body: Lista(),
    );
  }

  ListView Lista() {
    return ListView.builder(
      itemCount: taskList.length,
      itemBuilder: (context, index) {
        Object item = taskList[index];
        return Item(item);
      },
    );
  }

  Widget Item(Object item){
    return ListTile(
          title: Text("${item.toString()}"),
        );
  }
}
