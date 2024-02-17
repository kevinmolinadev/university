class CounterStates {}

class InitialState extends CounterStates {}

class UpdateState extends CounterStates {
  final int counter;
  UpdateState(this.counter);
}

class PreventState extends CounterStates {
  final int counter;
  PreventState(this.counter);
}

class UpdateStateSerie extends CounterStates {
  final String list;
  UpdateStateSerie(this.list);
}
