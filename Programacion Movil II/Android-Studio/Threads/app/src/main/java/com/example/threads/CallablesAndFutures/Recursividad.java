package com.example.threads.CallablesAndFutures;

import java.util.concurrent.Callable;

public class Recursividad implements Callable<Recursividad.Funtions> {
    private int number;
    private int numberTwo;

    public int getNumber() {
        return number;
    }

    public void setNumber(int number) {
        this.number = number;
    }

    public int getNumberTwo() {
        return numberTwo;
    }

    public void setNumberTwo(int numberTwo) {
        this.numberTwo = numberTwo;
    }

    @Override
    public Funtions call() throws Exception {
        return new Funtions();
    }

    public long factorialNumber(int n){
        if(n==0||n==1){
            return 1;
        }else{
            return n * factorialNumber(n-1);
        }
    }

    public long exponentiation(int numberTwo){
        if(numberTwo==1){
            return number;
        }else {
            return number * exponentiation(numberTwo - 1);
        }
    }
    public class Funtions {

        public long getFactorialResult() {
            return factorialNumber(number);
        }

        public long getExponentiationResult() {
            return exponentiation(numberTwo);
        }
    }

}


