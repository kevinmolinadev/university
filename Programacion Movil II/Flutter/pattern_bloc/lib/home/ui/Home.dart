import 'package:flutter/material.dart';
import 'package:pattern_bloc/home/bloc/counter_bloc.dart';
import 'package:pattern_bloc/home/bloc/counter_event.dart';
import 'package:pattern_bloc/home/bloc/counter_state.dart';
import 'package:flutter_bloc/flutter_bloc.dart';

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key, required this.title});

  final String title;

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        centerTitle: true,
        title: const Text("Bloc Demo APP"),
      ),
      body: BlocBuilder<CounterBloc, CounterStates>(
        builder: (context, state) {
          if (state is InitialState) {
            return _counter(context, 0);
          } else if (state is PreventState) {
            return _counter(context, state.counter);
          } else if (state is UpdateState) {
            return _counter(context, state.counter);
          } else if (state is UpdateStateSerie) {
            return _serie(context, state.list);
          }
          return Container();
        },
      ),
    );
  }

  Widget _counter(BuildContext context, int counter) {
    return Center(
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          Text(
            counter.toString(),
            style: Theme.of(context).textTheme.headlineLarge,
          ),
          const SizedBox(
            height: 50,
          ),
          Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              MaterialButton(
                color: Colors.red,
                elevation: 0.0,
                height: 50,
                shape: const RoundedRectangleBorder(
                    borderRadius: BorderRadius.all(Radius.circular(8))),
                child: const Text(
                  "-",
                  style: TextStyle(fontSize: 22, color: Colors.white),
                ),
                onPressed: () {
                  context.read<CounterBloc>().add(NumberDecreaseEvent());
                },
              ),
              const SizedBox(
                width: 25,
              ),
              MaterialButton(
                color: Colors.green,
                elevation: 0.0,
                height: 50,
                shape: const RoundedRectangleBorder(
                    borderRadius: BorderRadius.all(Radius.circular(8))),
                child: const Text(
                  "+",
                  style: TextStyle(fontSize: 22, color: Colors.white),
                ),
                onPressed: () {
                  context.read<CounterBloc>().add(NumberIncreaseEvent());
                },
              ),
            ],
          ),
          const SizedBox(
            height: 25,
          ),
          Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              MaterialButton(
                color: Colors.black,
                elevation: 0.0,
                height: 50,
                shape: const RoundedRectangleBorder(
                    borderRadius: BorderRadius.all(Radius.circular(8))),
                child: const Text(
                  "x2",
                  style: TextStyle(fontSize: 22, color: Colors.white),
                ),
                onPressed: () {
                  context.read<CounterBloc>().add(NumberMultiply());
                },
              ),
              const SizedBox(
                width: 25,
              ),
              MaterialButton(
                color: Colors.blue,
                elevation: 0.0,
                height: 50,
                shape: const RoundedRectangleBorder(
                    borderRadius: BorderRadius.all(Radius.circular(8))),
                child: const Text(
                  "Serie",
                  style: TextStyle(fontSize: 22, color: Colors.white),
                ),
                onPressed: () {
                  context.read<CounterBloc>().add(Serie());
                },
              ),
            ],
          )
        ],
      ),
    );
  }
}

Widget _serie(BuildContext context, String list) {
  return Container(
    alignment: Alignment.center,
    child: Column(
      mainAxisAlignment: MainAxisAlignment.center,
      children: [
        Text(
          list,
          style: const TextStyle(fontSize: 25),
        ),
        const SizedBox(
          height: 50,
        ),
        MaterialButton(
          color: Colors.black,
          elevation: 0.0,
          height: 50,
          shape: const RoundedRectangleBorder(
              borderRadius: BorderRadius.all(Radius.circular(8))),
          child: const Text(
            "Back",
            style: TextStyle(fontSize: 22, color: Colors.white),
          ),
          onPressed: () {
            context.read<CounterBloc>().add(PreventStateCounter());
          },
        ),
      ],
    ),
  );
}
