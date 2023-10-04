import 'package:flutter/material.dart';

class TaskList extends StatelessWidget {
  final List<String> tasks;

  const TaskList(this.tasks, {super.key});

  @override
  Widget build(BuildContext context) {
    return ListView.builder(
      itemCount: tasks.length,
      itemBuilder: (context, index) {
        return getDetail(index, tasks[0]);
      },
    );
  }

  Widget getDetail(int index, String name) {
    final title = Container(
      margin: const EdgeInsets.only(
        top: 5,
        left: 10,
      ),
      child: Text(
        name,
        style: const TextStyle(
          fontFamily: "Roboto",
          fontSize: 18,
          fontWeight: FontWeight.w900,
          color: Colors.black,
        ),
      ),
    );
    final detail = Container(
      margin: const EdgeInsets.only(top: 0, left: 10, bottom: 25),
      child: Text(
        "Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500",
        style: const TextStyle(
          fontFamily: "Roboto",
          fontSize: 16,
          fontWeight: FontWeight.w300,
          color: Color.fromARGB(255, 0, 0, 0),
        ),
      ),
    );
    final info = Column(
      children: [
        Column(
          children: [
            title,
            detail,
          ],
        ),
        Column(
          children: [
            title,
            detail,
          ],
        ),
      ],
    );
    return info;
  }
}
