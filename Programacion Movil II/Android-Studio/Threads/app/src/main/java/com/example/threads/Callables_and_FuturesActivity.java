package com.example.threads;

import androidx.appcompat.app.AppCompatActivity;
import androidx.arch.core.util.Function;

import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.example.threads.CallablesAndFutures.Recursividad;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;

public class Callables_and_FuturesActivity extends AppCompatActivity {
    private EditText numberEditText;
    private Button calculateButton;
    private TextView resultTextView;
    private EditText numberEditText2;
    private EditText numberEditText3;
    private Button calculateButton2;
    private TextView resultTextView2;
    private Handler handler;
    int item=0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_callables_and_futures);
        handler=new Handler(Looper.getMainLooper());
        numberEditText=findViewById(R.id.numberEditText);
        numberEditText2=findViewById(R.id.numberEditText2);
        numberEditText3=findViewById(R.id.numberEditText3);
        calculateButton = findViewById(R.id.calculateButton);
        calculateButton2 = findViewById(R.id.calculateButton2);
        resultTextView = findViewById(R.id.resultTextView);
        resultTextView2 = findViewById(R.id.resultTextView2);
        calculateButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int number = Integer.parseInt(numberEditText.getText().toString());
                Recursividad factorial = new Recursividad(number);
                ExecutorService executorService = Executors.newSingleThreadExecutor();
                Future<Recursividad.Funtions> futureResult = executorService.submit(factorial);
                executorService.shutdown();
                handleResult(futureResult);
                item=1;
            }
        });
        calculateButton2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int number=Integer.parseInt(numberEditText2.getText().toString());
                int numberTwo=Integer.parseInt(numberEditText3.getText().toString());
                Recursividad exponentation=new Recursividad(number);
                exponentation.setNumberTwo(numberTwo);
                ExecutorService executorService = Executors.newSingleThreadExecutor();
                Future<Recursividad.Funtions> futureResult = executorService.submit(exponentation);
                executorService.shutdown();
                handleResult(futureResult);
                item=2;
            }
        });
    }
    public void handleResult(Future<Recursividad.Funtions> future){
        new Thread(new Runnable() {
            @Override
            public void run() {
                try {
                    Recursividad.Funtions result=future.get();
                    switch (item){
                        case 1:{
                            long factorialResult = result.getFactorialResult();
                            handler.post(new Runnable() {
                                @Override
                                public void run() {
                                    resultTextView.setText("Factorial:"+ factorialResult);
                                }
                            });
                            break;
                        }
                        case 2:{
                            long exponentationResult = result.getExponentiationResult();
                            handler.post(new Runnable() {
                                @Override
                                public void run() {
                                    resultTextView2.setText("Potencia:"+ exponentationResult);
                                }
                            });
                            break;
                        }
                    }

                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        }).start();
    }
}