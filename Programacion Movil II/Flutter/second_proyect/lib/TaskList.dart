import 'package:flutter/material.dart';

class TaskList extends StatefulWidget {
  @override
  State<StatefulWidget> createState() {
    return _TaskListState();
  }
}

class _TaskListState extends State<TaskList> {
  Map<String, int> taskList = {
    'A': 600,
    'B': 500,
    'C': 100,
  };
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text("LISTADO")),
      body: ListView.builder(
        itemCount: taskList.length,
        itemBuilder: (context, index) {
          String text = taskList.keys.elementAt(index);
          int color = taskList.values.elementAt(index);
          return Container(
              width: 100,
              padding: EdgeInsets.all(15),
              color: Colors.amber[color],
              child: Center(
                child: Text(text),
              ));
        },
      ),
    );
  }
}
