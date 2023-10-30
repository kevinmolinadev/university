import 'package:pattern_bloc/home/bloc/counter_event.dart';
import 'package:pattern_bloc/home/bloc/counter_state.dart';
import 'package:flutter_bloc/flutter_bloc.dart';

class CounterBloc extends Bloc<CounterEvents, CounterStates> {
  int counter = 0;

  CounterBloc() : super(InitialState()) {
    on<NumberIncreaseEvent>(onNumberIncrease);
    on<NumberDecreaseEvent>(onNumberDecrease);
    on<NumberMultiply>(onNumberMultiply);
    on<Serie>(onSerie);
    on<PreventStateCounter>(onState);
  }

  void onNumberIncrease(
      NumberIncreaseEvent event, Emitter<CounterStates> emit) async {
    counter = counter + 1;
    emit(UpdateState(counter));
  }

  void onNumberDecrease(
      NumberDecreaseEvent event, Emitter<CounterStates> emit) async {
    counter = counter - 1;
    emit(UpdateState(counter));
  }

  void onNumberMultiply(
      NumberMultiply event, Emitter<CounterStates> emit) async {
    counter = counter * 2;
    emit(UpdateState(counter));
  }

  void onSerie(Serie event, Emitter<CounterStates> emit) async {
    String result = "";
    for (int i = 1; i <= counter; i++) {
      result += "${i * 2}";
    }
    emit(UpdateStateSerie(result.split("").join(",")));
  }

  void onState(PreventStateCounter event, Emitter<CounterStates> emit) async {
    emit(PreventState(counter));
  }
}
